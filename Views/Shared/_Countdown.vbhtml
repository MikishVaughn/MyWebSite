@Code
    Dim backgroundImageUrl As String = SiteHelpers.GetImageLocation() + "Categories/Countdowns/" + ViewData("Message") + ".jpg"

    'Fix for spaces in Event names
    backgroundImageUrl = backgroundImageUrl.Replace(" ", "")

    Dim eventName As String = ViewData("Message")

    Dim eventDateCurrentYearString As String = Countdowns.GetEventUTCDateString(eventName, Date.Now.Year)
    Dim eventDateNextYearString As String = Countdowns.GetEventUTCDateString(eventName, Date.Now.Year + 1)

    ' Set eventType Flag and seasonType flags they need to be checked for the potential effects of DST
    Dim seasonType As Integer = 0
    Dim eventType As Integer = 0
    If (eventName = "Spring" Or
        eventName = "Summer" Or
        eventName = "Autumn" Or
        eventName = "Winter") Then
        ' Hours, minutes, and seconds are not at midnight.
        eventType = 1

        If (eventName = "Spring" Or
            eventName = "Summer" Or
            eventName = "Autumn") Then
            ' potentially within DST
            seasonType = 1

        End If

        ' Cosmetic Fix for Season Name(s)
        If eventName = "Autumn" Then
            eventName = "Autumn (Fall)"
        End If

    Else

        ' Cosmetic Fix for Holiday Names
        If eventName = "Valentines" Then
            eventName = "Valentine's Day"
        End If
        If eventName = "Mothers" Then
            eventName = "Mother's Day"
        End If
        If eventName = "Fathers" Then
            eventName = "Father's Day"
        End If
        If eventName = "MartinLutherKing" Then
            eventName = "Martin Luther King Jr"
        End If
        If eventName = "Presidents" Then
            eventName = "President's Day"
        End If
        If eventName = "Labor" Then
            eventName = "Labor Day"
        End If
        If eventName = "Veterans" Then
            eventName = "Veteran's Day"
        End If
        If eventName = "New Years" Then
            eventName = "New Year's Day"
        End If
        If eventName = "Independence" Then
            eventName = "Independence Day"
        End If
        If eventName = "Thanksgiving" Then
            eventName = "Thanksgiving Day"
        End If
        If eventName = "Elections" Then
            eventName = "Election Day"
        End If
        If eventName = "Memorial" Then
            eventName = "Memorial Day"
        End If
        If eventName = "Christmas" Then
            eventName = "Christmas Day"
        End If

        ' Cosmetic Fix for Birthday names
        If eventName = "Aleda" Then
            eventName = "Aleda's Birthday"
        End If
        If eventName = "April" Then
            eventName = "April's Birthday"
        End If
        If eventName = "Bridget" Then
            eventName = "Bridget's Birthday"
        End If
        If eventName = "Fred" Then
            eventName = "Fred's Birthday"
        End If
        If eventName = "Mary" Then
            eventName = "Mary's Birthday"
        End If
        If eventName = "Melissa" Then
            eventName = "Melissa's Birthday"
        End If
        If eventName = "Mike" Then
            eventName = "Mike's Birthday"
        End If
        If eventName = "PattyKake" Then
            eventName = "Patty Kake's Birthday"
        End If
        If eventName = "Steve" Then
            eventName = "Steve's Birthday"
        End If
        If eventName = "Tina" Then
            eventName = "Tina's Birthday"
        End If
        If eventName = "Terry" Then
            eventName = "Terry's Birthday"
        End If
        If eventName = "MikePinkerton" Then
            eventName = "Mike's Birthday"
        End If
        If eventName = "Lincoln" Then
            eventName = "Lincoln's Birthday"
        End If
        If eventName = "Washington" Then
            eventName = "Washington's Birthday"
        End If
        If eventName = "Jefferson" Then
            eventName = "Jefferson's Birthday"
        End If
        If eventName = "Army" Then
            eventName = "US Army's Birthday"
        End If
        If eventName = "AirForce" Then
            eventName = "US Air Force's Birthday"
        End If
        If eventName = "Navy" Then
            eventName = "US Navy's Birthday"
        End If
        If eventName = "MarineCorp" Then
            eventName = "US Marine Corp's Birthday"
        End If
        If eventName = "NationalGuard" Then
            eventName = "National Guard's Birthday"
        End If
        If eventName = "Patricia" Then
            eventName = "Patricia's Birthday"
        End If
        If eventName = "Heidi" Then
            eventName = "Heidi's Birthday"
        End If
        If eventName = "Stacy" Then
            eventName = "Stacy's Birthday"
        End If
        If eventName = "Legalization" Then
            eventName = "Cannabis in Illinois"
        End If
    End If

    Dim ExtraEffects As String = "_Nothing"
    If eventName = "Winter" Or eventName = "Christmas Day" Or eventName = "Autumn (Fall)" Or eventName = "Halloween" Or eventName = "Valentine's Day" Or eventName = "April's Birthday" Or eventName = "Easter" Or eventName = "Thanksgiving Day" Then
        ExtraEffects = "_ExtraEffects"
    End If

End Code

@Html.Partial(ExtraEffects)

<div id="countdownWindow" style="margin: 0; background-color: transparent; background-image: url('@backgroundImageUrl'); background-repeat: no-repeat; background-size: cover;">

        <!-- (Count) -->
        <div class="ctdwn" style="padding: 0; background-color: transparent;">

            <div id="whoKnows">
                <!-- Event Name -->
                <h2 id="EventName">@eventName</h2>
                
                <!-- Event Date -->
                <h6 id="EventDate"></h6>

                <!-- Days -->
                <h2 id="EventDays"></h2>
                <h6 id="lblEventDays"></h6>

                <!-- Hours, Minutes, and Seconds -->
                <div class="row">

                    <div class="col-4 center" style="min-width: 60px; text-align: center;">
                        <h4 id="EventHours"></h4>
                        <h6 id="lblEventHours"></h6>
                    </div>
                    <div class="col-4 center" style="min-width: 60px; text-align: center;">
                        <h4 id="EventMinutes"></h4>
                        <h6 id="lblEventMinutes"></h6>
                    </div>
                    <div class="col-4 center" style="min-width: 60px; text-align: center;">
                        <h4 id="EventSeconds"></h4>
                        <h6 id="lblEventSeconds"></h6>
                    </div>
                </div>
            </div>
    </div>
    <div id="countdownWindowPadding">
    </div>
</div>

<script src="~/Scripts/sitescripts.js"></script>
<script>

    // Constant calculated now so that it is not redundantly recalculated in functions.
    const eventType = @eventType; // 0 = Holiday, 1 = Season.
    const seasonType = @seasonType; // 0 = Winter, 1 = Spring, Summer, or Autumn.    
    const adjustDst = DstOffset(); // 0 = no adjustment, 1 = adjust by one hour

    // Get the Event Date (get next year's Event Date if the Event Date is past the current date).
    const eventDate = (Number((new Date(Date.parse('@eventDateCurrentYearString'))).getTime()) > Number(new Date().getTime())) ?
        (new Date(Date.parse('@eventDateCurrentYearString'))) :
        (new Date(Date.parse('@eventDateNextYearString')));     

    // Update the Countdown for the first time, then run at interval every second.
    updateCountdown(new Date(), eventDate, eventType, seasonType, adjustDst);

    setInterval(function () { updateCountdown(new Date(), eventDate, eventType, seasonType, adjustDst) }, 1000);

</script>

