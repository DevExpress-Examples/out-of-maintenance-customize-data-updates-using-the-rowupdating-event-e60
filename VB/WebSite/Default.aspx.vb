Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web

Partial Public Class Grid_Editing_CustomUpdate_CustomUpdate
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		'Populate grid with data on the first load
		If (Not IsPostBack) AndAlso (Not IsCallback) Then
			Dim provider As InvoiceItemsProvider = New InvoiceItemsProvider()
			provider.Populate()
		End If
	End Sub
	Protected Sub grid_RowUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs)
		Dim provider As InvoiceItemsProvider = New InvoiceItemsProvider()
		Dim item As InvoiceItem = provider.GetItemById(CInt(Fix(e.Keys(0))))
		If Not item Is Nothing Then
			item.Name = Convert.ToString(e.NewValues("Name"))
			item.Price = Convert.ToDecimal(e.NewValues("Price"))
			item.Quantity = Convert.ToInt32(e.NewValues("Quantity"))
		End If
		'Cancel automatic update
		e.Cancel = True
		'back to the browse mode
		CType(sender, ASPxGridView).CancelEdit()
	End Sub
End Class
