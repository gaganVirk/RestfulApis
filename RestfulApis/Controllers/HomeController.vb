Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Title") = "Home Page"

        Return View()
    End Function

    Function Contact() As String
        Return "Hello Contact"
    End Function
End Class
