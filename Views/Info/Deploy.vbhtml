@code
End Code

<style>

    #openTab {
        font-family: "Knockout 31 4r", HelveticaNeue-CondensedBold, Helvetica, Arial, sans-serif;
        font-size: 20px;
        font-weight: 400;
        letter-spacing: 1.08px;
        -webkit-font-smoothing: antialiased;
        margin: 0;
        padding: 8px 10px;
        width: auto;
        background-color: transparent;
        text-decoration: none;
        text-decoration-line: none;
        color: black;
        text-shadow: 0 0 1px burlywood;
        border: solid thin transparent;
        border-top-left-radius: 10px;
        border-top-right-radius: 10px;
        border-bottom-left-radius: 10px;
        border-bottom-right-radius: 10px;
        padding-left: 10px;
    }

        #openTab:hover,
        #openTab:focus {
            text-decoration: none;
            text-decoration-line: none;
            outline: none;
            color: white;
            text-shadow: 0 0 1px #602c06;
            background-color: burlywood;
            border: solid thin #602c06;
        }
</style>

<div id="site-menu" class="site-menu" role="contentinfo" aria-label="Site menu">

    <div class="goldGradient">
        <br />
        <h2 style="padding-left: 20px;">Deploy Test Applications<img style="width:80px; height: 80px;" src="~/Content/XML/Svg/Site/Links.svg" /></h2>
        <br />
    </div>

    <div class="site-menu__module-group" data-metrics-category="Page Menu" data-metrics-label="Menu" style="padding-left: 20px; padding-top: 15px;">
        <br />
        <div Class="links-menu__module">
            <h6 class="links-menu__header">Samsung TV Remote</h6>
            <br />

            <!-- ipRemote -->
            <h5 style="padding-left: 5px;"><b>App Name: </b></h5>
            <br />
            <h5 style="padding-left: 15px;">IP Remote</h5>
            <br />

            <!-- ipRemote.zip -->
            <h5 style="padding-left: 10px; padding-bottom:10px;"><b>File Name:</b></h5>
            <ul>
                <li class="links-menu__item" style="padding-left: 10px; padding-bottom: 5px;">
                    <a id="openTab" href="~/Content/Misc/ipRemote.zip">ipRemote.zip</a>
                    <p style="padding-top:8px; padding-left: 10px;">(Unzip file, execute ipRemote.exe)</p>
                </li>
            </ul>
            <ul>
                <li class="links-menu__item" style="padding-left: 10px; padding-bottom: 5px;">
                    <a id="openTab" href="~/Content/Misc/SamsungIPremote v.003b.zip">SamsungIPremote v.003b.zip</a>
                    <p style="padding-top:8px; padding-left: 10px;">(Unzip file in same directory as above, execute SamsungIPremote v.003b.exe)</p>
                </li>
            </ul>
        </div>
    </div>

</div>
