@code
End Code

<menu id="site-menu" class="site-menu" role="contentinfo" aria-label="Site menu" style="padding-left: 10px; padding-top:20px; margin: 0;">
    <div class="site-menu__module-group" data-metrics-category="Page Menu" data-metrics-label="Menu">

        <div class="countdowns-menu__module">
            <h6 class="countdowns-menu__header">Seasons</h6>
            <ul>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Spring">Spring</a></li>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Summer">Summer</a></li>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Autumn">Autumn</a></li>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Winter">Winter</a></li>
            </ul>
            <br />
            <h6 class="countdowns-menu__header">Birthdays</h6>
            <ul>
                <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Army">US Army</a></li>
                <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Navy">Navy</a></li>
                <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/AirForce">Air Force</a></li>
                <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/MarineCorp">Marine Corps</a></li>
                <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/NationalGuard">National Guard</a></li>
                <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Jefferson">Jefferson</a></li>
                <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Lincoln">Lincoln</a></li>
                <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Washington">Washington</a></li>
            </ul>
        </div>

        <div class="countdowns-menu__module">
            <h6 class="countdowns-menu__header">Holidays</h6>
            <ul>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/NewYears">New Year's</a></li>                
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Legalization">Legalization</a></li>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/MartinLutherKing">M.L. King Jr</a></li>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Valentines">Valentine Day</a></li>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Presidents">President Day</a></li>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Easter">Easter</a></li>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Mothers">Mother's Day</a></li>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Memorial">Memorial Day</a></li>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Fathers">Father's Day</a></li>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Independence">Independence</a></li>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Labor">Labor Day</a></li>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Veterans">Veteran's Day</a></li>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Elections">Election Day</a></li>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Thanksgiving">Thanksgiving</a></li>
                <li class="countdowns-menu__item"><a class="nav-link" href="~/countdowns/Christmas">Christmas</a></li>
            </ul>
        </div>

        <div class="countdowns-menu__module">
            @If Request.IsAuthenticated Then
            @Html.AntiForgeryToken()
            @<h6 class="countdowns-menu__header">Friend Birthdays</h6>
            @<ul>
            <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Aleda">Aleda (Mom)</a></li>
            <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/April">April</a></li>
            <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Bridget">Bridget</a></li>
            <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Fred">Fred</a></li>
            <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Heidi">Heidi</a></li>
            <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Mary">Mary</a></li>
            <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Melissa">Melissa</a></li>
            <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Mike">Mikish</a></li>
            <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/PattyKake">Patty Kake</a></li>
            <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Patricia">Patricia</a></li>
            <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Stacy">Stacy</a></li>
            <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Steve">Steve</a></li>
            <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Tina">Tina</a></li>
            <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Terry">Terry</a></li>
            <li class="countdowns-menu__item"><a Class="nav-link" href="~/countdowns/Terry">MikePinkerton</a></li>
</ul>
        End If
        </div>
    </div>
</menu>