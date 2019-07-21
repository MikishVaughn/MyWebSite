@code
    Dim category As String = ViewData("message")
    Dim imageCount As Integer = SiteHelpers.MaxImages(category)
End Code

<div style="padding-left: 15px; padding-right: 15px;">
    <h2>NSFW</h2>
    <br />
    <p style="padding-left:20px; color: black; font-size: 18px; font-weight:400;">
        A collection of @imageCount NSFW humorous images from the Internet.
    </p>
    <br />

</div>

<!-- More Humor Choices -->
<br />
<div class="goldGradient">
    <nav>
        <ul>
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Cartoons">Cartoons</a></li>
            @*<li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Political">Political</a></li>*@
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Memes">Bridget's Memes</a></li>
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Jokes">Steve's Jokes</a></li>
        </ul>
    </nav>
</div>
