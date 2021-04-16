'Program:		Homework #4
'Programmer:	Shekhar Pathak
'Date:			03/23/2021
'Description:   This class is created inorder to handle the sales data and to add the totals of each fields.

Public Class SalesHandler
    ' Declare new objects
    Private NameString As String
    Private WeeklySalesDecimal As Decimal
    Private CommissionDecimal As Decimal
    Private PayDecimal As Decimal

    ' Declaring Constant Variables
    ' Declaring commission rate as constant since it is fixed 10% for all
    Private Const COMMISSION_RATE_DECIMAL As Decimal = 0.1D
    Private Const BASE_PAY_DECIMAL As Decimal = 500D
    Private Const COMMISSION_QUOTA_DECIMAL As Decimal = 400D

    ' Shared Members 
    Private Shared TotalSalesDecimal As Decimal
    Private Shared TotalCommissionDecimal As Decimal
    Private Shared TotalPayDecimal As Decimal

    ' Defining a property for Saleperson's Name inside class
    Property Name As String
        Get
            ' Accessor
            Return NameString
        End Get
        Set(value As String)
            ' Mutator to set/change the variable
            ' Check if the Name is blank and throw exception if so
            NameString = value
        End Set
    End Property

    ' Defining a property for Weekly Sales inside class
    Property WeeklySales As Decimal
        Get
            Return WeeklySalesDecimal
        End Get
        Set(value As Decimal)
            ' Check if the value is positive integer
            If value > 0 Then
                WeeklySalesDecimal = value
            Else
                Throw New ArgumentOutOfRangeException("Weekly Sales must be greater than zero.")
            End If
        End Set
    End Property

    ReadOnly Property Commission As Decimal
        Get
            Return CommissionDecimal
        End Get
    End Property

    ReadOnly Property Pay As Decimal
        Get
            Return PayDecimal
        End Get
    End Property

    Shared ReadOnly Property TotalSales As Decimal
        Get
            Return TotalSalesDecimal
        End Get
    End Property

    Shared ReadOnly Property TotalCommission As Decimal
        Get
            Return TotalCommissionDecimal
        End Get
    End Property

    Shared ReadOnly Property TotalPay As Decimal
        Get
            Return TotalPayDecimal
        End Get
    End Property

    Private Function CalculateCommission(inSales As Decimal)
        ' Create new commission variable to 
        ' Check to see if the Sales amount is greater than or equal to 400
        ' If yes use the commission formula to calculate commission else set the commission to 0 since quota wasnt reached
        If (inSales >= COMMISSION_QUOTA_DECIMAL) Then
            ' Using formula, Commission = Sales * Commission Rate (10%) 
            Return (inSales * COMMISSION_RATE_DECIMAL)
        Else
            ' Commission quota wasnt reached, so commission = 0
            Return 0
        End If
    End Function

    Private Sub FindPay()
        ' Call CalculateCommission function set it to Commission
        CommissionDecimal = CalculateCommission(WeeklySales)

        ' Calculate the pay
        PayDecimal = BASE_PAY_DECIMAL + CommissionDecimal

        ' Add Totals
        TotalSalesDecimal += WeeklySales
        TotalPayDecimal += Pay
        TotalCommissionDecimal += Commission
    End Sub

    Public Sub New()
        ' Initialization
    End Sub

    Public Sub New(inName As String, inWeeklySales As Decimal)
        ' Set our properties 
        ' Dont change the instance variables directly 
        Name = inName
        WeeklySales = inWeeklySales

        ' Call the FindPay function to find the pay
        FindPay()
    End Sub
End Class
