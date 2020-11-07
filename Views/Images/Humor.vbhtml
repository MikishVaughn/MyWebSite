@code
    Dim choice01 As String = ""
    Dim choice02 As String = ""
    Dim choice03 As String = ""
    Dim choice04 As String = ""
    Dim choice05 As String = ""

    If ViewData("message") = "Cartoons" Then
        choice01 = "active"
    End If
    If ViewData("message") = "Political" Then
        choice02 = "active"
    End If
    If ViewData("message") = "Memes" Then
        choice03 = "active"
    End If
    If ViewData("message") = "Jokes" Then
        choice04 = "active"
    End If
    'If ViewData("message") = "NSFW" Then
    '    choice05 = "active"
    'End If
End Code

<div id="site-menu" class="site-menu" role="contentinfo" aria-label="Site menu">
    <div class="goldGradient">
        <br />
        <h2 style="padding-left: 20px; padding-bottom: 14px;">
            Humor <img style="height:90px; width:124px; margin-top:-10px;" src="~/Content/XML/Svg/Site/Humor.svg" />
        </h2>
    </div>
    <br />
    <div class="images-menu__module-group" data-metrics-category="Page Menu" data-metrics-label="Menu">
        <div class="images-menu__item">
            <h6 class="site-menu__header @choice01"><a class="nav-link" href="~/images/Cartoons">Cartoons</a></h6>
        </div>
        @*<div class="images-menu__item">
            <h6 class="site-menu__header @choice02"><a class="nav-link" href="~/images/Political">Political</a></h6>
        </div>*@
        <div class="images-menu__item">
            <h6 class="site-menu__header @choice03"><a class="nav-link" href="~/images/Memes">Bridget's Memes</a></h6>
        </div>
        <div class="images-menu__item">
            <h6 class="site-menu__header @choice04"><a class="nav-link" href="~/images/Jokes">Steve's Old Joke Home</a></h6>
        </div>
        @*<div class="images-menu__item">
            <h6 class="site-menu__header @choice05"><a class="nav-link" href="~/images/NSFW">NSFW</a></h6>
        </div>*@
    </div>
</div>