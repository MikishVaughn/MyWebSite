@code
    Dim choice01 As String = ""
    Dim choice02 As String = ""
    Dim choice03 As String = ""
    Dim choice04 As String = ""
    'Dim activebackgroundcolor As String = "black"

    If ViewData("message") = "Photos" Then
        choice01 = "active"
    End If
    If ViewData("message") = "Humor" Then
        choice02 = "active"
    End If
    If ViewData("message") = "Events" Then
        choice03 = "active"
    End If
    If ViewData("message") = "Links" Then
        choice04 = "active"
    End If
End Code

<div id="site-menu" class="site-menu" role="contentinfo" aria-label="Site menu" style="padding-top: 5px; padding-bottom: 5px; background-color:antiquewhite;">
    <div class="site-menu__module-group main-menu__module-group" data-metrics-category="Page Menu" data-metrics-label="Menu">
        <div class="main-menu__item">
            <h6 title="• Photos contains a small, but growing selection of interesting photos taken by our friends, or found on the Internet." class="site-menu__header @choice01">
                <span>
                    <a class="nav-link" href="~/images/Photos">Photos <img style="width:42px; height:36px;" src="~/Content/XML/Svg/Site/Photos.svg" /></a>
                </span>
            </h6>
        </div>
        <div class="main-menu__item">
            <h6 title="• Humor contains a large selection of often humorous jokes, memes, and cartoons from various Mikish Group Members" class="site-menu__header @choice02">
                <span>
                    <a class="nav-link" href="~/images/Humor">Humor <img style="width:42px; height:36px;" src="~/Content/XML/Svg/Site/Humor.svg" /></a>
                </span>
            </h6>
        </div>
        <div class="main-menu__item">
            <h6 title="• Event Countdowns originally started with Spring and other Season countdowns while awaiting the end of a long winter; now several other Events are on the menu." class="site-menu__header @choice03">
                <a class="nav-link" href="~/Countdowns/EventsMenu">Events <img style="width:42px; height:36px;" src="~/Content/XML/Svg/Site/Countdowns.svg" /></a>
            </h6>
        </div>
        <div class="main-menu__item">
            <h6 title="• Several useful links (to us anyways)!" class="site-menu__header @choice04">
                <a class="nav-link" href="~/Info/Links">Links <img style="margin-left:20px; width:42px; height:36px;" src="~/Content/XML/Svg/Site/Links.svg" /></a>
            </h6>
        </div>
    </div>
</div>