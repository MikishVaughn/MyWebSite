@code
    Dim bgImage As String = "000020-3.jpg"
    Dim BackgroundImage As String = SiteHelpers.GetImageLocation() + "Categories/backgrounds/" + bgImage
End code

<style>
    #description p {
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
    <div id="description" style="text-align: center; line-height: 1.5; padding-top: 25px;">
        <p>
            Do you feel like you are <br />
            Playing Chess with a Pigeon <br />
            when using your Business Software?<br />
            <br />
            Let <b>The Mikish Group</b> give you a better match!
        </p>
    </div>
</div>