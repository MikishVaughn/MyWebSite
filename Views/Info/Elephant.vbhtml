@Code
    Dim pictureLocation As String = SiteHelpers.GetImageLocation() + "Categories/Backgrounds/Elephant.jpg"
End Code
<style>
    .row {
        margin: 0;
    }
</style>
@*<div class="row" style="padding-top: 10px; padding-right: 10px; background-image: url('/Content/Images/Categories/Backgrounds/image-000000.png');">*@
<div class="row" style="padding-top: 10px; padding-right: 10px; background-color: black;">
    <!-- Left side -->
    <div class="col-md-5">
        @Html.Partial("_Elephant")
    </div>

    <!-- Right side -->
    <div class="col-md-7" style="padding-top: 0; text-align: center;" data-toggle="tooltip" title="Blind men and the elephant">
        <img id="countdown-Image" style="width: 100%;" src="@pictureLocation" alt="@ViewData("Message") Image" />
    </div>
</div>

@*<script src="~/Scripts/sitescripts.js"></script>
<script>
    changeBackground('url(/Content/Images/Categories/Backgrounds/image-000000.png)')
</script>*@