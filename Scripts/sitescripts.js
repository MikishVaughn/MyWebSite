// ********************************************* //
// *** Functions used to calculate countdown *** //
// ********************************************* //

// Determine if year is a leap year
function leapYear(year) {
    return year % 4 === 0 && year % 100 !== 0 || year % 400 === 0;
}

// Update the Countdown function
function updateCountdown(now, eventDate, eventType, seasonType, adjustDst) {    

    // Check if this is the Event Date.
    if (eventDate.getMonth() === now.getMonth() && eventDate.getDate() === now.getDate()) {
       
        // *** Today is the Event Day! ***//

        //  Update eventDate Display
        document.getElementById("EventDate").innerHTML = now.toString().substring(0, 15);

        // Update Countdown Display
        document.getElementById("EventDays").innerHTML = "<br />";
        document.getElementById("lblEventDays").innerHTML = "Today!";
        document.getElementById("EventHours").innerHTML = "<br />";
        document.getElementById("lblEventHours").innerHTML = "<br />";
        document.getElementById("EventMinutes").innerHTML = "";
        document.getElementById("lblEventMinutes").innerHTML = "";
        document.getElementById("EventSeconds").innerHTML = "";
        document.getElementById("lblEventSeconds").innerHTML = "";
    }
    else
    {
        // If we have passed the old eventDate then refresh the Page to get next year's eventDate.
        if (eventDate.getTime() < new Date().getTime()) location.reload();

        // Get the new Count numbers
        var d, h, m, s;
        d = Number(DateDiff('d', now, eventDate));
        h = Number(DateDiff('h', now, eventDate));
        m = Number(DateDiff('m', now, eventDate));
        s = Number(DateDiff('s', now, eventDate));

        // Update eventDate Display. Holiday needs different formatting (eventType === 0).
        document.getElementById("EventDate").innerHTML = eventType === 0 ? eventDate.toUTCString().substring(0, 16) : eventDate.toLocaleString();

        // Update Countdown Display
        document.getElementById("EventDays").innerHTML = d > 1 ? d : d > 0 ? d : "<br />";
        document.getElementById("lblEventDays").innerHTML = d > 1 ? "Days" : d > 0 ? "Day" : "in";
        document.getElementById("EventHours").innerHTML = h > 1 ? h : h > 0 ? h : "";
        document.getElementById("lblEventHours").innerHTML = h > 1 ? "Hours" : h > 0 ? "Hour" : "";
        document.getElementById("EventMinutes").innerHTML = m > 1 ? m : m > 0 ? m : "";
        document.getElementById("lblEventMinutes").innerHTML = m > 1 ? "Minutes" : m > 0 ? "Minute" : "";
        document.getElementById("EventSeconds").innerHTML = s > 1 ? s : s > 0 ? s : "0";
        document.getElementById("lblEventSeconds").innerHTML = s > 1 ? "Seconds" : s > 0 ? "Second" : "Seconds";
    }
}

// Returns the difference between two dates as needed.
function DateDiff(datePart, fromDate, toDate) {

    // Milliseconds.
    const one_day = 86400000;
    const one_hour = 3600000;
    const one_minute = 60000;
    const one_second = 1000;

    var diffMS = toDate.getTime() - fromDate.getTime();

    // Season Hour Adjustment for DST.
    if (Number(adjustDst) === Number(seasonType)) { diffMS = diffMS + one_hour; }

    // Kludge: Why do I have to subtract two hours to the diffMS to get the Days to change at Midnight?
    //var d = eventType === 0 ? Math.floor((diffMS /*- one_hour * 2*/) / one_day) : Math.floor(diffMS / one_day);
    var d = eventType === 0 ? Math.floor(diffMS / one_day) : Math.floor(diffMS / one_day);

    var h = eventType === 0 ? 23 - fromDate.getHours() : Math.floor((diffMS - d * one_day) / one_hour);
    var m = eventType === 0 ? 59 - fromDate.getMinutes() : Math.floor((diffMS - (d * one_day + h * one_hour)) / one_minute);
    var s = eventType === 0 ? 59 - fromDate.getSeconds() : Math.floor((diffMS - (d * one_day + h * one_hour + m * one_minute)) / one_second);

    var part = { d: d, h: h, m: m, s: s };

    return part[datePart];
}

Date.prototype.stdTimezoneOffset = function () {
    var jan = new Date(this.getFullYear(), 0, 1);
    var jul = new Date(this.getFullYear(), 6, 1);
    return Math.max(jan.getTimezoneOffset(), jul.getTimezoneOffset());
};

Date.prototype.dst = function () {
    return this.getTimezoneOffset() < this.stdTimezoneOffset();
};

function DstOffset() {
    var date = new Date();
    var offset = 1;

    if (date.dst())
        offset = 0;

    return offset;
}

// ************************************************* //
// *** Function used to open Web Page in new Tab  ** //
// ************************************************* //

function newTab(tabURL) {
    var newWindowTab = window.open(tabURL);
}

// ****************************************** //
// *** Create Image List of Carousel Items ** //
// ****************************************** //

function createImageList(imageLocation, altText, imageCount) {
    altText = "";
    var i = imageCount;
    var text = "<div class='carousel-item active'><img src='" + imageLocation.concat("000000".concat(i).slice(-6)) + ".jpg' alt='" + altText.concat("000000".concat(imageCount).slice(-6)) + "' /></img></div>";
    i--;
    while (i > 0) {
        text += "<div class='carousel-item'><img src='" + imageLocation.concat("000000".concat(i).slice(-6)) + ".jpg' alt='" + altText.concat("000000".concat(i).slice(-6)) + "' /></img></div>";
        i--;
    }
    document.getElementById("CarouselItems").innerHTML = text;
}

/**********************/
/* Change background **/
/**********************/

function changeBackground(newBackground) {
    $('body').css('background-image', newBackground);
}

 
