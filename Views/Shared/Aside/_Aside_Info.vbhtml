<style>

    #Info {
        display: none;
        color: black;
        background-color: #FFFF7D;
        padding: 5px 10px 5px 10px;
        margin-right: 15px;
        margin-bottom: 10px;
        margin-left: 15px;
        max-width: 428px;
    }
</style>

<div class="rightAlign" id="show" style="margin-right: 15px;">
    <p>
        <b><i>Show Website Technical Notes: </i></b><img style="width:26px;height:26px;"src="~/Content/XML/Svg/Site/Info.svg" />
    </p>
</div>

<div id="Info">
    <div class="rightAlign" id="hide">
        <p><b><i>Hide Website Technical Notes: </i></b><img style="height:26px; width:26px;" src="~/Content/XML/Svg/Site/Info.svg" />
        </p>
    </div>
    <p id="Aside_P">
        We've created a reusable <b>VB MVC Web App</b> fitting well on phones, tablets, and desktops, plus we're constantly adding more multi-platform 'content providing' features. This is the lite version of same framework used in our application tracking and accounting software packages.
    <p>
        All of the site's sections are <b>just for fun</b> and contain content from various members and friends (more content welcome). The <a href="/Countdowns/Countdowns">Events</a> were technical fun for us, because some Events like the Seasons have annually varying dates and time, but the correct time has to be displayed regardless of the Event, the viewer's time zone, and whether Daylight Savings Time is used.
    </p>
    <p style="padding-left: 10px; padding-right: 5px; font-size: small;">
        JScript handles client-side Event date and time tracking, while we've written <button title="GitHub Source Code" id="newTab" onclick="newTab('https://github.com/MikishVaughn/Seasons/wiki/Equinoxes-and-Solstices')">Functions</button> to calculate the Season Starting Dates, as well as using our <a href="/Countdowns/Easter">Easter </a><button title="GetHub Source Code" id="newTab" onclick="newTab('https://github.com/MikishVaughn/Easter/ReadMe.md')">Function</button> to derive it's date. Other Events use functions from our Countdown class, or are static dates.
    </p>
    <p>
        The Photos and Humor section use our image controller to dynamically cycle through directories of pictures. There are buttons for copying the image link and also to share (currently on Facebook, but other sites can easily be incorporated.) New images simply need to be added to the target directory and named with the next sequential number; the controller will automatically display the image along with the other image files in the target directory. Look for further enhancements  to the image presentation controller in the future as time permits.
    </p>
    <p style="padding-top: 15px; font-size: small;">
        <text style="color: green;"> $$$</text>While this website is just for fun, let us know if you need desktop apps, websites, or custom spreadsheets and reporting for your business; we have years and years of experience working with Businesses, RAD Development, and providing Business Solutions, especially the inventory and financial aspects of a business. 
    </p>
    
    <p id="rightAlign" style="font-size: 10px;">
        This site's coding is archived on GitHub here:
        <button title="GitHub" id="newTab" onclick="newTab('https://github.com/MikishVaughn/MyWebSite/')">
            <img style="height:20px; width:20px;" src="~/Content/XML/Svg/Site/GitHub.svg" />
        </button>
    </p>
</div>

<script>
    $(document).ready(function () {
        $("#hide").click(function () { $("#Info").hide(1000); $("#show").show(1000) });
        $("#show").click(function () { $("#Info").show(1000); $("#show").hide(1000) });
    });
</script>