<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommissionCalculator
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.SalesTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.WeeklySalesLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AmountPaidTextBox = New System.Windows.Forms.TextBox()
        Me.CommissionTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(379, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PayToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PayToolStripMenuItem
        '
        Me.PayToolStripMenuItem.Name = "PayToolStripMenuItem"
        Me.PayToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.PayToolStripMenuItem.Text = "&Pay"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.SalesTextBox)
        Me.GroupBox.Controls.Add(Me.NameTextBox)
        Me.GroupBox.Controls.Add(Me.WeeklySalesLabel)
        Me.GroupBox.Controls.Add(Me.NameLabel)
        Me.GroupBox.Location = New System.Drawing.Point(25, 38)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(330, 98)
        Me.GroupBox.TabIndex = 1
        Me.GroupBox.TabStop = False
        '
        'SalesTextBox
        '
        Me.SalesTextBox.Location = New System.Drawing.Point(144, 61)
        Me.SalesTextBox.Name = "SalesTextBox"
        Me.SalesTextBox.Size = New System.Drawing.Size(118, 20)
        Me.SalesTextBox.TabIndex = 3
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(144, 27)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(158, 20)
        Me.NameTextBox.TabIndex = 2
        '
        'WeeklySalesLabel
        '
        Me.WeeklySalesLabel.AutoSize = True
        Me.WeeklySalesLabel.Location = New System.Drawing.Point(55, 64)
        Me.WeeklySalesLabel.Name = "WeeklySalesLabel"
        Me.WeeklySalesLabel.Size = New System.Drawing.Size(72, 13)
        Me.WeeklySalesLabel.TabIndex = 1
        Me.WeeklySalesLabel.Text = "Weekly Sales"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(24, 30)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(103, 13)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Salesperson's Name"
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Location = New System.Drawing.Point(82, 165)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(70, 13)
        Me.AmountLabel.TabIndex = 2
        Me.AmountLabel.Text = "Amount Paid:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Commission:"
        '
        'AmountPaidTextBox
        '
        Me.AmountPaidTextBox.Location = New System.Drawing.Point(169, 162)
        Me.AmountPaidTextBox.Name = "AmountPaidTextBox"
        Me.AmountPaidTextBox.ReadOnly = True
        Me.AmountPaidTextBox.Size = New System.Drawing.Size(118, 20)
        Me.AmountPaidTextBox.TabIndex = 4
        Me.AmountPaidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CommissionTextBox
        '
        Me.CommissionTextBox.Location = New System.Drawing.Point(169, 195)
        Me.CommissionTextBox.Name = "CommissionTextBox"
        Me.CommissionTextBox.ReadOnly = True
        Me.CommissionTextBox.Size = New System.Drawing.Size(118, 20)
        Me.CommissionTextBox.TabIndex = 5
        Me.CommissionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CommissionCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 251)
        Me.Controls.Add(Me.CommissionTextBox)
        Me.Controls.Add(Me.AmountPaidTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AmountLabel)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CommissionCalculator"
        Me.Text = "Commission Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents WeeklySalesLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents SalesTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AmountLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AmountPaidTextBox As TextBox
    Friend WithEvents CommissionTextBox As TextBox
End Class
