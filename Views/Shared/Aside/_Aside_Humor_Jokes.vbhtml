@code
    Dim category As String = ViewData("message")
    Dim imageCount As Integer = SiteHelpers.MaxImages(category)
End Code

<div style="padding-left: 15px; padding-right: 15px;">
    <h3>
        Steve's Old Jokes Home <img style="height:80px; width:108px;" src="~/Content/XML/Svg/Site/Retired.svg" />
    </h3>
    <br />
    <p style="padding-left:20px; color: black; font-size: 18px; font-weight:400;">
        A collection of @imageCount humorous jokes from Steve's world famous, "Old Jokes Home" on Facebook!
    </p>
    <br />

    @*<p style="color: black;">
        Like the <b>Steve's Old Jokes Home</b> page and share with friends, or use the picture's share button to just share the selected joke on Facebook.
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
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Cartoons">Cartoons</a></li>
            @*<li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Political">Political</a></li>*@
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Memes">Bridget's Memes</a></li>
            @*<li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/NSFW">NSFW</a></li>*@
        </ul>
    </nav>
</div>
