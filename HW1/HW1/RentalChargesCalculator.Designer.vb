<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RentalChargesCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DaysTextBox = New System.Windows.Forms.TextBox()
        Me.EndingOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.BeginningOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.DaysLabel = New System.Windows.Forms.Label()
        Me.EndingOdometerLabel = New System.Windows.Forms.Label()
        Me.BeginningOdometerLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TotalChargeTextBox = New System.Windows.Forms.TextBox()
        Me.MilesDrivenTextBox = New System.Windows.Forms.TextBox()
        Me.TotalChargeLabel = New System.Windows.Forms.Label()
        Me.MilesDrivenLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DaysTextBox)
        Me.GroupBox1.Controls.Add(Me.EndingOdometerTextBox)
        Me.GroupBox1.Controls.Add(Me.BeginningOdometerTextBox)
        Me.GroupBox1.Controls.Add(Me.DaysLabel)
        Me.GroupBox1.Controls.Add(Me.EndingOdometerLabel)
        Me.GroupBox1.Controls.Add(Me.BeginningOdometerLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 146)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Rental Information"
        '
        'DaysTextBox
        '
        Me.DaysTextBox.Location = New System.Drawing.Point(185, 95)
        Me.DaysTextBox.Name = "DaysTextBox"
        Me.DaysTextBox.Size = New System.Drawing.Size(71, 24)
        Me.DaysTextBox.TabIndex = 5
        '
        'EndingOdometerTextBox
        '
        Me.EndingOdometerTextBox.Location = New System.Drawing.Point(185, 61)
        Me.EndingOdometerTextBox.Name = "EndingOdometerTextBox"
        Me.EndingOdometerTextBox.Size = New System.Drawing.Size(138, 24)
        Me.EndingOdometerTextBox.TabIndex = 4
        '
        'BeginningOdometerTextBox
        '
        Me.BeginningOdometerTextBox.Location = New System.Drawing.Point(185, 27)
        Me.BeginningOdometerTextBox.Name = "BeginningOdometerTextBox"
        Me.BeginningOdometerTextBox.Size = New System.Drawing.Size(138, 24)
        Me.BeginningOdometerTextBox.TabIndex = 3
        '
        'DaysLabel
        '
        Me.DaysLabel.AutoSize = True
        Me.DaysLabel.Location = New System.Drawing.Point(17, 95)
        Me.DaysLabel.Name = "DaysLabel"
        Me.DaysLabel.Size = New System.Drawing.Size(120, 18)
        Me.DaysLabel.TabIndex = 2
        Me.DaysLabel.Text = "Number of Days:"
        '
        'EndingOdometerLabel
        '
        Me.EndingOdometerLabel.AutoSize = True
        Me.EndingOdometerLabel.Location = New System.Drawing.Point(17, 61)
        Me.EndingOdometerLabel.Name = "EndingOdometerLabel"
        Me.EndingOdometerLabel.Size = New System.Drawing.Size(128, 18)
        Me.EndingOdometerLabel.TabIndex = 1
        Me.EndingOdometerLabel.Text = "Ending Odometer:"
        '
        'BeginningOdometerLabel
        '
        Me.BeginningOdometerLabel.AutoSize = True
        Me.BeginningOdometerLabel.Location = New System.Drawing.Point(17, 27)
        Me.BeginningOdometerLabel.Name = "BeginningOdometerLabel"
        Me.BeginningOdometerLabel.Size = New System.Drawing.Size(147, 18)
        Me.BeginningOdometerLabel.TabIndex = 0
        Me.BeginningOdometerLabel.Text = "Beginning Odometer:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TotalChargeTextBox)
        Me.GroupBox2.Controls.Add(Me.MilesDrivenTextBox)
        Me.GroupBox2.Controls.Add(Me.TotalChargeLabel)
        Me.GroupBox2.Controls.Add(Me.MilesDrivenLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(401, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 146)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totals"
        '
        'TotalChargeTextBox
        '
        Me.TotalChargeTextBox.Location = New System.Drawing.Point(45, 105)
        Me.TotalChargeTextBox.Name = "TotalChargeTextBox"
        Me.TotalChargeTextBox.ReadOnly = True
        Me.TotalChargeTextBox.Size = New System.Drawing.Size(138, 24)
        Me.TotalChargeTextBox.TabIndex = 5
        Me.TotalChargeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MilesDrivenTextBox
        '
        Me.MilesDrivenTextBox.Location = New System.Drawing.Point(45, 47)
        Me.MilesDrivenTextBox.Name = "MilesDrivenTextBox"
        Me.MilesDrivenTextBox.ReadOnly = True
        Me.MilesDrivenTextBox.Size = New System.Drawing.Size(138, 24)
        Me.MilesDrivenTextBox.TabIndex = 4
        Me.MilesDrivenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalChargeLabel
        '
        Me.TotalChargeLabel.AutoSize = True
        Me.TotalChargeLabel.Location = New System.Drawing.Point(52, 85)
        Me.TotalChargeLabel.Name = "TotalChargeLabel"
        Me.TotalChargeLabel.Size = New System.Drawing.Size(97, 18)
        Me.TotalChargeLabel.TabIndex = 2
        Me.TotalChargeLabel.Text = "Total Charge:"
        '
        'MilesDrivenLabel
        '
        Me.MilesDrivenLabel.AutoSize = True
        Me.MilesDrivenLabel.Location = New System.Drawing.Point(52, 27)
        Me.MilesDrivenLabel.Name = "MilesDrivenLabel"
        Me.MilesDrivenLabel.Size = New System.Drawing.Size(93, 18)
        Me.MilesDrivenLabel.TabIndex = 1
        Me.MilesDrivenLabel.Text = "Miles Driven:"
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(317, 183)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(103, 36)
        Me.CalculateButton.TabIndex = 2
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(439, 183)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(103, 36)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(558, 183)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(103, 36)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'RentalChargesCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 231)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "RentalChargesCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rental Charges"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DaysTextBox As TextBox
    Friend WithEvents EndingOdometerTextBox As TextBox
    Friend WithEvents BeginningOdometerTextBox As TextBox
    Friend WithEvents DaysLabel As Label
    Friend WithEvents EndingOdometerLabel As Label
    Friend WithEvents BeginningOdometerLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TotalChargeTextBox As TextBox
    Friend WithEvents MilesDrivenTextBox As TextBox
    Friend WithEvents TotalChargeLabel As Label
    Friend WithEvents MilesDrivenLabel As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
End Class
