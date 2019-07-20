@code
    Dim category As String = ViewData("message")
    Dim imageCount As Integer = SiteHelpers.MaxImages(category)
End Code

<div style="padding-left: 15px; padding-right: 15px;">
    <h2>Cartoons <img style="width: 80px; height: 80px;" src="~/Content/XML/Svg/Site/LaughingFace.SVG" /></h2>
    <br />
    <p style="padding-left:20px; color: black; font-size: 18px; font-weight:400;">
        A collection of @imageCount various Humorous images.
    </p>
    <br />

    @*<p style="color: black;">
        <b>Like</b> the <b>Cartoons</b> and share with friends, or use the picture's share button to just share the selected cartoon on Facebook.
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

<!-- More Humor Choices -->
<br />
<div class="goldGradient">
    <nav>
        <ul>
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Jokes">Steve's Jokes</a></li>
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Memes">Bridget's Memes</a></li>
            @*<li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Political">Political</a></li>*@
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/NSFW">NSFW</a></li>
        </ul>
    </nav>
</div>
