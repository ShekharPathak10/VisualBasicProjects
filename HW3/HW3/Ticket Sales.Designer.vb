<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketSalesForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PurchaseButton = New System.Windows.Forms.Button()
        Me.NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SectionLabel = New System.Windows.Forms.Label()
        Me.SectionListBox = New System.Windows.Forms.ListBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.HeadingLabel = New System.Windows.Forms.Label()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.SummaryTextBox = New System.Windows.Forms.TextBox()
        Me.PriceSummaryLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PurchaseButton)
        Me.GroupBox1.Controls.Add(Me.NumberTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SectionLabel)
        Me.GroupBox1.Controls.Add(Me.SectionListBox)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 124)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Section and Number of Tickets"
        '
        'PurchaseButton
        '
        Me.PurchaseButton.Location = New System.Drawing.Point(107, 90)
        Me.PurchaseButton.Name = "PurchaseButton"
        Me.PurchaseButton.Size = New System.Drawing.Size(100, 23)
        Me.PurchaseButton.TabIndex = 4
        Me.PurchaseButton.Text = "Purchase Tickets"
        Me.PurchaseButton.UseVisualStyleBackColor = True
        '
        'NumberTextBox
        '
        Me.NumberTextBox.Location = New System.Drawing.Point(107, 60)
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumberTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Number:"
        '
        'SectionLabel
        '
        Me.SectionLabel.AutoSize = True
        Me.SectionLabel.Location = New System.Drawing.Point(6, 28)
        Me.SectionLabel.Name = "SectionLabel"
        Me.SectionLabel.Size = New System.Drawing.Size(46, 13)
        Me.SectionLabel.TabIndex = 1
        Me.SectionLabel.Text = "Section:"
        '
        'SectionListBox
        '
        Me.SectionListBox.FormattingEnabled = True
        Me.SectionListBox.Location = New System.Drawing.Point(6, 44)
        Me.SectionListBox.Name = "SectionListBox"
        Me.SectionListBox.Size = New System.Drawing.Size(71, 69)
        Me.SectionListBox.TabIndex = 0
        '
        'HeadingLabel
        '
        Me.HeadingLabel.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeadingLabel.Location = New System.Drawing.Point(10, 9)
        Me.HeadingLabel.Name = "HeadingLabel"
        Me.HeadingLabel.Size = New System.Drawing.Size(356, 60)
        Me.HeadingLabel.TabIndex = 1
        Me.HeadingLabel.Text = "Concert Ticket Sales"
        Me.HeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Location = New System.Drawing.Point(294, 167)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(72, 13)
        Me.AmountLabel.TabIndex = 2
        Me.AmountLabel.Text = "Amount  Due:"
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTextBox.Location = New System.Drawing.Point(261, 183)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AmountTextBox.Size = New System.Drawing.Size(105, 29)
        Me.AmountTextBox.TabIndex = 5
        Me.AmountTextBox.TabStop = False
        '
        'SummaryTextBox
        '
        Me.SummaryTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SummaryTextBox.Location = New System.Drawing.Point(10, 218)
        Me.SummaryTextBox.Multiline = True
        Me.SummaryTextBox.Name = "SummaryTextBox"
        Me.SummaryTextBox.ReadOnly = True
        Me.SummaryTextBox.Size = New System.Drawing.Size(356, 90)
        Me.SummaryTextBox.TabIndex = 9
        '
        'PriceSummaryLabel
        '
        Me.PriceSummaryLabel.Location = New System.Drawing.Point(258, 88)
        Me.PriceSummaryLabel.Name = "PriceSummaryLabel"
        Me.PriceSummaryLabel.Size = New System.Drawing.Size(108, 67)
        Me.PriceSummaryLabel.TabIndex = 8
        '
        'TicketSalesForm
        '
        Me.AcceptButton = Me.PurchaseButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 323)
        Me.Controls.Add(Me.PriceSummaryLabel)
        Me.Controls.Add(Me.SummaryTextBox)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.AmountLabel)
        Me.Controls.Add(Me.HeadingLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TicketSalesForm"
        Me.Text = "Ticekt Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SectionLabel As Label
    Friend WithEvents SectionListBox As ListBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PurchaseButton As Button
    Friend WithEvents NumberTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents HeadingLabel As Label
    Friend WithEvents AmountLabel As Label
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents SummaryTextBox As TextBox
    Friend WithEvents PriceSummaryLabel As Label
End Class
