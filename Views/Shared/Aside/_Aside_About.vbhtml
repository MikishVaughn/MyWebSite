@code
    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim emailAddress As String = SiteHelpers.GetSiteInfo("SiteEmail_Support")
    Dim this_Href As String = "https://" + SiteHelpers.RootUrl() + "/Info/About"
    Dim siteFacebookPageURL As String = SiteHelpers.GetSiteInfo("SiteFacebookPageURL")
End Code

<style>

    p {
        line-height: normal;
    }
</style>

@*<div class="row" style="margin-right: 0px; margin-left: 0px;">*@
    <div style="padding-left:15px; padding-right: 15px;">
        <div class="myAsideCol">
            <div id="_Aside_About" style="max-width: 448px; padding: 5px 10px 5px 10px;">

                <h2>
                    @siteName <button title="@siteName" id="newTab" onclick="newTab('@siteFacebookPageURL')" /> <img style="height:80px; width:80px; padding-bottom: 10px;" src="~/Content/XML/Svg/Site/FB_Home.svg" />
                </h2>

                <p style="color: black; font-size: larger;">
                    <b>Welcome, and enjoy browsing!</b>
                </p>
                <p style="color: black;">
                    The purpose of this site is <b>entertainment</b>; <i>our</i> fun is from developing the website, while <i>you</i> might enjoy looking through the images in the <a style="color: black;" href="/Images/Photos">Photos</a> and <a style="color: black;" href="/Images/Humor">Humor</a> sections, as well as from taking advantage of the Event <a style="color: black;" href="/Countdowns/Countdowns">Countdowns</a>.
                </p>
                <p style="color: black;">
                    &bull; <b><a style="color: black;" href="/Images/Photos">Photos</a></b> contains a small, but growing selection of interesting pictures taken by our friends, or found on the Internet.
                </p>
                <p style="color: black;">
                    &bull; <b><a style="color: black;" href="/Images/Humor">Humor</a></b> contains a large selection of often humorous jokes, memes, and cartoons from various Mikish Group Members.
                </p>
                <p style="color: black;">
                    &bull; <b><a style="color: black;" href="/Countdowns/Countdowns">Event Countdowns</a></b> originally started with Spring and other Season countdowns while awaiting the end of a long winter; now several other Events are on the menu.
                </p>
                <br />

                <!-- Facebook Like and Share -->
                @*<p style="color: black; height: 16px;">
                    <x class="fb-like"
                       data-layout="button"
                       data-action="like"
                       data-show-faces="false"
                       data-share="false">
                    </x> <b>@siteName</b> and
                    <x class="fb-share-button"
                       data-layout="button"
                       data-href="@this_Href"
                       data-size="small">
                    </x> with <b>friends.</b>
                </p>*@
                <br />
            </div>
        </div>

        <div class="myAsideCol">
            @Html.Partial("Aside/_Aside_Info")
        </div>

    </div>
@*</div>*@