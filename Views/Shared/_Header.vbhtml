@Imports Microsoft.AspNet.Identity

@Code
    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim PageTitle As String = ViewData("PageTitle")

    Dim LoginStuff As String = "HIDDEN"
    'If siteName = "The Mikish Group" Then
    '    LoginStuff = ""
    'End If
End Code

<style>
    .header {
        color: black;
        height: 87px;
    }

    .site__header-brand {
        font-family: "Knockout 31 4r", HelveticaNeue-CondensedBold, Helvetica, Arial, sans-serif;
        font-weight: 400;
        font-size: 1.4rem;
        -webkit-font-smoothing: antialiased;
        color: burlywood;
        margin-bottom: 0px;
    }

        .site__header-brand:hover,
        .site__header-brand:focus {
            color: chocolate;
        }

        #HomeSVG:hover,
        #HomeSVG:focus {
            fill: chocolate;
        }
</style>

<nav class="navbar navbar-expand-md" style="padding: 0 10px; background-color: black;">

    <div class="row" style="width:100%;">

        <!-- Brand/logo -->
        <div id="Home" class="col-md-5">
            <a class="site__header-brand" href="~/Info/About">
                <img id="HomeSVG" style="width: 20px; height: 20px; padding-bottom: 0; margin-top:-5px;" src="~/Content/XML/Svg/Site/Home.svg" /> @siteName
            </a>
        </div>

        <!-- Login Links -->
        <div @LoginStuff class="col-md-7" style="padding-left: 30px;">
            @Html.Partial("_LoginPartial")
        </div>
    </div>
</nav>