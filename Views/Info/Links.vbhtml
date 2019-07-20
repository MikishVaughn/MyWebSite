@code
End Code

<style>

    #openTab {
        font-family: "Knockout 31 4r", HelveticaNeue-CondensedBold, Helvetica, Arial, sans-serif;
        font-size: 20px;
        font-weight: 400;
        letter-spacing: 1.08px;
        -webkit-font-smoothing: antialiased;
        margin: 0;
        padding: 8px 10px;
        width: auto;
        background-color: transparent;
        text-decoration: none;
        text-decoration-line: none;
        border: none;
        color: black;
        text-shadow: 0 0 1px burlywood;
        border: solid thin transparent;
        padding-left: 10px;
    }

        #openTab:hover,
        #openTab:focus {
            text-decoration: none;
            text-decoration-line: none;
            outline: none;
            color: white;
            text-shadow: 0 0 1px #602c06;
            background-color: burlywood;
            border: solid thin #602c06;
            border-right: none;
            border-top-left-radius: 10px;
            border-top-right-radius: 10px;
            border-bottom-left-radius: 10px;
            border-bottom-right-radius: 10px;
        }
</style>

<div id="site-menu" class="site-menu" role="contentinfo" aria-label="Site menu">

    <div class="goldGradient">
        <br />
        <h2 style="padding-left: 20px;">Helpful Links <img style="width:80px; height: 80px;" src="~/Content/XML/Svg/Site/Links.svg" /></h2>
        <br />
    </div>    

    <div class="site-menu__module-group" data-metrics-category="Page Menu" data-metrics-label="Menu" style="padding-left: 20px; padding-top: 15px;">
        <br />
        <div Class="links-menu__module">
            <h6 class="links-menu__header">Social</h6>
            <ul>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('http://twitter.com')">Twitter</Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('http://instagram.com')">Instagram</Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('http://facebook.com')">Facebook</Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('http://Reddit.com')">Reddit</Button>
                </li>
                @*<li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('http://www.judici.com/')">Ill. Judi Watch</Button>
                </li>*@
            </ul>
        </div>

        <div Class="links-menu__module">
            <h6 class="links-menu__header">Utilities</h6>
            <ul>
                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('https://www.gieson.com/Library/projects/utilities/tuner/index.html')">Guitar Tuner</button>
                </li>
                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('https://www.unscramble.net/modules.php?name=Unscramble')">Unscramble</button>
                </li>
                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('http://www.sevenwires.com/play/UpsideDownLetters.html')">Upsidedown Typing</button>
                </li>
                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('https://www.zamzar.com/')">File Conversion</button>
                </li>
                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('https://bulkresizephotos.com/')">Bulk Image Resizer</button>
                </li>
            </ul>
        </div>

        <div Class="links-menu__module">
            <h6 class="links-menu__header">Programming</h6>
            <ul>
                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('https://www.w3schools.com//')">W3 Schools</button>
                </li>
                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('https://stackoverflow.com/')">Stackoverflow</button>
                </li>
                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('https://developers.facebook.com/tools/debug/')">FB Debugger</button>
                </li>
                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('http://converter.telerik.com/')">Telrik Code Converter</button>
                </li>
                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('https://www.htmlcsscolor.com')">Html CSS Color (Best)</button>
                </li>
                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('https://hashtagcolor.com/ff780f')">Color Chart</button>
                </li>

                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('http://www.cssbuttongenerator.com/')">CSS Button Generator</button>
                </li>
                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('https://lingojam.com/SuperscriptGenerator')">Superscript Generator</button>
                </li>
                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('http://aa.usno.navy.mil/data/docs/JulianDate.php')">Julian Date Converter</button>
                </li>
                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('http://www.iconninja.com/')">Icon Ninja - Icons and SVG's</button>
                </li>
                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('https://inkscape.org/en/download/windows/')">Inkscape - Svg Editor</button>
                </li>
                <li class="links-menu__item">
                    <button id="openTab" onclick="newTab('https://www.uihere.com/')">UI Here - Photo/Image finder</button>
                </li>
            </ul>
        </div>

        <div Class="links-menu__module">
            <h6 class="links-menu__header">Graphics</h6>
            <ul>
                <li class="links-menu__item">
                    <a class="nav-link" href="~/images/SvgFiles">SVG Files</a>
                </li>
            </ul>
            <ul>
                <li class="links-menu__item">
                    <a class="nav-link" href="~/images/Snow5">Animated Snow</a>
                </li>
            </ul>            
            <br />
            <h6 class="links-menu__header">More...</h6>
            <ul>
                <li class="links-menu__item">
                    <a class="nav-link" href="~/Info/More">Content Needed!</a>
                </li>
            </ul>
        </div>

        <div class="links-menu__module">
            @If Request.IsAuthenticated Then
                @Html.AntiForgeryToken()
                @<h6 class="links-menu__header">Finance</h6>
                @<ul>
                    <li class="links-menu__item">
                        <button id="openTab" onclick="newTab('https://www.chase.com/')">Chase</button>
                    </li>
                    <li class="links-menu__item">
                        <button id="openTab" onclick="newTab('https://www.cnbil.com/central')">CNB Banking</button>
                    </li>
                    <li class="links-menu__item">
                        <button id="openTab" onclick="newTab('https://www.wellsfargo.com/')">Wells Fargo</button>
                    </li>
                </ul>
            End if
        </div>
    </div>
</div>