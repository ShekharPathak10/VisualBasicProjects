' Project: Homework 1
' Author:  Shekhar Pathak
' Description: This project calculates the rental charges for the rental car agency.
' We take the charge rate below to calculate the net amount
' Charge per day for a vehicle = $50
' Charge of the vechile used per mile = $0.23

Public Class RentalChargesCalculator
    ' Declaring the class level constant variable since the rates are constant
    ' Charge Per Day
    Const CHARGE_PER_DAY As Decimal = 50

    ' Mileage Rate
    Const MILEAGE_RATE As Decimal = 0.23

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Exit the program when clicked
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Clear all the informaton when clicked
        BeginningOdometerTextBox.Clear()
        EndingOdometerTextBox.Clear()
        DaysTextBox.Clear()
        MilesDrivenTextBox.Clear()
        TotalChargeTextBox.Clear()

        ' Put the focus on the beginning of the information prompt
        BeginningOdometerTextBox.Focus()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' Creating varibles to assing the Rental Informations
        Dim BeginningOdometerDecimal, EndingOdometerDecimal As Decimal
        Dim DaysInteger As Integer
        ' Creating variables necessay for the Totals Calculations
        ' Declaring Total Charge decimal since a price can be in decimal
        Dim TotalChargesDecimal As Decimal
        Dim MilesDrivenDecimal As Decimal

        Try
            ' Convert the input in BeginningOdometerTextBox to a integer and assign it to BeginningOdometerInteger
            BeginningOdometerDecimal = Decimal.Parse(BeginningOdometerTextBox.Text)

            Try
                ' Convert the input in EndingOdometerTextBox to a integer and assign it to BeginningOdometerInteger
                EndingOdometerDecimal = Decimal.Parse(EndingOdometerTextBox.Text)

                Try
                    ' Convert the input in DaysTextBox to a integer and assign it to DaysInteger
                    DaysInteger = Integer.Parse(DaysTextBox.Text)

                    ' Calculations for the Totals i.e Miles Driven And Total Charges
                    MilesDrivenDecimal = EndingOdometerDecimal - BeginningOdometerDecimal
                    TotalChargesDecimal = (MilesDrivenDecimal * MILEAGE_RATE) + (DaysInteger * CHARGE_PER_DAY)

                    ' Output the calculated Totals Result
                    MilesDrivenTextBox.Text = MilesDrivenDecimal.ToString("n1")
                    TotalChargeTextBox.Text = TotalChargesDecimal.ToString("c")

                Catch DaysFormatException As FormatException
                    ' If the Try block fails it comes to catch and we can display appropriate error message
                    MessageBox.Show("Number of Days must be numeric. ", "Data Entry Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ' Reset the cursor
                    With DaysTextBox
                        .Focus()
                        .SelectAll()
                    End With
                End Try

            Catch EndingOdoFormatException As FormatException
                ' If the Try block fails it comes to catch and we can display appropriate error message
                MessageBox.Show("The ending odometer must be numeric. ", "Data Entry Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' Reset the cursor
                With EndingOdometerTextBox
                    .Focus()
                    .SelectAll()
                End With
            End Try

        Catch BeginningOdoFormatException As FormatException
            ' If the Try block fails it comes to catch and we can display appropriate error message
            MessageBox.Show("The beginning odometer must be numeric. ", "Data Entry Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Reset the cursor
            With BeginningOdometerTextBox
                .Focus()
                .SelectAll()
            End With

        End Try

    End Sub
End Class
