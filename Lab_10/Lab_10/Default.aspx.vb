'Class Name: Default
'Programmer: Shekhar Pathak
'Date: 04/16/2021
'Description: Handle book sale information.
'Project: Lab 10

Partial Class _Default
    Inherits System.Web.UI.Page
    'Class level variable
    Dim _DiscountDecimal As Decimal

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' We do initialization tasks
        ' Change the validation mode
        Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None

        _DiscountDecimal = GetDiscount()

        ' check if this is the first visit
        If Not Page.IsPostBack = True Then
            ' this is our first visit do initialization
            ' Display the discount
            DisplayDiscount()
        End If

    End Sub


    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ' Write the code to handle the click 
        Dim TheBookSale As BookSale

        'force the validation at the server
        Page.Validate()

        ' Check if the valiidaters were successful
        If Page.IsValid = True Then
            Try
                TheBookSale = New BookSale(TitleTextBox.Text,
                                           Integer.Parse(QuantityTextBox.Text),
                                           Decimal.Parse(PriceTextBox.Text))

                ' Display the output
                ExtendedPriceTextBox.Text = TheBookSale.ExtendedPrice.ToString("c")
                DiscountTextBox.Text = TheBookSale.Discount.ToString("C")
                DiscountedPriceTextBox.Text = TheBookSale.DiscountedPrice.ToString("c")

                ' Increment the DicountDecimal
                _DiscountDecimal += TheBookSale.Discount

                'Output the result
                DisplayDiscount()

                'update the hidden field  
                UpdateDiscount()

            Catch ex As Exception
                ' The parses failed
                ' Display the error message
                ErrorLabel.Text = "You must enter numeric values."
            End Try
        Else
            ' Did not fill all the forms
            ErrorLabel.Text = "Must fill out all required fields"
        End If
    End Sub

    Protected Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Clear the form 
        QuantityTextBox.Text = ""
        TitleTextBox.Text = ""
        PriceTextBox.Text = ""
        DiscountTextBox.Text = ""
        ExtendedPriceTextBox.Text = ""
        DiscountedPriceTextBox.Text = ""
    End Sub

    Sub DisplayDiscount()
        DiscountTotalTextBox.Text = _DiscountDecimal.ToString("c")
    End Sub

    Function GetDiscount() As Decimal
        Dim DiscountDecimal As Decimal

        If Request.Cookies("Discount") IsNot Nothing Then
            Try
                DiscountDecimal = Decimal.Parse(Request.Cookies("Discount").Value)
            Catch ex As Exception
                DiscountDecimal = 0
            End Try
        End If

        Return DiscountDecimal
    End Function

    Sub UpdateDiscount()
        'update the hiddenField with the new total
        'DiscountTotalHiddenField.Value = _DiscountDecimal.ToString

        'updating cookie now
        Response.Cookies("Discount").Value = _DiscountDecimal.ToString
    End Sub

    Protected Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        DiscountTotalTextBox.Text = _DiscountDecimal.ToString("c")
    End Sub
End Class
