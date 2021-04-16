<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COVID19TemperatureRecorder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CurrentReadingGroupBox = New System.Windows.Forms.GroupBox()
        Me.ClearReadingButton = New System.Windows.Forms.Button()
        Me.RecordReadingButton = New System.Windows.Forms.Button()
        Me.CurrentTemperatureLabel = New System.Windows.Forms.Label()
        Me.CurrentTemperatureTextBox = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ReadingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ReadingsListBox = New System.Windows.Forms.ListBox()
        Me.LastReadingGroupBox = New System.Windows.Forms.GroupBox()
        Me.LastDiagnosisLabel = New System.Windows.Forms.Label()
        Me.LastReadingDiagnosisTextBox = New System.Windows.Forms.TextBox()
        Me.LastReadingTemperatureTextBox = New System.Windows.Forms.TextBox()
        Me.LastTemperatureLabel = New System.Windows.Forms.Label()
        Me.AverageGroupBox = New System.Windows.Forms.GroupBox()
        Me.AverageDiagnosisLabel = New System.Windows.Forms.Label()
        Me.AverageDiagnosisTextBox = New System.Windows.Forms.TextBox()
        Me.AverageTemperatureTextBox = New System.Windows.Forms.TextBox()
        Me.AverageTemperatureLabel = New System.Windows.Forms.Label()
        Me.CurrentReadingGroupBox.SuspendLayout()
        Me.ReadingsGroupBox.SuspendLayout()
        Me.LastReadingGroupBox.SuspendLayout()
        Me.AverageGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CurrentReadingGroupBox
        '
        Me.CurrentReadingGroupBox.Controls.Add(Me.ClearReadingButton)
        Me.CurrentReadingGroupBox.Controls.Add(Me.RecordReadingButton)
        Me.CurrentReadingGroupBox.Controls.Add(Me.CurrentTemperatureLabel)
        Me.CurrentReadingGroupBox.Controls.Add(Me.CurrentTemperatureTextBox)
        Me.CurrentReadingGroupBox.Location = New System.Drawing.Point(12, 24)
        Me.CurrentReadingGroupBox.Name = "CurrentReadingGroupBox"
        Me.CurrentReadingGroupBox.Size = New System.Drawing.Size(224, 100)
        Me.CurrentReadingGroupBox.TabIndex = 0
        Me.CurrentReadingGroupBox.TabStop = False
        Me.CurrentReadingGroupBox.Text = "Current Reading"
        '
        'ClearReadingButton
        '
        Me.ClearReadingButton.Location = New System.Drawing.Point(119, 61)
        Me.ClearReadingButton.Name = "ClearReadingButton"
        Me.ClearReadingButton.Size = New System.Drawing.Size(91, 23)
        Me.ClearReadingButton.TabIndex = 3
        Me.ClearReadingButton.Text = "Clear Readings"
        Me.ClearReadingButton.UseVisualStyleBackColor = True
        '
        'RecordReadingButton
        '
        Me.RecordReadingButton.Location = New System.Drawing.Point(6, 61)
        Me.RecordReadingButton.Name = "RecordReadingButton"
        Me.RecordReadingButton.Size = New System.Drawing.Size(104, 23)
        Me.RecordReadingButton.TabIndex = 2
        Me.RecordReadingButton.Text = "Record Reading"
        Me.RecordReadingButton.UseVisualStyleBackColor = True
        '
        'CurrentTemperatureLabel
        '
        Me.CurrentTemperatureLabel.AutoSize = True
        Me.CurrentTemperatureLabel.Location = New System.Drawing.Point(22, 26)
        Me.CurrentTemperatureLabel.Name = "CurrentTemperatureLabel"
        Me.CurrentTemperatureLabel.Size = New System.Drawing.Size(67, 13)
        Me.CurrentTemperatureLabel.TabIndex = 1
        Me.CurrentTemperatureLabel.Text = "Temperature"
        '
        'CurrentTemperatureTextBox
        '
        Me.CurrentTemperatureTextBox.Location = New System.Drawing.Point(95, 23)
        Me.CurrentTemperatureTextBox.Name = "CurrentTemperatureTextBox"
        Me.CurrentTemperatureTextBox.Size = New System.Drawing.Size(115, 20)
        Me.CurrentTemperatureTextBox.TabIndex = 0
        '
        'ReadingsGroupBox
        '
        Me.ReadingsGroupBox.Controls.Add(Me.ReadingsListBox)
        Me.ReadingsGroupBox.Location = New System.Drawing.Point(259, 12)
        Me.ReadingsGroupBox.Name = "ReadingsGroupBox"
        Me.ReadingsGroupBox.Size = New System.Drawing.Size(98, 338)
        Me.ReadingsGroupBox.TabIndex = 1
        Me.ReadingsGroupBox.TabStop = False
        Me.ReadingsGroupBox.Text = "Readings"
        '
        'ReadingsListBox
        '
        Me.ReadingsListBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReadingsListBox.FormattingEnabled = True
        Me.ReadingsListBox.ItemHeight = 21
        Me.ReadingsListBox.Location = New System.Drawing.Point(8, 16)
        Me.ReadingsListBox.Name = "ReadingsListBox"
        Me.ReadingsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ReadingsListBox.Size = New System.Drawing.Size(84, 319)
        Me.ReadingsListBox.TabIndex = 0
        '
        'LastReadingGroupBox
        '
        Me.LastReadingGroupBox.Controls.Add(Me.LastDiagnosisLabel)
        Me.LastReadingGroupBox.Controls.Add(Me.LastReadingDiagnosisTextBox)
        Me.LastReadingGroupBox.Controls.Add(Me.LastReadingTemperatureTextBox)
        Me.LastReadingGroupBox.Controls.Add(Me.LastTemperatureLabel)
        Me.LastReadingGroupBox.Location = New System.Drawing.Point(12, 130)
        Me.LastReadingGroupBox.Name = "LastReadingGroupBox"
        Me.LastReadingGroupBox.Size = New System.Drawing.Size(224, 105)
        Me.LastReadingGroupBox.TabIndex = 2
        Me.LastReadingGroupBox.TabStop = False
        Me.LastReadingGroupBox.Text = "Last Reading"
        '
        'LastDiagnosisLabel
        '
        Me.LastDiagnosisLabel.AutoSize = True
        Me.LastDiagnosisLabel.Location = New System.Drawing.Point(36, 69)
        Me.LastDiagnosisLabel.Name = "LastDiagnosisLabel"
        Me.LastDiagnosisLabel.Size = New System.Drawing.Size(53, 13)
        Me.LastDiagnosisLabel.TabIndex = 5
        Me.LastDiagnosisLabel.Text = "Diagnosis"
        '
        'LastReadingDiagnosisTextBox
        '
        Me.LastReadingDiagnosisTextBox.Location = New System.Drawing.Point(95, 66)
        Me.LastReadingDiagnosisTextBox.Name = "LastReadingDiagnosisTextBox"
        Me.LastReadingDiagnosisTextBox.ReadOnly = True
        Me.LastReadingDiagnosisTextBox.Size = New System.Drawing.Size(115, 20)
        Me.LastReadingDiagnosisTextBox.TabIndex = 4
        '
        'LastReadingTemperatureTextBox
        '
        Me.LastReadingTemperatureTextBox.Location = New System.Drawing.Point(95, 27)
        Me.LastReadingTemperatureTextBox.Name = "LastReadingTemperatureTextBox"
        Me.LastReadingTemperatureTextBox.ReadOnly = True
        Me.LastReadingTemperatureTextBox.Size = New System.Drawing.Size(115, 20)
        Me.LastReadingTemperatureTextBox.TabIndex = 3
        '
        'LastTemperatureLabel
        '
        Me.LastTemperatureLabel.AutoSize = True
        Me.LastTemperatureLabel.Location = New System.Drawing.Point(22, 30)
        Me.LastTemperatureLabel.Name = "LastTemperatureLabel"
        Me.LastTemperatureLabel.Size = New System.Drawing.Size(67, 13)
        Me.LastTemperatureLabel.TabIndex = 2
        Me.LastTemperatureLabel.Text = "Temperature"
        '
        'AverageGroupBox
        '
        Me.AverageGroupBox.Controls.Add(Me.AverageDiagnosisLabel)
        Me.AverageGroupBox.Controls.Add(Me.AverageDiagnosisTextBox)
        Me.AverageGroupBox.Controls.Add(Me.AverageTemperatureTextBox)
        Me.AverageGroupBox.Controls.Add(Me.AverageTemperatureLabel)
        Me.AverageGroupBox.Location = New System.Drawing.Point(12, 241)
        Me.AverageGroupBox.Name = "AverageGroupBox"
        Me.AverageGroupBox.Size = New System.Drawing.Size(224, 109)
        Me.AverageGroupBox.TabIndex = 3
        Me.AverageGroupBox.TabStop = False
        Me.AverageGroupBox.Text = "14 Day Average"
        '
        'AverageDiagnosisLabel
        '
        Me.AverageDiagnosisLabel.AutoSize = True
        Me.AverageDiagnosisLabel.Location = New System.Drawing.Point(36, 70)
        Me.AverageDiagnosisLabel.Name = "AverageDiagnosisLabel"
        Me.AverageDiagnosisLabel.Size = New System.Drawing.Size(53, 13)
        Me.AverageDiagnosisLabel.TabIndex = 9
        Me.AverageDiagnosisLabel.Text = "Diagnosis"
        '
        'AverageDiagnosisTextBox
        '
        Me.AverageDiagnosisTextBox.Location = New System.Drawing.Point(95, 67)
        Me.AverageDiagnosisTextBox.Name = "AverageDiagnosisTextBox"
        Me.AverageDiagnosisTextBox.ReadOnly = True
        Me.AverageDiagnosisTextBox.Size = New System.Drawing.Size(115, 20)
        Me.AverageDiagnosisTextBox.TabIndex = 8
        '
        'AverageTemperatureTextBox
        '
        Me.AverageTemperatureTextBox.Location = New System.Drawing.Point(95, 32)
        Me.AverageTemperatureTextBox.Name = "AverageTemperatureTextBox"
        Me.AverageTemperatureTextBox.ReadOnly = True
        Me.AverageTemperatureTextBox.Size = New System.Drawing.Size(115, 20)
        Me.AverageTemperatureTextBox.TabIndex = 7
        '
        'AverageTemperatureLabel
        '
        Me.AverageTemperatureLabel.AutoSize = True
        Me.AverageTemperatureLabel.Location = New System.Drawing.Point(22, 35)
        Me.AverageTemperatureLabel.Name = "AverageTemperatureLabel"
        Me.AverageTemperatureLabel.Size = New System.Drawing.Size(67, 13)
        Me.AverageTemperatureLabel.TabIndex = 6
        Me.AverageTemperatureLabel.Text = "Temperature"
        '
        'COVID19TemperatureRecorder
        '
        Me.AcceptButton = Me.RecordReadingButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 363)
        Me.Controls.Add(Me.AverageGroupBox)
        Me.Controls.Add(Me.LastReadingGroupBox)
        Me.Controls.Add(Me.ReadingsGroupBox)
        Me.Controls.Add(Me.CurrentReadingGroupBox)
        Me.Name = "COVID19TemperatureRecorder"
        Me.Text = "COVID-19 Temperature Recorder"
        Me.CurrentReadingGroupBox.ResumeLayout(False)
        Me.CurrentReadingGroupBox.PerformLayout()
        Me.ReadingsGroupBox.ResumeLayout(False)
        Me.LastReadingGroupBox.ResumeLayout(False)
        Me.LastReadingGroupBox.PerformLayout()
        Me.AverageGroupBox.ResumeLayout(False)
        Me.AverageGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CurrentReadingGroupBox As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ReadingsGroupBox As GroupBox
    Friend WithEvents CurrentTemperatureLabel As Label
    Friend WithEvents CurrentTemperatureTextBox As TextBox
    Friend WithEvents LastReadingGroupBox As GroupBox
    Friend WithEvents AverageGroupBox As GroupBox
    Friend WithEvents ClearReadingButton As Button
    Friend WithEvents RecordReadingButton As Button
    Friend WithEvents LastDiagnosisLabel As Label
    Friend WithEvents LastReadingDiagnosisTextBox As TextBox
    Friend WithEvents LastReadingTemperatureTextBox As TextBox
    Friend WithEvents LastTemperatureLabel As Label
    Friend WithEvents AverageDiagnosisLabel As Label
    Friend WithEvents AverageDiagnosisTextBox As TextBox
    Friend WithEvents AverageTemperatureTextBox As TextBox
    Friend WithEvents AverageTemperatureLabel As Label
    Friend WithEvents ReadingsListBox As ListBox
End Class
