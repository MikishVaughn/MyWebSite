@code
    Dim category As String = ViewData("message")
    Dim imageCount As Integer = SiteHelpers.MaxImages(category)
End Code

<div style="padding-left: 15px; padding-right: 15px;">
    <h2>Scent Me</h2>
    <br />
    <p style="padding-left:20px; color: black; font-size: 18px; font-weight:400;">
        A collection of @imageCount 'Scent Me' images.
    </p>
    <br />

</div>

<!-- More Picture Choices -->
<br />
<div class="goldGradient">
    <nav class="navbar navbar-expand">
        <ul>
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Sunsets">Sunsets</a></li>
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Wildlife">Wildlife</a></li>
            <li id="asideMenuLine" class="nav-line"><a class="nav-item aside-nav-item" href="~/images/Fishing">Fishing</a></li>
        </ul>
    </nav>
</div>
