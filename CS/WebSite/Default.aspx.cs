using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web;

public partial class Grid_Editing_CustomUpdate_CustomUpdate : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        //Populate grid with data on the first load
        if(!IsPostBack && !IsCallback) {
            InvoiceItemsProvider provider = new InvoiceItemsProvider();
            provider.Populate();
        }
    }
    protected void grid_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e) {
        InvoiceItemsProvider provider = new InvoiceItemsProvider();
        InvoiceItem item = provider.GetItemById((int)e.Keys[0]);
        if(item != null) {
            item.Name = Convert.ToString(e.NewValues["Name"]);
            item.Price = Convert.ToDecimal(e.NewValues["Price"]);
            item.Quantity = Convert.ToInt32(e.NewValues["Quantity"]);
        }
        //Cancel automatic update
        e.Cancel = true;
        //back to the browse mode
        ((ASPxGridView)sender).CancelEdit();
    }
}
