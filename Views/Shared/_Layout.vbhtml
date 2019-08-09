@code

    Dim hideLogin As String = "HIDDEN"
    Dim siteURL As String = SiteHelpers.GetSiteInfo("SiteURL")
    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim siteDescription As String = SiteHelpers.GetSiteInfo("SiteDescription")

    ' Make page background color appropriate
    Dim backgroundColor As String = "chocolate"

    ' Set Background Image
    Dim backgroundImage As String = SiteHelpers.GetImageLocation() + "Categories/Backgrounds/main-bg.jpg"

    Dim Msg As String = ViewData("Message")

    Dim canonical As String = siteURL
    Dim ogTitle As String = siteName
    Dim ogType As String = "website"
    Dim ogURL As String = siteURL
    Dim ogImage As String = SiteHelpers.GetSiteInfo("LinkShare")
    Dim fbAdmins As String = SiteHelpers.GetSiteInfo("fbAdmins")
    Dim fbAppID As String = SiteHelpers.GetSiteInfo("fbAppID")
    Dim ogSite_Name As String = siteName
    Dim ogDescription As String = siteDescription

    ' Info


    If Msg = "About" Or
        Msg = "Contact" Or
        Msg = "Privacy Policy" Or
        Msg = "Terms of Service" Then

        ogTitle = Msg + " " + siteName
        ogDescription = Msg
        backgroundColor = "black"
        ogImage = SiteHelpers.GetSiteInfo("LinkShare")
        canonical = siteURL + "/Info/" + Msg

    End If

    If Msg = "More" Then

        ogTitle = "More Help Needed"
        ogDescription = siteName
        backgroundColor = "chocolate"
        ogImage = SiteHelpers.GetImageLocation() + "Site/LinkShares/More.jpg"
        canonical = siteURL + "/Info/" + Msg

    End If

    If Msg = "Elephant" Then

        ogTitle = "Blind Men and an Elephant"
        ogDescription = "A poem from American poet John Godfrey Saxe written In 1836. The parable Of the blind men And an elephant originated In the ancient Indian subcontinent, from where it has been widely diffused. This story was first mentioned In the Udana, under Tittha Sutta (Ud. 6.4)."
        backgroundColor = "transparent"
        ogImage = SiteHelpers.GetImageLocation() + "Categories/Background/" + Msg + ".jpg"
        canonical = siteURL + "/Info/" + Msg

    End If

    'Images
    If Msg = "Sunsets" Then

        ogTitle = "Beautiful Sunsets!"
        ogDescription = "Lake Catatoga Sunsets"
        canonical = siteURL + "/Images/" + Msg
        ogImage = SiteHelpers.GetImageLocation() + "Categories/" + Msg + "/" + Right("000000" + SiteHelpers.MaxImages(Msg).ToString, 6) + ".jpg"

    End If

    If Msg = "Fishing" Or
        Msg = "Wildlife" Or
        Msg = "ScentMe" Then

        ogTitle = siteURL + " " + Msg
        ogDescription = Msg + " at " + siteName
        canonical = siteURL + "/Images/" + Msg
        ogImage = SiteHelpers.GetImageLocation() + "Categories/" + Msg + "/" + Right("000000" + SiteHelpers.MaxImages(Msg).ToString, 6) + ".jpg"

    End If

    'Humor
    If Msg = "Cartoons" Or
        Msg = "Political" Or
        Msg = "Memes" Or
        Msg = "Jokes" Or
        Msg = "NSFW" Then

        ogTitle = siteURL + " " + Msg
        ogDescription = Msg + " at " + siteName
        canonical = siteURL + "/Images/" + Msg
        ogImage = SiteHelpers.GetImageLocation() + "Categories/" + Msg + "/" + Right("000000" + SiteHelpers.MaxImages(Msg).ToString, 6) + ".jpg"

    End If

    ' Countdowns
    If Msg = "EventsMenu" Then

        ogTitle = "Event Countdowns"
        ogDescription = "Days until the start of popular Events"
        canonical = siteURL + "/Countdowns/" + Msg
        ogImage = SiteHelpers.GetImageLocation() + "Categories/Countdowns/Events.jpg"

    End If

    ' Seasons
    If Msg = "Spring" Or
        Msg = "Summer" Or
        Msg = "Autumn" Or
        Msg = "Winter" Then

        ogTitle = "Days until " + Msg
        ogDescription = "Days until the start of " + Msg
        backgroundColor = "transparent"
        canonical = siteURL + "/Countdowns/" + Msg
        ogImage = SiteHelpers.GetImageLocation() + "Categories/Countdowns/" + Msg + ".jpg"

    End If

    ' Birthdays
    If Msg = "Aledia" Or
        Msg = "April" Or
        Msg = "Melissa" Or
        Msg = "Bridget" Or
        Msg = "PattyKake" Or
        Msg = "Tina" Or
        Msg = "Mary" Or
        Msg = "Mike" Or
        Msg = "Fred" Or
        Msg = "Steve" Or
        Msg = "Heidi" Or
        Msg = "Stacy" Or
        Msg = "Patricia" Or
        Msg = "Army" Or
        Msg = "Navy" Or
        Msg = "AirForce" Or
        Msg = "MarineCorp" Or
        Msg = "NationalGuard" Or
        Msg = "Jefferson" Or
        Msg = "Lincoln" Or
        Msg = "Washington" Then

        ogTitle = Msg + "'s Birthday"
        ogDescription = "Countdown until the BIG Day!"
        backgroundColor = "black"
        canonical = siteURL + "/Countdowns/" + Msg
        ogImage = SiteHelpers.GetImageLocation() + "Categories/Countdowns/" + Msg + ".jpg"

    End If

    ' Holidays
    If Msg = "Easter" Or
        Msg = "Memorial" Or
        Msg = "Independence" Or
        Msg = "Labor" Or
        Msg = "Veterans" Or
        Msg = "Christmas" Or
        Msg = "Thanksgiving" Or
        Msg = "MartinLutherKing" Or
        Msg = "Halloween" Then

        ogTitle = Msg + " Day"
        ogDescription = "Countdown until " + Msg + " Day!"
        backgroundColor = "black"
        canonical = siteURL + "/Countdowns/" + Msg
        ogImage = SiteHelpers.GetImageLocation() + "Categories/Countdowns/" + Msg + ".jpg"

    End If

    If Msg = "New Years" Or
        Msg = "Valentines" Or
        Msg = "Presidents" Or
        Msg = "Mothers" Or
        Msg = "Fathers" Or
        Msg = "Elections" Then

        ogTitle = Msg + " Day"
        ogDescription = "Countdown until " + Msg + " Day!"
        backgroundColor = "black"
        canonical = siteURL + "/Countdowns/" + Msg
        ogImage = SiteHelpers.GetImageLocation() + "Categories/Countdowns/" + Msg + ".jpg"

    End If

    ogURL = canonical

