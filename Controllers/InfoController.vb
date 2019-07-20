Namespace Controllers

    Public Class InfoController
        Inherits Controller

        <HttpGet>
        Function About() As ActionResult
            ViewData("Message") = "About"
            ViewData("PageHeader") = CType(ViewData("Message"), String) + " " + SiteHelpers.GetSiteInfo("SiteName")
            ViewData("PageTitle") = ViewData("PageHeader")
            Return View()
        End Function

        <HttpGet>
        Function Contact() As ActionResult
            ViewData("Message") = "Contact"
            ViewData("PageHeader") = CType(ViewData("Message"), String) + " " + SiteHelpers.GetSiteInfo("SiteName")
            ViewData("PageTitle") = ViewData("PageHeader")
            Return View()
        End Function

        <HttpGet>
        Function PrivacyPolicy() As ActionResult
            ViewData("Message") = "Privacy Policy"
            ViewData("PageHeader") = ViewData("Message")
            ViewData("PageTitle") = ViewData("PageHeader")
            Return View()
        End Function

        <HttpGet>
        Function TermsOfService() As ActionResult
            ViewData("Message") = "Terms of Service"
            ViewData("PageHeader") = ViewData("Message")
            ViewData("PageTitle") = ViewData("PageHeader")
            Return View()
        End Function

        <HttpGet>
        Function Elephant() As ActionResult
            ViewData("Message") = "Elephant"
            ViewData("PageHeader") = "The " + CType(ViewData("Message"), String)
            ViewData("PageTitle") = ViewData("PageHeader")
            Return View()
        End Function

        <HttpGet>
        Function Links() As ActionResult
            ViewData("Message") = "Links"
            ViewData("PageHeader") = CType(ViewData("Message"), String) + " " + SiteHelpers.GetSiteInfo("SiteName")
            ViewData("PageTitle") = ViewData("PageHeader")
            Return View()
        End Function

        <HttpGet>
        Function More() As ActionResult
            ViewData("Message") = "More"
            ViewData("PageHeader") = CType(ViewData("Message"), String) + " " + SiteHelpers.GetSiteInfo("SiteName")
            ViewData("PageTitle") = ViewData("PageHeader")
            Return View()
        End Function

    End Class

End Namespace