<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.TotalSalesLabel1 = New System.Windows.Forms.Label()
        Me.TotalCommissionsLabel1 = New System.Windows.Forms.Label()
        Me.TotalPayLabel1 = New System.Windows.Forms.Label()
        Me.TotalSalesLabel = New System.Windows.Forms.Label()
        Me.TotalCommissionsLabel = New System.Windows.Forms.Label()
        Me.TotalPayLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TotalSalesLabel1
        '
        Me.TotalSalesLabel1.AutoSize = True
        Me.TotalSalesLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSalesLabel1.Location = New System.Drawing.Point(56, 36)
        Me.TotalSalesLabel1.Name = "TotalSalesLabel1"
        Me.TotalSalesLabel1.Size = New System.Drawing.Size(71, 15)
        Me.TotalSalesLabel1.TabIndex = 0
        Me.TotalSalesLabel1.Text = "Total Sales:"
        '
        'TotalCommissionsLabel1
        '
        Me.TotalCommissionsLabel1.AutoSize = True
        Me.TotalCommissionsLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCommissionsLabel1.Location = New System.Drawing.Point(12, 85)
        Me.TotalCommissionsLabel1.Name = "TotalCommissionsLabel1"
        Me.TotalCommissionsLabel1.Size = New System.Drawing.Size(115, 15)
        Me.TotalCommissionsLabel1.TabIndex = 1
        Me.TotalCommissionsLabel1.Text = "Total Commissions:"
        '
        'TotalPayLabel1
        '
        Me.TotalPayLabel1.AutoSize = True
        Me.TotalPayLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPayLabel1.Location = New System.Drawing.Point(67, 131)
        Me.TotalPayLabel1.Name = "TotalPayLabel1"
        Me.TotalPayLabel1.Size = New System.Drawing.Size(60, 15)
        Me.TotalPayLabel1.TabIndex = 2
        Me.TotalPayLabel1.Text = "Total Pay:"
        '
        'TotalSalesLabel
        '
        Me.TotalSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalSalesLabel.Location = New System.Drawing.Point(165, 36)
        Me.TotalSalesLabel.Name = "TotalSalesLabel"
        Me.TotalSalesLabel.Size = New System.Drawing.Size(189, 22)
        Me.TotalSalesLabel.TabIndex = 3
        '
        'TotalCommissionsLabel
        '
        Me.TotalCommissionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalCommissionsLabel.Location = New System.Drawing.Point(165, 85)
        Me.TotalCommissionsLabel.Name = "TotalCommissionsLabel"
        Me.TotalCommissionsLabel.Size = New System.Drawing.Size(189, 22)
        Me.TotalCommissionsLabel.TabIndex = 4
        '
        'TotalPayLabel
        '
        Me.TotalPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalPayLabel.Location = New System.Drawing.Point(165, 131)
        Me.TotalPayLabel.Name = "TotalPayLabel"
        Me.TotalPayLabel.Size = New System.Drawing.Size(189, 22)
        Me.TotalPayLabel.TabIndex = 5
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 175)
        Me.Controls.Add(Me.TotalPayLabel)
        Me.Controls.Add(Me.TotalCommissionsLabel)
        Me.Controls.Add(Me.TotalSalesLabel)
        Me.Controls.Add(Me.TotalPayLabel1)
        Me.Controls.Add(Me.TotalCommissionsLabel1)
        Me.Controls.Add(Me.TotalSalesLabel1)
        Me.Name = "SummaryForm"
        Me.Text = "SummaryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TotalSalesLabel1 As Label
    Friend WithEvents TotalCommissionsLabel1 As Label
    Friend WithEvents TotalPayLabel1 As Label
    Friend WithEvents TotalSalesLabel As Label
    Friend WithEvents TotalCommissionsLabel As Label
    Friend WithEvents TotalPayLabel As Label
End Class
