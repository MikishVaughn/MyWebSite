@code
    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim siteDesignerURL As String = SiteHelpers.GetSiteInfo("SiteDesignerURL")
    Dim siteDesigner As String = SiteHelpers.GetSiteInfo("SiteDesigner")

    Dim IsHidden_Mikish As String = ""
    If siteName = "The Mikish Group" Then
        IsHidden_Mikish = "HIDDEN"
    End If

    Dim IsHidden_Illustrate As String = ""
    If siteName = "Illustrate Net" Then
        IsHidden_Illustrate = "HIDDEN"
    End If

    Dim IsHidden_Catatoga As String = ""
    If siteName = "Lake Catatoga" Then
        IsHidden_Catatoga = "HIDDEN"
    End If

    Dim IsHidden_ScentMe As String = ""
    If siteName = "Scent Me" Then
        IsHidden_ScentMe = "HIDDEN"
    End If

End Code

<style>
    footer {
        height: 174px;
    }
</style>

<footer id="site-footer" class="site-footer" role="contentinfo" aria-label="Site footer">
    <div class="site-footer__content" data-metrics-category="Global Footer" data-metrics-label="Footer">
        <div class="site-footer__module-group">
            <div class="site-footer__module">
                <h6 class="site-footer__header">Info</h6>

                <ul>
                    <li class="site-footer__item"><a class="nav-link" href="~/Info/About">About Us</a></li>
                    <li class="site-footer__item"><a class="nav-link" href="~/Info/Contact">Contact Us</a></li>
                </ul>
            </div>

            <div class="site-footer__module">
                <h6 class="site-footer__header">Features</h6>

                <ul>
                    <li class="site-footer__item"><a class="nav-link" href="~/Countdowns/EventsMenu">Events</a></li>
                    <li class="site-footer__item"><a class="nav-link" href="~/images/Photos">Photos</a></li>
                    <li class="site-footer__item"><a class="nav-link" href="~/images/Humor">Humor</a></li>
                </ul>
            </div>

            <div class="site-footer__module">
                <h6 class="site-footer__header">Policies</h6>

                <ul>
                    <li class="site-footer__item"><a class="nav-link" href="~/Info/PrivacyPolicy">Privacy Policy</a></li>
                    <li class="site-footer__item"><a class="nav-link" href="~/Info/TermsOfService">Terms of Service</a></li>
                </ul>
            </div>
           
        </div>
        <div class="site-footer__module site-footer__module--secondary" style="color:#f2f2f2; background-color: chocolate; margin: 0; padding: 0; width: 100%;">
            <h6 style="text-align: center; margin: 0; padding: 5px 10px 12px 5px; color: white; text-shadow: 0px 0px 2px black;">
                <small>This website is privately owned and not associated or affiliated with any group other than the design team at:</small><br />
                <a style="font-weight: 500; font-size: 18px; color: white; text-shadow: 0px 0px 2px black;" href="~/Info/Contact"><small>The Mikish Group &copy; @DateTime.Now.Year All Rights Reserved.</small></a>
            </h6>
        </div>
    </div>
</footer>