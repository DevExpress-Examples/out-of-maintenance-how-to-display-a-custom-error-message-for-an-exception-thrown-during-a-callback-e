Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub SaveData(ByVal source As Object, ByVal e As DevExpress.Web.CallbackEventArgs)
        Try
            Throw New NotImplementedException()
        Catch e1 As NotImplementedException
            e.Result = "Error|An error was thrown while saving data. Please contact site administrator."
        End Try
    End Sub
End Class