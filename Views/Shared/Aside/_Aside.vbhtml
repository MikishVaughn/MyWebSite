@code
    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")

    Dim msg As String = ViewData("message")
    Dim showMain As String = "HIDDEN"
    Dim showLike As String = "HIDDEN"
    Dim asideContent As String = "Aside/_Aside_About"
    Dim showContent As String = "HIDDEN"

    ' Snow Files
    If msg = "Snow1" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Images_Snow1"
    End If
    If msg = "Snow2" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Images_Snow2"
    End If
    If msg = "Snow3" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Images_Snow3"
    End If
    If msg = "Snow4" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Images_Snow4"
    End If
    If msg = "Snow5" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Images_Snow5"
    End If

    ' SVG Files
    If msg = "SvgFiles" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Info_SvgFiles"
    End If

    ' Holidays
    If msg = "New Years" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Holidays_NewYears"
    End If
    If msg = "MartinLutherKing" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Holidays_" + msg
    End If
    If msg = "Valentines" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Holidays_" + msg
    End If
    If msg = "Presidents" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Holidays_" + msg
    End If
    If msg = "Easter" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Holidays_" + msg
    End If
    If msg = "Mothers" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Holidays_" + msg
    End If
    If msg = "Memorial" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Holidays_" + msg
    End If
    If msg = "Fathers" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Holidays_" + msg
    End If
    If msg = "Independence" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Holidays_" + msg
    End If
    If msg = "Labor" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Holidays_" + msg
    End If
    If msg = "Veterans" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Holidays_" + msg
    End If
    If msg = "Halloween" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Holidays_" + msg
    End If
    If msg = "Elections" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Holidays_" + msg
    End If
    If msg = "Thanksgiving" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Holidays_" + msg
    End If
    If msg = "Christmas" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Holidays_" + msg
    End If

    ' Humor
    If msg = "Cartoons" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Humor_" + msg
    End If
    If msg = "Political" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Humor_" + msg
    End If
    If msg = "Memes" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Humor_" + msg
    End If
    If msg = "Jokes" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Humor_" + msg
    End If
    If msg = "NSFW" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Humor_" + msg
    End If

    ' Photos
    If msg = "Sunsets" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Photos_Sunsets"
    End If
    If msg = "Wildlife" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Photos_Wildlife"
    End If
    If msg = "Fishing" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Photos_Fishing"
    End If
    If msg = "Scentme" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Photos_ScentMe"
    End If

    ' Birthdays
    If msg = "Army" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Birthday_" + msg
    End If
    If msg = "Navy" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Birthday_" + msg
    End If
    If msg = "AirForce" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Birthday_" + msg
    End If
    If msg = "MarineCorp" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Birthday_" + msg
    End If
    If msg = "NationalGuard" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Birthday_" + msg
    End If
    If msg = "Jefferson" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Birthday_" + msg
    End If
    If msg = "Washington" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Birthday_" + msg
    End If
    If msg = "Lincoln" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Birthday_" + msg
    End If

    ' Seasons
    If msg = "Spring" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Season_" + msg
    End If
    If msg = "Summer" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Season_" + msg
    End If
    If msg = "Autumn" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Season_" + msg
    End If
    If msg = "Winter" Then
        showContent = ""
        showMain = "HIDDEN"
        showLike = ""
        asideContent = "Aside/_Aside_Season_" + msg
    End If

    ' Menus
    If msg = "EventsMenu" Then
        showContent = ""
        showMain = "HIDDEN"
        asideContent = "Aside/_Aside_" + msg
    End If
    If msg = "Photos" Then
        showContent = ""
        showMain = "HIDDEN"
        asideContent = "Aside/_Aside_" + msg
    End If
    If msg = "Humor" Then
        showContent = ""
        showMain = "HIDDEN"
        asideContent = "Aside/_Aside_" + msg
    End If
    If msg = "Links" Then
        showContent = ""
        showMain = "HIDDEN"
        asideContent = "Aside/_Aside_" + msg
    End If
    If msg = "About" Then
        showContent = ""
        showMain = "HIDDEN"
        asideContent = "Aside/_Aside_" + msg
        If LCase(siteName).Contains("catatoga") Then
            asideContent = "Aside/_Aside_About_LakeCatatoga"
        End If
    End If

    If LCase(SiteHelpers.RootUrl).Contains("localhost") Then
        showLike = "HIDDEN"
    End If
End code

<div Class="container-fluid aside" role="contentinfo" aria-label="Site side-content" style="min-width: 260px;  padding: 15px 0 0 0;">
    <div @showContent>
        @Html.Partial(asideContent)
    </div>
</div>