Imports System.Web.Mvc

Namespace Areas.HelpPage.Controllers
    Public Class ContactController
        Inherits Controller

        ' GET: HelpPage/Contact
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace