@code
    Dim category As String = ViewData("message")
    Dim imageCount As Integer = SiteHelpers.MaxImages(category)
End Code

<div style="padding-left: 15px; padding-right: 15px;">
    <h2>Sunsets <img style="width: 80px; height: 80px;" src="~/Content/XML/Svg/Site/BlueSun.Svg" /></h2>
    <br />
    <p style="padding-left:20px; color: black; font-size: 18px; font-weight:400;">
        A collection of @imageCount @category images.
    </p>
    <br />

    @*<p style="color: black;">
        Like the <b>@category</b> photos page and share with friends, or use the picture's share button to just share the selected sunset on Facebook.
    </p>
    <div class="fb-like"
         style="height: 30px;
         padding-top: 5px;"
         data-layout="button"
         data-action="like"
         data-show-faces="false"
         data-share="true">
    </div>*@

</div>

<!-- More Picture Choices -->
<br />
<div class="goldGradient">
    <nav class="navbar navbar-expand">
        <ul>
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Wildlife">Wildlife</a></li>
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Fishing">Fishing</a></li>
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/ScentMe">Scent Me</a></li>
        </ul>
    </nav>
</div>
