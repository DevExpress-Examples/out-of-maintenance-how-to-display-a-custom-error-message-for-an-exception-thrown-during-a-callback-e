using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
    protected void SaveData(object source, DevExpress.Web.CallbackEventArgs e) {
        try {
            throw new NotImplementedException();
        } catch(NotImplementedException) {
            e.Result = "Error|An error was thrown while saving data. Please contact site administrator.";
        }
    }
}