Public Interface ISale

    Sub InsertInvoice(ByVal Entity As Sale)
    Sub UpdateInvoice(ByVal Entity As Sale)

    Function SelectInvoice() As List(Of Sale)
    Function SelectInvoiceBySalesOrg(SalesOrg As String) As Sale


End Interface
