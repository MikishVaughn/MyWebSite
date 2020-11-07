@code
    Dim category As String = ViewData("message")
    Dim imageCount As Integer = SiteHelpers.MaxImages(category)
End Code

<div style="padding-left: 15px; padding-right: 15px;">
    <div style="color:black;">
        <h3>Bridget's Facebook Memes <img style="width: 80px; height: 80px;" src="~/Content/XML/Svg/Site/Memes.svg" /></h3>
        <br />
        <p style="padding-left:20px; color: black; font-size: 18px; font-weight:400;">
            A collection of @imageCount humorous Memes from the world famous meme consumer, Bridget!
        </p>
        <p style="padding-left:20px; color: black; font-size: 18px; font-weight:400;">
            <b>Bridget</b> also runs the popular group on Facebook,
        </p>
        <p style="padding-left:20px; color: black; font-size: 18px; font-weight:400;">
            <h2>Daily Dancing <button title="Facebook Daily Dancing." id="newTab" onclick="newTab('https://www.facebook.com/dailydancing/')" /><img style="height:80px; width:80px; padding-bottom: 10px;" src="~/Content/XML/Svg/Site/FB_Home.svg" /></h2>
        </p>
    </div>
    <br />

</div>

<!-- More Humor Choices -->
<br />
<div class="goldGradient">
    <nav>
        <ul>
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Cartoons">Cartoons</a></li>
            @*<li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Political">Political</a></li>*@
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Jokes">Steve's Jokes</a></li>
            @*<li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/NSFW">NSFW</a></li>*@
        </ul>
    </nav>
</div>
