'Project: Homework 3 
'Author: Shekhar Pathak 
'Date: Spring 2021 
'Description: This program lets the user select a type of theatre from the selection and the number of tickets for that show
'              and it calculates total cost and gives the summary of all tickets bought along with price and quantitu

Imports System.Diagnostics
Public Class TicketSalesForm
    ' Class level variable
    ' Creating an array PriceDecimal to store the price of each section
    Dim PriceDecimal() As Decimal = {75D, 60D, 25D, 12.5D}
    ' Creating an array TotalTicketsSoldInteger to store the total number of tickets bought for each section
    Dim TotalTicketsSoldInteger() As Integer = {0, 0, 0, 0}

    ' This sub loads when the form first loads
    Private Sub TicketSalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Displaying the types of theatre as soon as the program loads
        ' Creating an array section to store all the types of selection of theatre
        Dim section() As String = {"Orchestra", "Mezzanine", "General", "Balcony"}
        'MessageBox.Show(PriceDecimal(0).ToString("c"))

        ' Adding the items to the SectionListBox to be selection form the list box
        For x As Integer = 0 To section.Length - 1
            SectionListBox.Items.Add(section(x))
        Next
    End Sub

    Sub DisplaySummary()
        Dim Summary As String
        'Dim CounterInteger As Integer

        Summary = "Section".PadRight(15, " ") & "# of Tickets".PadLeft(15, " ") & "Total".PadLeft(18, " ") & ControlChars.NewLine

        For CounterInteger As Integer = 0 To SectionListBox.Items.Count - 1
            Dim TotalInteger As Decimal = Convert.ToDecimal(TotalTicketsSoldInteger(CounterInteger)) * PriceDecimal(CounterInteger)
            Dim AddSummary As String = SectionListBox.Items(CounterInteger).ToString().PadRight(15, " ") & TotalTicketsSoldInteger(CounterInteger).ToString().PadLeft(10, " ") & TotalInteger.ToString("c").PadLeft(23, " ") & ControlChars.NewLine
            Summary += AddSummary
        Next

        SummaryTextBox.Text = Summary
    End Sub
    Private Sub PurchaseButton_Click(sender As Object, e As EventArgs) Handles PurchaseButton.Click
        ' Creating an integer to store the input number of tickets user is about to buy
        Dim TicketsSoldInteger As Integer

        ' Had to ReDim to be able to add the no of tickets sold in TotalTicketsSoldInteger array
        'ReDim Preserve TotalTicketsSoldInteger(PriceDecimal.Length)

        If (SectionListBox.SelectedIndex < 0) Then
            MessageBox.Show("You must choose a section",
                    "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                ' Validate the Number of tickets to see if its integer
                TicketsSoldInteger = Integer.Parse(NumberTextBox.Text)
                Dim SectionPriceDecimal As Decimal
                Dim AmountDecimal As Decimal

                ' SectionListBox.SelectedIndex gives us the index starting from 0-3, 0 being the top item selected 
                ' and 4 being the bottom one 
                SectionPriceDecimal = PriceDecimal(SectionListBox.SelectedIndex)

                ' To get the amount that is due multiply the number of tickets bought with the price of the ticket bought
                AmountDecimal = SectionPriceDecimal * Convert.ToDecimal(TicketsSoldInteger)

                ' Add the number of tickets bought using SectionListBox.SelectedIndex as index to the 
                ' TotalTicketsSoldInteger array
                TotalTicketsSoldInteger(SectionListBox.SelectedIndex) += TicketsSoldInteger

                ' Display the values
                AmountTextBox.Text = AmountDecimal.ToString("c")
                PriceSummaryLabel.Text = "Purchased " + TicketsSoldInteger.ToString() + " ticket(s) at " + AmountDecimal.ToString("c") + " per ticket"
                ' Call the function to display the summary on the summary text box
                DisplaySummary()

                ' Clear the NumberTextBox for new entry
                With NumberTextBox
                    .Focus()
                    .SelectAll()
                    .Clear()
                End With
                ' Set the selected index to -1 to unselect the section options
                SectionListBox.SelectedIndex = -1

            Catch ex As Exception
                MessageBox.Show("You must enter a numeric quantity for tickets",
                    "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With NumberTextBox
                    .Focus()
                    .SelectAll()
                End With
            End Try
        End If

    End Sub
End Class
