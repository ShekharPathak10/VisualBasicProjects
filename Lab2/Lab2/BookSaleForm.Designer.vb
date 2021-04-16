<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiscountedPriceTextBox
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ExtendedPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DiscountedPriceTxtBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.QuantitySumTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DiscountedAmountSumTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AverageDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Sales"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TitleTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 149)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Quantity"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(109, 20)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(166, 22)
        Me.QuantityTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Title"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(109, 62)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(347, 22)
        Me.TitleTextBox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "&Price"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(109, 105)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(166, 22)
        Me.PriceTextBox.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DiscountedPriceTxtBox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DiscountTextBox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ExtendedPriceTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(561, 128)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(242, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Extended Price"
        '
        'ExtendedPriceTextBox
        '
        Me.ExtendedPriceTextBox.Location = New System.Drawing.Point(376, 18)
        Me.ExtendedPriceTextBox.Name = "ExtendedPriceTextBox"
        Me.ExtendedPriceTextBox.ReadOnly = True
        Me.ExtendedPriceTextBox.Size = New System.Drawing.Size(179, 22)
        Me.ExtendedPriceTextBox.TabIndex = 4
        Me.ExtendedPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(242, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "15% Discount"
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Location = New System.Drawing.Point(376, 54)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.ReadOnly = True
        Me.DiscountTextBox.Size = New System.Drawing.Size(179, 22)
        Me.DiscountTextBox.TabIndex = 6
        Me.DiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(242, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Discounted Price"
        '
        'DiscountedPriceTxtBox
        '
        Me.DiscountedPriceTxtBox.Location = New System.Drawing.Point(376, 88)
        Me.DiscountedPriceTxtBox.Name = "DiscountedPriceTxtBox"
        Me.DiscountedPriceTxtBox.ReadOnly = True
        Me.DiscountedPriceTxtBox.Size = New System.Drawing.Size(179, 22)
        Me.DiscountedPriceTxtBox.TabIndex = 8
        Me.DiscountedPriceTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.Controls.Add(Me.AverageDiscountTextBox)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.DiscountedAmountSumTextBox)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.QuantitySumTextBox)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 337)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(561, 190)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Summary"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 21)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Total Number of Books"
        '
        'QuantitySumTextBox
        '
        Me.QuantitySumTextBox.Location = New System.Drawing.Point(376, 35)
        Me.QuantitySumTextBox.Name = "QuantitySumTextBox"
        Me.QuantitySumTextBox.ReadOnly = True
        Me.QuantitySumTextBox.Size = New System.Drawing.Size(179, 22)
        Me.QuantitySumTextBox.TabIndex = 5
        Me.QuantitySumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Total Discounts Given"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(376, 71)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(179, 22)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(174, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Total Discounted Amounts"
        '
        'DiscountedAmountSumTextBox
        '
        Me.DiscountedAmountSumTextBox.Location = New System.Drawing.Point(376, 107)
        Me.DiscountedAmountSumTextBox.Name = "DiscountedAmountSumTextBox"
        Me.DiscountedAmountSumTextBox.ReadOnly = True
        Me.DiscountedAmountSumTextBox.Size = New System.Drawing.Size(179, 22)
        Me.DiscountedAmountSumTextBox.TabIndex = 9
        Me.DiscountedAmountSumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 140)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "AverageDiscount"
        '
        'AverageDiscountTextBox
        '
        Me.AverageDiscountTextBox.Location = New System.Drawing.Point(376, 140)
        Me.AverageDiscountTextBox.Name = "AverageDiscountTextBox"
        Me.AverageDiscountTextBox.ReadOnly = True
        Me.AverageDiscountTextBox.Size = New System.Drawing.Size(179, 22)
        Me.AverageDiscountTextBox.TabIndex = 10
        Me.AverageDiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(12, 558)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(153, 59)
        Me.CalculateButton.TabIndex = 11
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(220, 558)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(153, 59)
        Me.ClearButton.TabIndex = 12
        Me.ClearButton.Text = "Clear &Sale"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(427, 558)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(153, 59)
        Me.ExitButton.TabIndex = 13
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DiscountedPriceTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 725)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DiscountedPriceTextBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "R 'n R - For Reading and Refreshment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DiscountedPriceTxtBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ExtendedPriceTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DiscountedAmountSumTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents QuantitySumTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents AverageDiscountTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
End Class
