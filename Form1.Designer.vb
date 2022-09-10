<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxConnectionInd = New System.Windows.Forms.PictureBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ButtonDisconnect = New System.Windows.Forms.Button()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelPOT = New System.Windows.Forms.Label()
        Me.LabelLDR2 = New System.Windows.Forms.Label()
        Me.LabelLDR1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxRecordInd = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonStopRecording = New System.Windows.Forms.Button()
        Me.ButtonStartRecording = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ProgressBarProcess = New System.Windows.Forms.ProgressBar()
        Me.ButtonSaveToExcel = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDR1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDR2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POTENTIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIME_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerDataLogRecord = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxConnectionInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBoxRecordInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.PictureBoxConnectionInd)
        Me.GroupBox1.Controls.Add(Me.LabelStatus)
        Me.GroupBox1.Controls.Add(Me.ButtonDisconnect)
        Me.GroupBox1.Controls.Add(Me.ButtonConnect)
        Me.GroupBox1.Controls.Add(Me.ComboBoxBaudRate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPort)
        Me.GroupBox1.Controls.Add(Me.ButtonScanPort)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection"
        '
        'PictureBoxConnectionInd
        '
        Me.PictureBoxConnectionInd.Image = Global.ArduinoSerial.My.Resources.Resources.red
        Me.PictureBoxConnectionInd.Location = New System.Drawing.Point(289, 16)
        Me.PictureBoxConnectionInd.Name = "PictureBoxConnectionInd"
        Me.PictureBoxConnectionInd.Size = New System.Drawing.Size(12, 12)
        Me.PictureBoxConnectionInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxConnectionInd.TabIndex = 6
        Me.PictureBoxConnectionInd.TabStop = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(164, 17)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(112, 13)
        Me.LabelStatus.TabIndex = 5
        Me.LabelStatus.Text = "Status : Disconnected"
        '
        'ButtonDisconnect
        '
        Me.ButtonDisconnect.Location = New System.Drawing.Point(165, 61)
        Me.ButtonDisconnect.Name = "ButtonDisconnect"
        Me.ButtonDisconnect.Size = New System.Drawing.Size(148, 23)
        Me.ButtonDisconnect.TabIndex = 4
        Me.ButtonDisconnect.Text = "Disconnect"
        Me.ButtonDisconnect.UseVisualStyleBackColor = True
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(6, 61)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(153, 23)
        Me.ButtonConnect.TabIndex = 1
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(222, 34)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(93, 21)
        Me.ComboBoxBaudRate.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(150, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Baude Rate  :"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(87, 33)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(63, 21)
        Me.ComboBoxPort.TabIndex = 1
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.Location = New System.Drawing.Point(6, 33)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(75, 21)
        Me.ButtonScanPort.TabIndex = 0
        Me.ButtonScanPort.Text = "Scan port"
        Me.ButtonScanPort.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.LabelPOT)
        Me.GroupBox2.Controls.Add(Me.LabelLDR2)
        Me.GroupBox2.Controls.Add(Me.LabelLDR1)
        Me.GroupBox2.Location = New System.Drawing.Point(337, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 105)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Les donnée en temps réel "
        '
        'LabelPOT
        '
        Me.LabelPOT.AutoSize = True
        Me.LabelPOT.Location = New System.Drawing.Point(7, 81)
        Me.LabelPOT.Name = "LabelPOT"
        Me.LabelPOT.Size = New System.Drawing.Size(52, 13)
        Me.LabelPOT.TabIndex = 2
        Me.LabelPOT.Text = "Waiting..."
        '
        'LabelLDR2
        '
        Me.LabelLDR2.AutoSize = True
        Me.LabelLDR2.Location = New System.Drawing.Point(7, 50)
        Me.LabelLDR2.Name = "LabelLDR2"
        Me.LabelLDR2.Size = New System.Drawing.Size(52, 13)
        Me.LabelLDR2.TabIndex = 1
        Me.LabelLDR2.Text = "Waiting..."
        '
        'LabelLDR1
        '
        Me.LabelLDR1.AutoSize = True
        Me.LabelLDR1.Location = New System.Drawing.Point(7, 20)
        Me.LabelLDR1.Name = "LabelLDR1"
        Me.LabelLDR1.Size = New System.Drawing.Size(52, 13)
        Me.LabelLDR1.TabIndex = 0
        Me.LabelLDR1.Text = "Waiting..."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Controls.Add(Me.PictureBoxRecordInd)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.ButtonClear)
        Me.GroupBox3.Controls.Add(Me.ButtonStopRecording)
        Me.GroupBox3.Controls.Add(Me.ButtonStartRecording)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 123)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(319, 78)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Control"
        '
        'PictureBoxRecordInd
        '
        Me.PictureBoxRecordInd.Image = Global.ArduinoSerial.My.Resources.Resources.red
        Me.PictureBoxRecordInd.Location = New System.Drawing.Point(288, 4)
        Me.PictureBoxRecordInd.Name = "PictureBoxRecordInd"
        Me.PictureBoxRecordInd.Size = New System.Drawing.Size(13, 13)
        Me.PictureBoxRecordInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxRecordInd.TabIndex = 4
        Me.PictureBoxRecordInd.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "enregistrement :"
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(7, 50)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(298, 23)
        Me.ButtonClear.TabIndex = 2
        Me.ButtonClear.Text = "Reset Graph et Tableau"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonStopRecording
        '
        Me.ButtonStopRecording.Location = New System.Drawing.Point(156, 20)
        Me.ButtonStopRecording.Name = "ButtonStopRecording"
        Me.ButtonStopRecording.Size = New System.Drawing.Size(149, 23)
        Me.ButtonStopRecording.TabIndex = 1
        Me.ButtonStopRecording.Text = "Arreter l'enregistrement "
        Me.ButtonStopRecording.UseVisualStyleBackColor = True
        '
        'ButtonStartRecording
        '
        Me.ButtonStartRecording.Location = New System.Drawing.Point(7, 20)
        Me.ButtonStartRecording.Name = "ButtonStartRecording"
        Me.ButtonStartRecording.Size = New System.Drawing.Size(143, 23)
        Me.ButtonStartRecording.TabIndex = 0
        Me.ButtonStartRecording.Text = "Demarrer l'enregistement "
        Me.ButtonStartRecording.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Controls.Add(Me.ProgressBarProcess)
        Me.GroupBox4.Controls.Add(Me.ButtonSaveToExcel)
        Me.GroupBox4.Location = New System.Drawing.Point(337, 123)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(247, 78)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Exporter les données"
        '
        'ProgressBarProcess
        '
        Me.ProgressBarProcess.Location = New System.Drawing.Point(10, 60)
        Me.ProgressBarProcess.Maximum = 10
        Me.ProgressBarProcess.Name = "ProgressBarProcess"
        Me.ProgressBarProcess.Size = New System.Drawing.Size(231, 10)
        Me.ProgressBarProcess.TabIndex = 1
        Me.ProgressBarProcess.Visible = False
        '
        'ButtonSaveToExcel
        '
        Me.ButtonSaveToExcel.Location = New System.Drawing.Point(10, 19)
        Me.ButtonSaveToExcel.Name = "ButtonSaveToExcel"
        Me.ButtonSaveToExcel.Size = New System.Drawing.Size(231, 43)
        Me.ButtonSaveToExcel.TabIndex = 0
        Me.ButtonSaveToExcel.Text = "Enregistrer dans l'Exel "
        Me.ButtonSaveToExcel.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 207)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(572, 325)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tableau des données en temps réel "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.LDR1, Me.LDR2, Me.POTENTIO, Me.TIME_, Me.DATE_})
        Me.DataGridView1.Location = New System.Drawing.Point(4, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(562, 277)
        Me.DataGridView1.TabIndex = 0
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.Width = 70
        '
        'LDR1
        '
        Me.LDR1.HeaderText = "LDR1"
        Me.LDR1.Name = "LDR1"
        Me.LDR1.Width = 70
        '
        'LDR2
        '
        Me.LDR2.HeaderText = "LDR2"
        Me.LDR2.Name = "LDR2"
        Me.LDR2.Width = 70
        '
        'POTENTIO
        '
        Me.POTENTIO.HeaderText = "POTENTIO"
        Me.POTENTIO.Name = "POTENTIO"
        '
        'TIME_
        '
        Me.TIME_.HeaderText = "TIME"
        Me.TIME_.Name = "TIME_"
        '
        'DATE_
        '
        Me.DATE_.HeaderText = "DATE"
        Me.DATE_.Name = "DATE_"
        Me.DATE_.Width = 110
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox6.Controls.Add(Me.Chart1)
        Me.GroupBox6.Location = New System.Drawing.Point(590, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(775, 503)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "GroupBox6"
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 14)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Legend = "Legend1"
        Series1.Name = "LDR1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Legend = "Legend1"
        Series2.Name = "LDR2"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Legend = "Legend1"
        Series3.Name = "POTENTIO"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(769, 477)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Me.Chart1.UseWaitCursor = True
        '
        'TimerSerial
        '
        Me.TimerSerial.Interval = 1000
        '
        'TimerDataLogRecord
        '
        Me.TimerDataLogRecord.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1367, 517)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Arduino Data logger"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxConnectionInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBoxRecordInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonDisconnect As Button
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents PictureBoxConnectionInd As PictureBox
    Friend WithEvents LabelStatus As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelPOT As Label
    Friend WithEvents LabelLDR2 As Label
    Friend WithEvents LabelLDR1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBoxRecordInd As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonStopRecording As Button
    Friend WithEvents ButtonStartRecording As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ButtonSaveToExcel As Button
    Friend WithEvents ProgressBarProcess As ProgressBar
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents LDR1 As DataGridViewTextBoxColumn
    Friend WithEvents LDR2 As DataGridViewTextBoxColumn
    Friend WithEvents POTENTIO As DataGridViewTextBoxColumn
    Friend WithEvents TIME_ As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox6 As GroupBox
    Protected WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerDataLogRecord As Timer
End Class
