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

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub SaveData(ByVal source As Object, ByVal e As DevExpress.Web.ASPxCallback.CallbackEventArgs)
		Try
			Throw New NotImplementedException()
		Catch e1 As NotImplementedException
			e.Result = "Error|An error was thrown while saving data. Please contact site administrator."
		End Try
	End Sub
End Class
