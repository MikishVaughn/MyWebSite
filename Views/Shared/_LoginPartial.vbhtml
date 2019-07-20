@Imports Microsoft.AspNet.Identity

<style>
    .nav-item a {
        padding-right: 10px;
        margin-top: 0px;
        padding-top: 5px;
        padding-bottom: 0;
        display: block;
        text-decoration: none;
        font-family: "Knockout 31 4r", HelveticaNeue-CondensedBold, Helvetica, Arial, sans-serif;
        font-weight: 400;
        font-size: 14px;
        color: chocolate;
    }

        .nav-item a:hover,
        footer a:focus {
            color: burlywood;
        }

    a:hover,
    a:focus {
        color: burlywood;
        text-decoration: none;
    }

    #loginLink {
        color: white;
    }

        #loginLink:hover,
        #loginLink:focus {
            color: burlywood;
            display: block;
            text-decoration: none;
        }

    #logout {
        color: white;
    }

        #logout:hover,
        #logout:focus {
            color: burlywood;
            display: block;
            text-decoration: none;
        }

    .justify-content-end {
        padding-top:5px;
    }
</style>
@*<li class="nav-item">@Html.ActionLink(User.Identity.GetUserName(), "Index", "Manage", routeValues:=Nothing, htmlAttributes:=New With {.title = "Manage"})</li>*@
@Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With {.id = "logoutForm", .class = "navbar-right"})
    @If Request.IsAuthenticated Then
        @Html.AntiForgeryToken()
        @<ul class="nav navbar-nav justify-content-end" style="padding-bottom: 10px;">
            <li class=nav-item>
                @Html.ActionLink("Manage Account", "Index", "Manage", routeValues:=Nothing, htmlAttributes:=New With {.title = "Manage"})
            </li>
            <li class="nav-item">
                <a style="padding-top:5px; padding-bottom: 0;" class="nav-link" id="logout" href="javascript:document.getElementById('logoutForm').submit()"> Log off</a>
            </li>
        </ul>
    Else
        @<ul class="nav navbar-nav justify-content-end" style="padding-bottom: 10px;">
            <li class="nav-item">
                @Html.ActionLink("Register", "Register", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "registerLink"})
            </li>
            <li class="nav-item" style="padding-bottom: 10px;">
                @Html.ActionLink("Log in", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "loginLink"})
            </li>
        </ul>
    End If
End Using