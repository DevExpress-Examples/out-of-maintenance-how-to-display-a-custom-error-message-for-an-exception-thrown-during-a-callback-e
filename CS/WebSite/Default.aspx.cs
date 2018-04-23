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

public partial class _Default : System.Web.UI.Page
{
	protected void SaveData(object source, DevExpress.Web.ASPxCallback.CallbackEventArgs e) {
		try {
			throw new NotImplementedException();
		}
		catch (NotImplementedException) {
			e.Result = "Error|An error was thrown while saving data. Please contact site administrator.";
		}
	}
}
