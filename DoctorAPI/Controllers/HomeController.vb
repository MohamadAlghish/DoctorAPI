Public Class HomeController
    Inherits System.Web.Mvc.Controller

    '@Alghish
    'VB
    Function Index() As ActionResult
        ViewData("Title") = "Home Page"

        Return View()
    End Function
End Class
