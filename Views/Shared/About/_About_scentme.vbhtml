@code
    Dim bgImage As String = "000020-3.jpg"
    Dim BackgroundImage As String = SiteHelpers.GetImageLocation() + "Categories/backgrounds/" + bgImage
End code

<style>
    #description p {
        font-family: "Knockout 31 4r", HelveticaNeue-CondensedBold, Helvetica, Arial, sans-serif;
        font-size: 18px;
        font-weight: 400;
        color: chocolate;
    }
</style>

<div>

    <!-- Image -->
    <div>
        <div style="text-align:center;">
            <img style="width:100%; background-size: cover;" src="@BackgroundImage" />
        </div>
    </div>

    <!-- Site Description -->
    <div>
        <div id="description" style="text-align: center; padding-top: 25px;">
            <p>
                Do you feel like you are missing the Scent of Life? <br />
            </p>
            <p>
                Let Scent Me Help.
            </p>
        </div>
    </div>
</div>