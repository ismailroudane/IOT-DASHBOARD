Imports System.Linq
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml


Public Class Form1
    Private Const V As Boolean = False
    Dim StrParse, LDR_1, LDR_2, Pot As String
    Dim LDR_1L, LDR_2L, PotL As Integer
    Dim Limit As Integer = 10
    Dim FilePathAndName As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ButtonDisconnect.Enabled = False
        ButtonConnect.Enabled = False
        ButtonStartRecording.Enabled = False
        ButtonStopRecording.Enabled = False
        ComboBoxBaudRate.SelectedIndex = 3

        ButtonSaveToExcel.Height = 50

        For i = 0 To 30 Step 1
            Chart1.Series("LDR1").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart1.Series(0).Points.Count = Limit Then
                Chart1.Series(0).Points.RemoveAt(0)
            End If
            Chart1.ChartAreas(0).AxisY.Maximum = 1100

            Chart1.Series("LDR2").Points.AddY(0)
            If Chart1.Series(1).Points.Count = Limit Then
                Chart1.Series(1).Points.RemoveAt(0)
            End If

            Chart1.Series("POTENTIO").Points.AddY(0)
            If Chart1.Series(2).Points.Count = Limit Then
                Chart1.Series(2).Points.RemoveAt(0)
            End If
        Next
        Chart1.ChartAreas(0).AxisY.Maximum = 1200
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i
        Try
            ComboBoxPort.SelectedIndex = i
            ButtonConnect.Enabled = True
        Catch ex As Exception
            MsgBox("Com port not detected", MsgBoxStyle.Critical, "Warning !!!")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            ButtonConnect.Enabled = False
            ButtonStartRecording.Enabled = V
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        SerialPort1.BaudRate = ComboBoxBaudRate.SelectedItem
        SerialPort1.PortName = ComboBoxPort.SelectedItem
        SerialPort1.Open()
        TimerSerial.Start()

        ComboBoxPort.Enabled = False
        Label1.Enabled = False
        ComboBoxBaudRate.Enabled = False
        ButtonScanPort.Enabled = False
        ButtonConnect.Enabled = False
        ButtonDisconnect.Enabled = True
        ButtonStartRecording.Enabled = True

        PictureBoxConnectionInd.Image = My.Resources.green
        LabelStatus.Text = "Status : Connected"
    End Sub

    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        PictureBoxConnectionInd.Image = My.Resources.red
        PictureBoxConnectionInd.Visible = True
        LabelStatus.Text = "Status : Disconnect"

        ComboBoxPort.Enabled = True
        Label1.Enabled = True
        ComboBoxBaudRate.Enabled = True
        ButtonScanPort.Enabled = True
        ButtonConnect.Enabled = True
        ButtonDisconnect.Enabled = False

        TimerSerial.Stop()
        TimerDataLogRecord.Stop()

        ButtonSaveToExcel.Enabled = True
        ButtonStopRecording.Enabled = False

        SerialPort1.Close()
    End Sub

    Private Sub ButtonStartRecording_Click(sender As Object, e As EventArgs) Handles ButtonStartRecording.Click
        ButtonStartRecording.Enabled = False
        ButtonStopRecording.Enabled = True
        ButtonSaveToExcel.Enabled = False
        TimerDataLogRecord.Start()
    End Sub

    Private Sub ButtonStopRecording_Click(sender As Object, e As EventArgs) Handles ButtonStopRecording.Click
        ButtonStartRecording.Enabled = True
        ButtonStopRecording.Enabled = False
        ButtonSaveToExcel.Enabled = True
        TimerDataLogRecord.Stop()
        PictureBoxRecordInd.Visible = True
    End Sub



    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        For i = 0 To 30 Step 1
            Chart1.Series("LDR1").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart1.Series(0).Points.Count = Limit Then
                Chart1.Series(0).Points.RemoveAt(0)
            End If
            Chart1.ChartAreas(0).AxisY.Maximum = 1100

            Chart1.Series("LDR2").Points.AddY(0)
            If Chart1.Series(1).Points.Count = Limit Then
                Chart1.Series(1).Points.RemoveAt(0)
            End If

            Chart1.Series("POTENTIO").Points.AddY(0)
            If Chart1.Series(2).Points.Count = Limit Then
                Chart1.Series(2).Points.RemoveAt(0)
            End If
        Next
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub ButtonSaveToExcel_Click(sender As Object, e As EventArgs) Handles ButtonSaveToExcel.Click
        ButtonSaveToExcel.Height = 37
        ButtonSaveToExcel.Text = "Please Wait..."
        ButtonSaveToExcel.Enabled = False
        ButtonStartRecording.Enabled = False
        ProgressBarProcess.Visible = True
        ProgressBarProcess.Value = 1

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        ProgressBarProcess.Value = 3

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("feuil1")

        ProgressBarProcess.Value = 5

        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next

        ProgressBarProcess.Value = 8

        FilePathAndName = Application.StartupPath & "\" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xlsx"
        If File.Exists(FilePathAndName) Then File.Delete(FilePathAndName)

        xlWorkSheet.SaveAs(FilePathAndName)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        ProgressBarProcess.Value = 10

        MsgBox("Successfully saved" & vbCrLf & "File are saved at : " & FilePathAndName, MsgBoxStyle.Information, "Information")

        ProgressBarProcess.Visible = False

        Process.Start(FilePathAndName)

        ButtonSaveToExcel.Height = 50
        ButtonSaveToExcel.Text = "Save To MS Excel"
        ButtonSaveToExcel.Enabled = True
        ButtonStartRecording.Enabled = True
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub TimerDataLogRecord_Tick(sender As Object, e As EventArgs) Handles TimerDataLogRecord.Tick
        Dim LDR_1Log, LDR_2Log, PotLog As String
        Dim DT As DateTime = Now

        LDR_1Log = Mid(LDR_1, 3, LDR_1L)
        LDR_2Log = Mid(LDR_2, 3, LDR_2L)
        PotLog = Mid(Pot, 3, PotL)
        DataGridView1.Rows.Add(New String() {DataGridView1.RowCount, LDR_1Log, LDR_2Log, PotLog, DT.ToLongTimeString, DT.ToString("dd-MM-yyyy")})
        Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1

        Chart1.Series("LDR1").Points.AddXY(DateTime.Now.ToLongTimeString, LDR_1Log)
        If Chart1.Series(0).Points.Count = Limit Then
            Chart1.Series(0).Points.RemoveAt(0)
        End If

        Chart1.Series("LDR2").Points.AddY(LDR_2Log)
        If Chart1.Series(1).Points.Count = Limit Then
            Chart1.Series(1).Points.RemoveAt(0)
        End If

        Chart1.Series("POTENTIO").Points.AddY(PotLog)
        If Chart1.Series(2).Points.Count = Limit Then
            Chart1.Series(2).Points.RemoveAt(0)
        End If

        If PictureBoxRecordInd.Visible = True Then
            PictureBoxRecordInd.Visible = False
        ElseIf PictureBoxRecordInd.Visible = False Then
            PictureBoxRecordInd.Visible = True
        End If
    End Sub
    Private Sub TimerSerial_Tick(sender As Object, e As EventArgs) Handles TimerSerial.Tick
        Try
            Dim StrSerialIn As String = SerialPort1.ReadExisting
            Dim StrSerialInRam As String

            Dim TB As New TextBox
            TB.Multiline = True
            TB.Text = StrSerialIn

            StrSerialInRam = TB.Lines(0).Substring(0, 2)
            If StrSerialInRam = "L1" Then
                LDR_1 = TB.Lines(0)
                LDR_1L = LDR_1.Length
            Else
                LDR_1 = LDR_1
            End If

            StrSerialInRam = TB.Lines(1).Substring(0, 2)
            If StrSerialInRam = "L2" Then
                LDR_2 = TB.Lines(1)
                LDR_2L = LDR_2.Length
            Else
                LDR_2 = LDR_2
            End If

            StrSerialInRam = TB.Lines(2).Substring(0, 2)
            If StrSerialInRam = "Pt" Then
                Pot = TB.Lines(2)
                PotL = Pot.Length
            Else
                Pot = Pot
            End If

            If PictureBoxConnectionInd.Visible = True Then
                PictureBoxConnectionInd.Visible = False
            ElseIf PictureBoxConnectionInd.Visible = False Then
                PictureBoxConnectionInd.Visible = True
            End If

            LabelLDR1.Text = "LDR1 = " & Mid(LDR_1, 3, LDR_1L)
            LabelLDR2.Text = "LDR2 = " & Mid(LDR_2, 3, LDR_2L)
            LabelPOT.Text = "POTENTIO = " & Mid(Pot, 3, PotL)
        Catch ex As Exception

        End Try
    End Sub
End Class
