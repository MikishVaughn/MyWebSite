@code
    Dim altText As String = ViewData("PageHeader")
    Dim category As String = ViewData("Message")
    Dim imageLocation As String = SiteHelpers.GetImageLocation() + "Categories/" + category + "/"
    Dim imageCount As Integer = SiteHelpers.MaxImages(category)
End Code

<style>

    /* Make the image responsive as needed */
    .carousel-inner img {
        width: 100%;

        /*height: 90%;
         max-width: 788px;*/

        /* redimension picture to fit screen :-( */
        max-height: 908px;
        max-width: 922px;
    }

    .col-4 {
        margin: 0;
        padding: 0;
    }

    #imageLink {
        width: 100%;
        height: 0;
        color: black;
        background-color: black;
        border: none;
        text-decoration: none;
        text-decoration-line: none;
        outline: none;
        margin: 0;
        padding: 0;
        display: flex;
        nav-down: auto;
    }

        #imageLink::selection {
            background: black;
        }

    #myBtn {
        width: 100%;
        padding: 0;
        color: burlywood;
        text-shadow: 1px 1px 0px #602c06;
        background-color: chocolate;
        border: solid thin #602c06;
        border-top: none;
        border-bottom: none;
        font-size: 20px;
        font-weight: 400;
    }

        #myBtn:hover,
        #myBtn:focus,
        #myBtn:active {
            color: white;
            background-color: burlywood;
            border: solid thin #602c06;
            border-top: none;
            border-bottom: none;
            text-shadow: 1px 1px 0px #602c06;
            text-decoration: none;
            text-decoration-line: none;
            outline: none;
        }

    button {
        width: 100%;
        height: 28px;
        color: burlywood;
        text-shadow: 1px 1px 0px #602c06;
        background-color: chocolate;
        border: none;
        font-size: 16px;
        font-weight: 400;
        padding: 0;
        margin: 0;
    }

        button:focus,
        button:hover,
        button:active {
            color: white;
            background-color: burlywood;
            text-shadow: 1px 1px 0px #602c06;
            text-decoration: none;
            text-decoration-line: none;
            outline: none;
        }

    #btnGroup {
        text-align: center;
        margin: 0;
        padding: 0;
        height: 28px;
    }

    /*#btnImg,
    #shareLink {
        height: 24px;
        padding-top: 2px;
        padding-bottom: 6px;
    }*/
</style>

<!-- Input imageLink -->
<input type="text" spellcheck="false" value="" id="imageLink">

<!-- Controls-->
<div id="btnGroup" class="container-fluid row">

    <div class="col-3" id="myBtn">
        <button title="Previous image" onclick="$('#CarouselControl').carousel('prev');" style="border-right: none;">
            <img style="width:24px; height: 24px;" src="~/Content/XML/Svg/Site/Previous.svg" /> Previous
        </button>
    </div>

    <div class="col-3" id="myBtn">
        <button title="Copy Link to Clipboard" onclick="copyLink()" onmouseout="copyLinkOut()"><img style="width:26px; height:26px;" src="~/Content/XML/Svg/Site/Links.svg" /> Links
        </button>
    </div>

    <div class="col-3" id="myBtn">       

        <!-- How do we phrase this to still work and not complain about button inside <a></a>??? -->
        <a style="padding-top: 10px; font-size: 16px;" id="shareLink" href="" target="_blank" >
            <button title="Share on Facebook" type="submit" class="inlineBlock">
                <img style="width:26px; height: 26px;"src="~/Content/XML/Svg/Site/FB_Square.SVG" /> Share
            </button>
        </a>
    </div>

    <div Class="col-3" id="myBtn">
        <button title="Next image" onclick="$('#CarouselControl').carousel('next');" style="border-left: none;">
            Next <img style="width:24px; height: 24px;" src="~/Content/XML/Svg/Site/Next.SVG" />
        </button>
    </div>
</div>

<!-- Carousel for Picture slides -->
<div id="CarouselControl" Class="carousel slide" data-ride="carousel" data-interval="false">

    <!-- The slideshow -->
    <div Class="carousel-inner" id="CarouselItems" style="color: white;"></div>

    <!-- Left And right controls -->
    <a Class="carousel-control-prev" href="#CarouselControl" data-slide="prev"></a>
    <a Class="carousel-control-next" href="#CarouselControl" data-slide="next"></a>
</div>

<script>
    /* Create the Carousel Picture List */
    createImageList("@imageLocation", "@altText", @imageCount);
</script>

<script>

    /* Keep imageLink updated with current link */
    document.getElementById("imageLink").value = "@imageLocation" + ('000000' + @imageCount).slice(-6) + ".jpg";
    document.getElementById("shareLink").setAttribute("href", "https://facebook.com/sharer/sharer.php?u=http://mikish.com/Content/Images/Categories/@category/"+ ('000000' + @imageCount).slice(-6) + ".jpg");
    $("#CarouselControl").on('slide.bs.carousel', function (event) {
        document.getElementById("imageLink").value = "@imageLocation" + ('000000' + (@imageCount - event.to)).slice(-6) + ".jpg";
        document.getElementById("shareLink").setAttribute("href", "https://facebook.com/sharer/sharer.php?u=http://mikish.com/Content/Images/Categories/@category/" + ('000000' + (@imageCount - event.to)).slice(-6) + ".jpg");
    });
    $("CarouselControl").to;
</script>

<script>
    function copyLink() {
        document.getElementById("imageLink").autofocus = false;
        document.getElementById("imageLink").select();
        document.execCommand("copy");
        document.getElementById("imageLink").hideFocus = true;
        document.getElementById("myTooltip").innerHTML = "Copied"
    }

    function copyLinkOut() {
        document.getElementById("myTooltip").innerHTML = "Link";
    }
</script>

<script>
    $('#Previous').click(function (e) {
        e.stopPropagation();
        $('#CarouselControl').carousel('prev');
        return false;
    });
    $('#Next').click(function (e) {
        e.stopPropagation();
        $('#CarouselControl').carousel('prev');
        return false;
    });
    $('.carousel-control.left').click(function (e) {
        e.stopPropagation();
        $('#CarouselControl').carousel('prev');
        return false;
    });
    $('.carousel-control.right').click(function (e) {
        e.stopPropagation();
        $('#CarouselControl').carousel('next');
        return false;
    });
</script>