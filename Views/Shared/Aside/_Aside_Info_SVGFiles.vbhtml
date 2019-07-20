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

<div style="padding-left: 15px; padding-right: 15px;">
    <p style="padding-left: 20px; color: black; font-size: 18px; font-weight: 400;">
        Svg Image Files used on this site plus some.
    </p>
    <p>
        This is our growing collection of colorful <b>SVG Files</b> for this website. Most, like the <b>Logo Files</b> are recreations of existing image themes (Company Logos), others are heavily edited existing files to suit our needs, and some, we've created specifically for this site. We do our creating and editing in <Button id="newTab" style="font-size: 16px; color:saddlebrown;" onclick="newTab('https://www.adobe.com/products/illustrator.html?promoid=PGRQQLFS&mv=other')">
            Adobe Illustrator
        </Button>.
    </p>
    <p>
        <b>Why websites should use SVG graphics?</b>
    </p>
    <p>
        When it comes to adding images to a website, the web designer either chooses raster or vector. A raster image is typically a photo made up of pixels with a set resolution. It loses quality when scaled up and can appear grainy.
    </p>
    <p>
        Meanwhile, a vector image is made using lines, points and shapes. The web designer can scale it to any size without losing quality and still display a very crisp and clear image.
    </p>
    <p>
        Here is a helpful link outlining simple HTML and CSS usage on a web site:
        <Button id="newTab" style="font-size: 16px; color:saddlebrown;" onclick="newTab('https://developer.mozilla.org/en-US/docs/Learn/HTML/Multimedia_and_embedding/Adding_vector_graphics_to_the_Web')">
            Adding vector graphics to the Web
        </Button>
    </p>
    <br />
    <p>
        For web designers having problems with the Svg files not displaying on sites like GoDaddy (our Web Host), be sure to map the 'Svg' type in the Web.Config file in the root directory of your site.
    </p>
</div>

<div class="rightAlign" id="show" style="margin-right: 15px;">
    <p>
        <b>Show Web.Config Fixes: </b><img style="width:26px;height:26px;" src="~/Content/XML/Svg/Site/Info.svg" />
    </p>
</div>

<div id="Info">
    <div class="rightAlign" id="hide">
        <p>
            <b>Hide Web.Config Fixes: </b><img style="height:26px; width:26px;" src="~/Content/XML/Svg/Site/Info.svg" />
        </p>
    </div>
    <p id="Aside_P">
        We add the following lines to our Web.Config file...
    </p>
    <div style="font-size: 12px;">
        <g style="color:darkred;">&lt;system.webServer&gt;</g>
        <br />
        <br />
        <g style="padding-left:10px; color: mediumblue;">&lt;!--</g><g style="color:darkgreen;"> Web.Config SVG fix for IIS Servers --&gt;</g>
        <br />
        <g style="padding-left: 10px; color: darkred;">&lt;staticContent&gt;</g>
        <br />
        <g style="padding-left: 20px; color: darkred;">&lt;remove </g><g style="color: mediumblue;">fileExtension=".svg" /&gt;</g>
        <br />
        <g style="padding-left: 20px; color: darkred;">&lt;mimeMap </g><g style="color: mediumblue;">fileExtension=".svg" mimeType="image/svg+xml" /&gt;</g>
        <br />
        <g style="padding-left: 10px; color: darkred;">&lt;staticContent /&gt;</g>
        <br />
        <g style="padding-left: 10px; color: mediumblue;">&lt;!--</g><g style="color: darkgreen;"> End of SVG fix --&gt;</g>
        <br />
    </div>
    <br />
    <div style="font-size: 12px;">
        <p id="Aside_P" style="padding-left:10px;">
            We also add the following lines to our Web.Config file to fix the Browser address display from repeating the domain name twice on non-primary domains hosted on GoDaddy IIS Servers. This HAS to be commented out for the root level domain *only*.
        </p>
        <g style="padding-left: 10px; color: mediumblue;">&lt;!--</g><g style="color:darkgreen;"> Browser Double Domain Name Fix --&gt;</g>
        <br />
        <g style="padding-left: 10px; color: darkred;">&lt;rewrite&gt;</g>
        <br />
        <g style="padding-left: 20px; color: darkred;">&lt;rules&gt;</g>
        <br />
        <g style="padding-left: 30px; color: darkred;">&lt;rule&gt; </g><g style="color:mediumblue;">name="Remove Virtual Directory" /&gt;</g>
        <br />
        <g style="padding-left: 40px; color: darkred;">&lt;match </g><g style="color:mediumblue;">url=".*" /&gt;</g>
        <br />
        <g style="padding-left: 40px; color: darkred;">&lt;action </g><g style="color:mediumblue;">type="Rewrite" url="{R:0}" /&gt;</g>
        <br />
        <g style="padding-left: 30px; color: darkred;">&lt;/rule&gt;</g>
        <br />
        <g style="padding-left: 20px; color: darkred;">&lt;/rules&gt;</g>
        <br />
        <g style="padding-left: 10px; color: darkred;">&lt;/rewrite&gt;</g>
        <br />
        <g style="padding-left: 10px; color: mediumblue;">&lt;!--</g><g style="color:darkgreen;"> End of Domain Name Fix --&gt;</g>
        <br />
        <br />
        <g style="color: darkred;">&lt;/system.webServer&gt;</g>
        <br />
    </div>
    <br />
    <p id="Aside_P">
        One last GoDaddy Web.Config Fix...you HAVE to comment out any entries between <g style="color: darkred;">&lt;system.codedom&gt;</g> and <g style="color: darkred;">&lt;/system.codedom&gt;</g>
    </p>
    <p id="rightAlign" style="font-size: 10px;">
        Archived on GitHub:
        <button title="GitHub" id="newTab" onclick="newTab('https://github.com/MikishVaughn/MyWebSite/')">
            <img style="height:16px; width:16px;" src="~/Content/XML/Svg/Site/GitHub.svg" />
        </button>
    </p>
</div>

<br />

<script>
    $(document).ready(function () {
        $("#hide").click(function () { $("#Info").hide(1000); $("#show").show(1000) });
        $("#show").click(function () { $("#Info").show(1000); $("#show").hide(1000) });
    });
</script>