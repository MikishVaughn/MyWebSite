@code
    Dim bgImage As String = "000020-3.jpg"
    Dim BackgroundImage As String = SiteHelpers.GetImageLocation() + "Categories/backgrounds/" + bgImage
End code

<style>
    #Header p {
        font-family: "Knockout 31 4r", HelveticaNeue-CondensedBold, Helvetica, Arial, sans-serif;
        font-weight: 400;
        font-size: 18px;
        color: chocolate;
    }
</style>

<div>

    <!-- Image -->
    <div>
        <div style = "text-align:center;">
            <img style="width:100%; background-size: cover;" src="@BackgroundImage" />
        </div>
    </div>

    <!-- Site Description -->
    <div id="Header" style="text-align: center; line-height: 1.5; padding-top: 25px;">
        <p>
            Enjoy the Lake Life at Lake Catatoga!
            <br />
            <br />
        </p>
        <p style="font-size: 16px;">
            We hope you enjoy looking through<br />
            the images in the Photos and Humor sections<br />
            as well as take advantage of the Event Countdowns!
        </p>
    </div>
</div>