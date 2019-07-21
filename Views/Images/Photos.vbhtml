@code
    Dim choice01 As String = ""
    Dim choice02 As String = ""
    Dim choice03 As String = ""
    Dim choice04 As String = ""
    'Dim activebackgroundcolor As String = "black"

    If ViewData("message") = "Sunsets" Then
        choice01 = "active"
    End If
    If ViewData("message") = "Fishing" Then
        choice02 = "active"
    End If
    If ViewData("message") = "Wildlife" Then
        choice03 = "active"
    End If
    If ViewData("message") = "ScentMe" Then
        choice04 = "active"
    End If
End Code

<div id="site-menu" class="site-menu" role="contentinfo" aria-label="Site menu">
    <div class="goldGradient">
        <br />
        <h2 style="padding-left: 20px;">Photos <img style="width: 80px; height: 80px" src="~/Content/XML/Svg/Site/Photos.svg" /></h2>
        <br />
    </div>
    <div class="images-menu__module-group" data-metrics-category="Page Menu" data-metrics-label="Menu">
        <br />
        <div class="images-menu__item">
            <h6 class="site-menu__header"><a class="nav-link @choice01" href="~/images/Sunsets">Sunsets</a></h6>
        </div>
        <div class="images-menu__item">
            <h6 class="site-menu__header"><a class="nav-link @choice02" href="~/images/Fishing">Fishing</a></h6>
        </div>
        <div class="images-menu__item">
            <h6 class="site-menu__header"><a class="nav-link @choice02" href="~/images/Wildlife">Wildlife</a></h6>
        </div>
        <div class="images-menu__item">
            <h6 class="site-menu__header"><a class="nav-link @choice04" href="~/images/ScentMe">Scent Me</a></h6>
        </div>
    </div>
</div>