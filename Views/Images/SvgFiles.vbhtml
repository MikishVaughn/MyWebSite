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

    <!-- Alone -->
    <div class="goldGradient">
        <br />
        <h2 style="padding-left: 20px;">Svg Files <img style="width: 80px; height: 80px" src="~/Content/XML/Svg/Alone.svg" /></h2>
        <br />
    </div>

    <!-- SVG Menu -->
    <div class="site-menu__module-group" data-metrics-category="Page Menu" data-metrics-label="Menu" style="padding-left:10px; padding-top:15px">

        <!-- Site Svgs -->
        <br />
        <div Class="links-menu__module">
            <br />
            <h6 class="links-menu__header">Site Svg Files</h6>
            <ul>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Photos.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/Photos.Svg" /> Photos
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/BlueSun.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/BlueSun.Svg" /> Sunsets
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Fishing.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/Fishing.Svg" /> Fishing
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Wildlife.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/Wildlife.Svg" /> Wildlife
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" style=" margin-left:-35px" onclick="newTab('../Content/XML/Svg/Site/Humor.SVG')">
                        <img style="height:80px; width:124px;" src="~/Content/XML/Svg/Site/Humor.Svg" /> Humor
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Memes.svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/Memes.Svg" /> Bridget's Memes
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" style=" margin-left:-20px" onclick="newTab('../Content/XML/Svg/Site/Retired.SVG')">
                        <img style="height:80px; width:108px;" src="~/Content/XML/Svg/Site/Retired.Svg" /> Old Jokes Home
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" style=" margin-left:-20px" onclick="newTab('../Content/XML/Svg/Site/Countdowns.Svg')">
                        <img style="height:100px; width:100px;" src="~/Content/XML/Svg/Site/Countdowns.Svg" /> Events
                    </Button>
                </li>
            </ul>
        </div>

        <!-- Seasons -->
        <br />
        <div Class="links-menu__module">
            <br />
            <h6 class="links-menu__header">Seasons</h6>
            <ul>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/SunGlasses.Svg')">
                        <img style="height:80px; width:160px;" src="~/Content/XML/Svg/Site/SunGlasses.Svg" /> Summer
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Autumn1.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/Autumn1.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Autumn2.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/Autumn2.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Autumn3.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/Autumn3.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Autumn4.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/Autumn4.Svg" /> Autumn
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Snowman.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/Snowman.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Blue_Snowman_003a.Svg')">
                        <img style="Text-align: center; height:100px; width: 100px;" src="~/Content/XML/Svg/Site/Blue_Snowman_003a.svg" /> Winter
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Snowflake1.Svg')">
                        <img style="height:60px; width:60px;" src="~/Content/XML/Svg/Site/Snowflake1.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Snowflake2.Svg')">
                        <img style="height:60px; width:60px;" src="~/Content/XML/Svg/Site/Snowflake2.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Snowflake3.Svg')">
                        <img style="height:60px; width:60px;" src="~/Content/XML/Svg/Site/Snowflake3.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Snowflake4.Svg')">
                        <img style="height:60px; width:60px;" src="~/Content/XML/Svg/Site/Snowflake4.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Snowflake5.Svg')">
                        <img style="height:60px; width:60px;" src="~/Content/XML/Svg/Site/Snowflake5.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Snowflake6.Svg')">
                        <img style="height:60px; width:60px;" src="~/Content/XML/Svg/Site/Snowflake6.Svg" /> Snowflakes
                    </Button>
                </li>
            </ul>
        </div>

        <!-- Holidays -->
        <br />
        <div Class="links-menu__module">
            <br />
            <h6 class="links-menu__header">Holidays</h6>
            <ul>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Heart1.Svg')">
                        <img style="Text-align: center; height:80px; width: 80px;" src="~/Content/XML/Svg/Site/Heart1.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Heart2.Svg')">
                        <img style="Text-align: center; height:80px; width: 80px;" src="~/Content/XML/Svg/Site/Heart2.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Heart3.Svg')">
                        <img style="Text-align: center; height:80px; width: 80px;" src="~/Content/XML/Svg/Site/Heart3.Svg" /> Valentine
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Egg1.Svg')">
                        <img style="Text-align: center; height:80px; width: 80px;" src="~/Content/XML/Svg/Site/Egg1.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Egg2.Svg')">
                        <img style="Text-align: center; height:80px; width: 80px;" src="~/Content/XML/Svg/Site/Egg2.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Egg3.Svg')">
                        <img style="Text-align: center; height:80px; width: 80px;" src="~/Content/XML/Svg/Site/Egg3.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Egg4.Svg')">
                        <img style="Text-align: center; height:80px; width: 80px;" src="~/Content/XML/Svg/Site/Egg4.Svg" /> Easter
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Jack-O-Lantren.Svg')">
                        <img style="Text-align: center; height:80px; width: 80px;" src="~/Content/XML/Svg/Site/Jack-O-Lantren.Svg" /> Holloween
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Bat1.Svg')">
                        <img style="Text-align: center; height:80px; width: 80px;" src="~/Content/XML/Svg/Site/Bat1.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Bat2.Svg')">
                        <img style="Text-align: center; height:80px; width: 80px;" src="~/Content/XML/Svg/Site/Bat2.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Bat3.Svg')">
                        <img style="Text-align: center; height:80px; width: 80px;" src="~/Content/XML/Svg/Site/Bat3.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Bat4.Svg')">
                        <img style="Text-align: center; height:80px; width: 80px;" src="~/Content/XML/Svg/Site/Bat4.Svg" /> Bats
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Turkey.Svg')">
                        <img style="Text-align: center; height:80px; width: 80px;" src="~/Content/XML/Svg/Site/Turkey.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Pumpkin.Svg')">
                        <img style="Text-align: center; height:80px; width: 80px;" src="~/Content/XML/Svg/Site/Pumpkin.svg" /> Thanksgiving
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Santa2.Svg')">
                        <img style="Text-align: center; height:100px; width: 100px;" src="~/Content/XML/Svg/Site/Santa2.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Santa1.Svg')">
                        <img style="Text-align: center; height:100px; width: 100px;" src="~/Content/XML/Svg/Site/Santa1.Svg" /> Santa
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Elf1.Svg')">
                        <img style="Text-align: center; height:100px; width: 100px;" src="~/Content/XML/Svg/Site/Elf1.Svg" />
                    </Button>
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Elf2.Svg')">
                        <img style="Text-align: center; height:100px; width: 100px;" src="~/Content/XML/Svg/Site/Elf2.Svg" /> <span>Shelf Elf</span>
                    </Button>
                </li>
            </ul>
        </div>

        <!-- Svg Scenes -->
        <br />
        <div Class="links-menu__module">
            <br />
            <h6 class="links-menu__header">Svg Scenes</h6>
            <ul>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/The_Dark_Side_Of_The_Moon.Svg')">
                        <img style="Text-align: center; height:500px; width: 500px;" src="~/Content/XML/Svg/Site/The_Dark_Side_Of_The_Moon.Svg" /> <span>Dark Side</span>
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/The_Dark_Side_Of_The_Moon_Jagged.Svg')">
                        <img style="Text-align: center; height:500px; width: 500px;" src="~/Content/XML/Svg/Site/The_Dark_Side_Of_The_Moon_Jagged.Svg" /> <span>Jagged</span>
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Snowman_Scene.Svg')">
                        <img style="Text-align: center; height:500px; width: 500px;" src="~/Content/XML/Svg/Site/Snowman_Scene.Svg" /> <span>Snowman Scene</span>
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Santa-tg.Svg')">
                        <img style="Text-align: center; height:600px; width: 600px;" src="~/Content/XML/Svg/Site/Santa-tg.Svg" /> <span>Santa Scene</span>
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Christmas.Svg')">
                        <img style="Text-align: center; height:600px; width: 600px;" src="~/Content/XML/Svg/Site/Christmas.Svg" /> <span>Santa Scene</span>
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Election2018_sm.Svg')">
                        <img style="Text-align: center; height:600px; width: 600px;" src="~/Content/XML/Svg/Site/Election2018_sm.Svg" /> <span>Blue Wave</span>
                    </Button>
                </li>
                <li class="links-menu__item">
                        <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Election2018_lg.Svg')">
                            <img style="height:150px; width:300px;" src="~/Content/XML/Svg/Site/Election2018_lg.Svg" /> <span>Fishy Elections</span>
                        </Button>
                    </li>
            </ul>
        </div>

        <!-- Controls -->
        <br />
        <div Class="links-menu__module">
            <br />
            <h6 class="links-menu__header">Controls</h6>
            <ul>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Home.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/Home.Svg" /> Home
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Info.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/Info.Svg" /> Info
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Previous.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/Previous.Svg" /> Previous
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Google_Square.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/Next.Svg" /> Next
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Links.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/Links.Svg" /> Links
                    </Button>
                </li>
            </ul>
        </div>

        <!-- Logos -->
        <br />
        <div Class="links-menu__module">
            <br />
            <h6 class="links-menu__header">Logo Files</h6>
            <ul>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/GitHub.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/GitHub.Svg" />GitHub Logo
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/Google_Square.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/Google_Square.Svg" /> Google Logo
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/FB_Home.Svg')">
                        <img style="width:80px; height: 80px;" src="~/Content/XML/Svg/Site/FB_Home.Svg" /> Facebook Home
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/FB_Round.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/FB_Round.SVG" /> Facebook Round
                    </Button>
                </li>
                <li class="links-menu__item">
                    <Button id="openTab" onclick="newTab('../Content/XML/Svg/Site/FB_Square.Svg')">
                        <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/FB_Square.Svg" /> Facebook Square
                    </Button>
                </li>
            </ul>
        </div>

        <!-- Flash -->
        @*<br />
        <div Class="links-menu__module">
            <br />
            <h6 class="links-menu__header">Flash Files</h6>
            <ul>
                <li class="links-menu__item">
                    <a href="~/Content/Flash/Fit.fla">Have a fit</a>
                </li>
            </ul>
        </div>*@
    </div>
</div>