@code
    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim emailAddress As String = SiteHelpers.GetSiteInfo("SiteEmail_Support")
    Dim this_Href As String = "https://" + SiteHelpers.RootUrl() + "/Info/About"
    Dim siteFacebookPageURL As String = SiteHelpers.GetSiteInfo("SiteFacebookPageURL")
End Code

<style>
    #description p {
        font-family: "Knockout 31 4r", HelveticaNeue-CondensedBold, Helvetica, Arial, sans-serif;
        font-weight: 400;
        font-size: 16px;
        color: black;
        padding-top: 10px;
        padding-bottom: 8px;
        padding-left: 15px;
        padding-right: 15px;
        margin-bottom: 0;
    }
</style>

<div style="padding-left:15px">
    <h2>
        @siteName <button title="@siteName" id="newTab" onclick="newTab('@siteFacebookPageURL')" /> <img style="height:80px; width:80px;" src="~/Content/XML/Svg/Site/FB_Home.svg" />
    </h2>
    <br />

    <p style="color: black; font-size: larger;">
        <b>Welcome, to the Lake and enjoy browsing!</b>
    </p>

    <!-- Description -->
    <div id="description">
        <p>
            <strong>Lake Catatoga</strong> has a surface area of 66 acres, with a beautiful dam located on its northern end. The lake is situated midway between <button id="newTab" onclick="newTab('https://en.wikipedia.org/wiki/St._Louis')">St. Lous, Missouri</button> and <button id="newTab" onclick="newTab('https://en.wikipedia.org/wiki/Springfield,_Illinois')">Springfield, Illinois</button>... nine miles south of the city of <button id="newTab" onclick="newTab('https://en.wikipedia.org/wiki/Carlinville,_Illinois')">Carlinville</button>, and eighteen miles west of <button id="newTab" onclick="newTab('https://en.wikipedia.org/wiki/Litchfield,_Illinois')">Litchfield</button> in <button id="newTab" onclick="newTab('https://en.wikipedia.org/wiki/Macoupin_County,_Illinois')">Macoupin County</button>, which is named after Macoupin Creek, near Carlinville and meanders southwest to the <button id="newTab" onclick="newTab('https://en.wikipedia.org/wiki/Illinois_River')">Illinois River</button>.
        </p>
        <p>
            The region was previously inhabited by various Illinoisan Indians; Miami and Wea, as well as the tribes of the Illinois Confederation, including the Kaskaskia, Peoria, Tamaroa, Cahokia, and Mitchigamea. "Macoupin" is actually the <button id="newTab" onclick="newTab('https://en.wikipedia.org/wiki/Miami-Illinois_language')">Miami-Illinois</button> term for the <button id="newTab" onclick="newTab('https://en.wikipedia.org/wiki/Nelumbo_lutea')">"American Lotus"</button> (Nelumbo lutea). Unfortunately, none of the native Indians remain, although some descendants of the earliest European settlers claim partial ancestry. The first European arrivals were French explorers in the seventeenth century, travelling southward down the major rivers. However, the main European settlement came from the southwest, as people moved inland from the established transportation route of the Mississippi River.
        </p>
        <p>
            Today, Lake Catatoga recaptures a bit of its Indian heritage with themed street names and even @Html.ActionLink("Totem Poles", "Totempole", "images") located at the entrances. With a peaceful ambiance and convenient location, it's a highly desirable place to live and visit with a "no wake" policy creating safer conditions for swimming and boating. The Lake is annually stocked with a variety of fish including: <button id="newTab" onclick="newTab('https://en.wikipedia.org/wiki/Crappie')">Crappie</button>, <button id="newTab" onclick="newTab('https://en.wikipedia.org/wiki/Walleye')">Walleye</button>, <button id="newTab" onclick="newTab('https://en.wikipedia.org/wiki/Bluegill')">Bluegill</button>, <button id="newTab" onclick="newTab('https://en.wikipedia.org/wiki/Catfish')">Catfish</button>, <button id="newTab" onclick="newTab('https://en.wikipedia.org/wiki/Largemouth_bass')">Largemouth Bass</button> and <button id="newTab" onclick="newTab('https://en.wikipedia.org/wiki/Rock_bass')">Rock Bass</button> making for great fishing. Though the lake is <b>private</b>, a <button id="newTab" onclick="newTab('https://www.il.wildlifelicense.com/license.php?action=custlkup')">Fishing License</button> is required and <button id="newTab" onclick="newTab('https://www.il.wildlifelicense.com/vehicle.php?action=vehiclelkup')">Boat Registration</button> is mandatory.
        </p>
    </div>
    <br />
    @*<p style="color: black; height: 16px;">
        <f class="fb-like"
           data-layout="button"
           data-action="like"
           data-show-faces="false"
           data-share="false"
           style="margin: 0; padding: 0;">
            Like
        </f>
        <b>@siteName</b> and
        <f class="fb-share-button"
           data-layout="button"
           data-href=@this_Href
           data-size="small">
            Share
        </f> with <b>friends.</b>
    </p>*@
</div>

@Html.Partial("Aside/_Aside_Info")