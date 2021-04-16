'Project: Homework #2
'Author: Shekhar Pathak      
'Date: Spring 2021
'Description: This program prompts the user to input the temperatures for 14 days (2 weeks) and gives the diagnosis for last temperature 
'and 14 day temperature as well as the temperature for each day

Public Class COVID19TemperatureRecorder
    ' Class Level variables

    ' Declaring a constant for Max number of readings
    Const MAX_NUMBER_OF_READINGS As Integer = 14

    ' Creating a function to determine the diagnosis using Select Case which returns the diagnosis as a string
    Function DetermineDiagnosis(InputTemperatureDecimal As Decimal) As String
        Dim CaseString As String = ""

        ' Checking to see where the passed temperature falls using select case
        Select Case InputTemperatureDecimal
            Case < 95
                CaseString = "Hypothermia"
            Case <= 99
                CaseString = "Normal"
            Case <= 103
                CaseString = "Fever"
            Case > 103
                CaseString = "Seek Attention"
        End Select

        ' Return the Diagnosis store in string CaseString
        Return CaseString

    End Function

    Private Sub RecordReadingButton_Click(sender As Object, e As EventArgs) Handles RecordReadingButton.Click

        Dim InputTemperatureDecimal As Decimal = 0
        Dim TemperatureDecimal As Decimal = 0 ' To add the total temperature in the list box 
        Dim AverageTemperatureDecimal As Decimal = 0 ' To take the average of the total temperature in the listbox

        ' This button records the input temperature
        ' Look at the input and make sure it is numeric and is between 0 and 115
        Try
            InputTemperatureDecimal = Decimal.Parse(CurrentTemperatureTextBox.Text)

            If (InputTemperatureDecimal >= 0 And InputTemperatureDecimal <= 115) Then

                ' All the validations are satisfied perform further actions
                ' Take the input and add it to the ReadingsListBox 
                ReadingsListBox.Items.Add(InputTemperatureDecimal.ToString("n2").PadLeft(9, " "))
                CurrentTemperatureTextBox.Clear() ' Clear the Current Temperature Text Box for new input

                ' Output the results For Last Readings 
                LastReadingTemperatureTextBox.Text = InputTemperatureDecimal.ToString("n2")
                LastReadingDiagnosisTextBox.Text = DetermineDiagnosis(InputTemperatureDecimal)

                ' Using a for next loop to iterate through the ListBox and get the average of the inputs
                'Dim CounterInteger As Integer = 0
                For CounterInteger As Integer = 0 To (ReadingsListBox.Items.Count - 1)
                    TemperatureDecimal += ReadingsListBox.Items(CounterInteger)
                    AverageTemperatureDecimal = TemperatureDecimal / (CounterInteger + 1)
                Next

                ' Output the results For 14 Day Average
                AverageTemperatureTextBox.Text = AverageTemperatureDecimal.ToString("n2")
                AverageDiagnosisTextBox.Text = DetermineDiagnosis(AverageTemperatureDecimal)

            Else
                ' The input is not in between 0 and 115
                ' Promt the range error 
                MessageBox.Show("You must enter a temperature between 0 and 115.",
                    "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' Reset the cursor and select the input in the CurrentTemperatureTextBox
                With CurrentTemperatureTextBox
                    .Focus()
                    .SelectAll()
                End With
            End If

        Catch TemperatureException As FormatException
            ' Show the format error message box
            MessageBox.Show("You must enter a numeric temperature reading.",
                    "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Reset the cursor and select the input in the CurrentTemperatureTextBox
            With CurrentTemperatureTextBox
                .Focus()
                .SelectAll()
            End With
        End Try

        ' Reset or Focus the cursor to the temperaturing reading text box for ease
        CurrentTemperatureTextBox.Focus()

        If ReadingsListBox.Items.Count = MAX_NUMBER_OF_READINGS Then
            ' We have 14 temperature readings, Disable more inputs
            CurrentTemperatureTextBox.Enabled = False ' Disabling the temperaturing reading text box
            RecordReadingButton.Enabled = False ' Disabling the recor/submit button
        End If
    End Sub

    Private Sub ClearReadingButton_Click(sender As Object, e As EventArgs) Handles ClearReadingButton.Click
        ' Clear the form 
        CurrentTemperatureTextBox.Clear()
        LastReadingTemperatureTextBox.Clear()
        LastReadingDiagnosisTextBox.Clear()
        AverageTemperatureTextBox.Clear()
        AverageDiagnosisTextBox.Clear()
        ReadingsListBox.Items.Clear()

        ' Reset the button state
        RecordReadingButton.Enabled = True

        ' Reset the Text Box state
        CurrentTemperatureTextBox.Enabled = True

        ' Put the cursor on the Current Reading Temperature TextBox to prompt user to input the temperature
        CurrentTemperatureTextBox.Focus()

    End Sub

    Private Sub COVID19TemperatureRecorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setting the Last reading's and 14 Day average's group TextBoxes to Disabled 
        ' to disable the inputs  

        LastReadingTemperatureTextBox.Enabled = False
        LastReadingDiagnosisTextBox.Enabled = False
        AverageDiagnosisTextBox.Enabled = False
        AverageTemperatureTextBox.Enabled = False

    End Sub

End Class
