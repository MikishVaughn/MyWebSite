@code
    ' Determine which site to disply info about
    Dim siteAbout As String = "About/_About_mikish"
    Select Case SiteHelpers.GetSiteInfo("SiteName")
        Case "Lake Catatoga"
            siteAbout = "About/_About_lakecatatoga"

        Case "Illustrate Net"
            siteAbout = "About/_About_illustrate"

        Case "The Mikish Group"
            siteAbout = "About/_About_mikish"

        Case "Scent Me"
            siteAbout = "About/_About_scentme"
    End Select
End Code

<!-- Site About -->
@Html.Partial(siteAbout)