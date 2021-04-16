Public Class SummaryForm
    Private Sub SummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the summary forms display label to the calculated totals in The Sales Handler class
        TotalSalesLabel.Text = SalesHandler.TotalSales.ToString("c")
        TotalCommissionsLabel.Text = SalesHandler.TotalCommission.ToString("c")
        TotalPayLabel.Text = SalesHandler.TotalPay.ToString("c")
    End Sub

    Private Sub SummaryForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' This happens when the summary form is reclicked or refocused (Activated)
        TotalSalesLabel.Text = SalesHandler.TotalSales.ToString("c")
        TotalCommissionsLabel.Text = SalesHandler.TotalCommission.ToString("c")
        TotalPayLabel.Text = SalesHandler.TotalPay.ToString("c")
    End Sub
End Class