@code
    Dim category As String = ViewData("message")
    Dim imageCount As Integer = SiteHelpers.MaxImages(category)
End Code

<div style="padding-left: 15px; padding-right: 15px;">
    <h2>Fishing <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/Fishing.svg" /></h2>
    <br />
    <p style="padding-left:20px; color: black; font-size: 18px; font-weight:400;">
        A collection Of @imageCount @category images.
    </p>
    <br />

    @*<p style="color: black;">
        <b>Like</b> the <b>Fishing</b> Photos page And share With friends, Or use the picture's share button to just share the selected photo on Facebook.
    </p>
    <div Class="fb-like"
         style="height: 30px;
         padding-top: 5px;"
         data-layout="button"
         data-action="like"
         data-show-faces="false"
         data-share="true">
    </div>*@

</div>

<!-- More images Choices -->
<br />
<div class="goldGradient">
    <nav class="navbar navbar-expand">
        <ul>
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Sunsets">Sunsets</a></li>
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Wildlife">Wildlife</a></li>
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/ScentMe">ScentMe</a></li>
        </ul>
    </nav>
</div>
