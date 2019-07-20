@code
    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim siteGoogleMapURL As String = SiteHelpers.GetSiteInfo("SiteGoogleMapURL")
    Dim siteFacebookPageURL As String = SiteHelpers.GetSiteInfo("SiteFacebookPageURL")
    Dim siteEmail_Support As String = SiteHelpers.GetSiteInfo("SiteEmail_Support")

    Dim fb_Logo As String = "../Content/Images/Site/Logos/FB_Logo/32x32_FB_Logo.png"
    Dim google_Logo As String = "../Content/Images/Site/Logos/Google_Logo/32x32_Goggle_Logo.png"

End Code

<div style="text-align: center; padding-bottom: 20px;">

    <!-- Contacting Site Name -->
    <h3 style="padding-top: 30px; padding-bottom: 0; color: black;
        text-shadow:.5px .5px 0px #808080, 2px 2px 8px #808080; font-size: 30px;">
        Contacting @siteName
    </h3>

    <!-- Please Contact us Text -->
    <div>
        <p style="color: burlywood;"><small>If there are any questions regarding this Website, please contact us using the information below.</small></p>
    </div>

    <!-- Contact Info box -->
    <div>

        <!-- Facebook Page Button -->
        <div>
            <button style="width: 200px; border-radius:8px; padding-left: 20px;text-align: left;" onclick="newTab('@siteFacebookPageURL')">
                <img style="height:32px; width:32px;" src="~/Content/XML/Svg/Site/FB_Square.SVG" /> <b>Facebook Page</b>
            </button>
        </div>
        <br />

        <!-- Google Page Button -->
        <div>
            <button style="width: 200px; border-radius:8px; padding-left: 20px;text-align: left;" onclick="newTab('@siteGoogleMapURL')">
                <img style="height:32px; width:32px;" src="~/Content/XML/Svg/Site/Google_Square.svg" /> &nbsp;&nbsp;&nbsp;&nbsp;<b>Google</b>
            </button>
        </div>

        <!-- Email Support Address Box -->
        <div style="text-align:center;
                    border-radius: 5px;
                    padding: 1px 0 5px 0;
                    margin: 0;
                    width: auto;">
            <div>
                <div style="letter-spacing: 1.08px;
                                -webkit-font-smoothing: antialiased;
                                font-family: 'Knockout 31 4r', HelveticaNeue-CondensedBold, Helvetica, Arial, sans-serif;
                                color:Burlywood;
                                /*font-weight: bold;*/
                                padding-top: 20px;">Website help:</div>
                <br />
                <a style="color: Burlywood; word-wrap: break-word;" href="mailto: @siteEmail_Support">@siteEmail_Support</a>
            </div>
        </div>
    </div>
</div>