End Code

<!DOCTYPE html>
<html lang="en" itemscope itemtype="http://schema.org/WebPage">

<!-- Header -->
<head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb#">

    <title>@siteName</title>
    <link rel="icon" href="/favicon.ico" type="image/x-icon" />
    <link rel="icon" href="/favicon.ico?v=2" type="image/x-icon" />
    <link rel="canonical" href="@canonical" />
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="@ogDescription" />
    <meta property="fb:admins" content="@fbAdmins" />
    <meta property="fb:app_id" content="@fbAppID" />
    <meta property="og:type" content="website" />
    <meta property="og:site_name" content="@ogSite_Name" />
    <meta property="og:url" content="@ogURL" />
    <meta property="og:image:url" content="@ogImage" />
    <meta property="og:image:type" content="image/jpeg" />
    <meta property="og:image:width" content="600" />
    <meta property="og:image:height" content="1200" />
    <meta property="og:title" content="@ogTitle" />
    <meta property="og:description" content="@ogDescription" />
    <meta property="og:locale" content="en_US" />
    <meta name="twitter:card" content="photo" />
    <meta name="twitter:site" content="@ogSite_Name" />
    <meta name="twitter:title" content="@ogTitle" />
    <meta name="twitter:image" content="@ogImage" />
    <meta name="twitter:image:width" content="600" />
    <meta name="twitter:image:height" content="600" />

    <!-- Scripts Render -->
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/jquery")
    @RenderSection("scripts", required:=False)

    <!-- Web references to libraries -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    @*<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>*@
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>

    <!-- Site CSS Fonts -->
    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Merriweather" />
    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=PT+Sans" />
    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Oleo+Script" />

    <!-- Site Scripts and CSS -->
    <link rel="stylesheet" href="~/Content/Site.css" />
    <script src="~/Scripts/sitescripts.js"></script>

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>

<body style="background-color: black; overflow-y: scroll;">

    <!-- Load Facebook SDK for JavaScript -->
    <div id="fb-root"></div>
    <script>
    (function (d, s, id) {
            var js, fjs = d.getElementsByTagName(s)[0];
            if (d.getElementById(id)) return;
            js = d.createElement(s); js.id = id;
            js.async = true;
            js.src = 'https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v3.1&appId=@fbAppID&autoLogAppEvents=1';
            fjs.parentNode.insertBefore(js, fjs);
        }(document, 'script', 'facebook-jssdk'));
    </script>

    @Html.Partial("_Header")

    <div class="row" style="min-height: calc(100vh - 162px); width:100%; margin: 0;  background-color: antiquewhite;">
        @*background-image: url('@backgroundImage');*@
        <div class="col-m-3">
            @Html.Partial("_Menu")
        </div>

        <div class="col-m-6" style="padding: 0; background-color: @backgroundColor;">
            <div class="container-fluid body-content" style="padding: 0;">
                @RenderBody()
            </div>
        </div>
        
        <div class="col-m-3" style="padding: 0; background-color: burlywood;">
            @Html.Partial("Aside/_Aside")
        </div>
    </div>

    @Html.Partial("_Footer")
</body>
</html>