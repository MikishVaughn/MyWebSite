﻿@code
    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim siteFacebookPageURL As String = SiteHelpers.GetSiteInfo("SiteFacebookPageURL")
End Code
<div class="goldGradient">
    <br />
    <h2 style="padding-left: 20px;">More Content<img style="width: 80px; height: 80px" src="~/Content/XML/Svg/Site/Photos.svg" /></h2>
    <br />
</div>
<div style="padding: 20px; background-color:antiquewhite">
    <h2 style="text-align:center">More Content welcome!</h2>
    <br />
    <h5 style="text-align:center">Would you like to add to any of the picture categories?</h5>
    <h5 style="text-align:center">Do you have a unique collection deserving its own category?</h5>
    <br />
    <br />
    <h6>We welcome <b>content</b> and plan on making it easier for users to upload directly in the future.</h6>
    <br />
    <p>
        Currently, the existing image categories are designed to take square ratioed images (i.e. 1200px x 1200px down to about 600px x 600px) the larger the image, the better the display quality, but there are limits and file size becomes a loading issue.
    </p>
    <p>
        If you have a unique set of images for a new Photo category, as long as all images are the same ratio, other dimensions besides the square ratio would be fine, though the square ratio works better on cross platforms like phone, tablet, and desktop. We're able to resize and edit dimensions in bulk if you are not familiar with those procedures.
    </p>
    <br />
    <h4 style="text-align:center">Message us through our Facebook page!</h4>
    <br />
    <div style="text-align: center">
        <h2>
            @siteName <button title="@siteName" id="newTab" onclick="newTab('@siteFacebookPageURL')" /> <img style="height:80px; width:80px; padding-bottom: 10px;" src="~/Content/XML/Svg/Site/FB_Home.svg" />
        </h2>
    </div>
</div>
