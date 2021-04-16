'Program:		Homework #4
'Programmer:	Shekhar Pathak
'Date:			03/23/2021
'Description:   This is the main area of the program. The program takes in the Name and Weekly Sales amount
'               and calculates the commission they get. It also keeps track of all the Sales, Pays and Commissions 
'               which can be viewed/displayed in the File menu under Summary Tab.

Public Class CommissionCalculator
    ' Declare the new class object
    Private Shared TheSalesHandler As SalesHandler

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Show about 
        AboutBox1.ShowDialog()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clear the stuffs in the textboxes when clicked
        SalesTextBox.Clear()
        AmountPaidTextBox.Clear()
        CommissionTextBox.Clear()
        ' Clear and set the cursor to NameTextBox
        With NameTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Exit the program
        Me.Close()
    End Sub

    Private Sub PayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayToolStripMenuItem.Click
        Try
            If (String.IsNullOrEmpty(NameTextBox.Text)) Then
                ' The NameString passed is empty so throw an exception
                MessageBox.Show("You must enter a name.",
                    "Input Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            ' Instantiate the object and set the properties
            TheSalesHandler = New SalesHandler(NameTextBox.Text, Convert.ToDecimal(SalesTextBox.Text))

            ' Output the result
            AmountPaidTextBox.Text = TheSalesHandler.Pay.ToString("c")
            CommissionTextBox.Text = TheSalesHandler.Commission.ToString("c")

        Catch ex As FormatException
            ' If the parse fails give the error
            MessageBox.Show("Please enter a numeric sales amount.",
                    "Input Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Display the summary form modelessly
        SummaryForm.Show()
    End Sub

End Class
