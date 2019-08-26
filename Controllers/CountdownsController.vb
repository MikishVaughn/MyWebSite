Public Class CountdownsController
    Inherits Controller

    ' Countdowns
    <HttpGet>
    Function EventsMenu() As ActionResult
        ViewData("Message") = "EventsMenu"
        ViewData("PageHeader") = "Events Menu"
        Return View()
    End Function

    ' Season Countdowns
    <HttpGet>
    Function Spring() As ActionResult
        ViewData("Message") = "Spring"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Summer() As ActionResult
        ViewData("Message") = "Summer"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Autumn() As ActionResult
        ViewData("Message") = "Autumn"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Winter() As ActionResult
        ViewData("Message") = "Winter"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    ' Birthdays
    <HttpGet>
    Function Aleda() As ActionResult
        ViewData("Message") = "Aleda"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function April() As ActionResult
        ViewData("Message") = "April"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Melissa() As ActionResult
        ViewData("Message") = "Melissa"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Bridget() As ActionResult
        ViewData("Message") = "Bridget"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Tina() As ActionResult
        ViewData("Message") = "Tina"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Terry() As ActionResult
        ViewData("Message") = "Terry"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Mary() As ActionResult
        ViewData("Message") = "Mary"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function PattyKake() As ActionResult
        ViewData("Message") = "PattyKake"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Steve() As ActionResult
        ViewData("Message") = "Steve"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Fred() As ActionResult
        ViewData("Message") = "Fred"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Mike() As ActionResult
        ViewData("Message") = "Mike"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    ' Holidays
    <HttpGet>
    Function NewYears() As ActionResult
        ViewData("Message") = "New Years"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Legalization() As ActionResult
        ViewData("Message") = "Legalization"
        ViewData("PageHeader") = "Cannabis in Illinois"
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Valentines() As ActionResult
        ViewData("Message") = "Valentines"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Easter() As ActionResult
        ViewData("Message") = "Easter"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Mothers() As ActionResult
        ViewData("Message") = "Mothers"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Memorial() As ActionResult
        ViewData("Message") = "Memorial"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Independence() As ActionResult
        ViewData("Message") = "Independence"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Labor() As ActionResult
        ViewData("Message") = "Labor"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Veterans() As ActionResult
        ViewData("Message") = "Veterans"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Halloween() As ActionResult
        ViewData("Message") = "Halloween"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Elections() As ActionResult
        ViewData("Message") = "Elections"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Christmas() As ActionResult
        ViewData("Message") = "Christmas"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Thanksgiving() As ActionResult
        ViewData("Message") = "Thanksgiving"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function MartinLutherKing() As ActionResult
        ViewData("Message") = "MartinLutherKing"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Fathers() As ActionResult
        ViewData("Message") = "Fathers"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Presidents() As ActionResult
        ViewData("Message") = "Presidents"
        ViewData("PageHeader") = "Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Lincoln() As ActionResult
        ViewData("Message") = "Lincoln"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Washington() As ActionResult
        ViewData("Message") = "Washington"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Jefferson() As ActionResult
        ViewData("Message") = "Jefferson"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Army() As ActionResult
        ViewData("Message") = "Army"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function AirForce() As ActionResult
        ViewData("Message") = "AirForce"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Navy() As ActionResult
        ViewData("Message") = "Navy"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function MarineCorp() As ActionResult
        ViewData("Message") = "MarineCorp"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function NationalGuard() As ActionResult
        ViewData("Message") = "NationalGuard"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Patricia() As ActionResult
        ViewData("Message") = "Patricia"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Heidi() As ActionResult
        ViewData("Message") = "Heidi"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

    <HttpGet>
    Function Stacy() As ActionResult
        ViewData("Message") = "Stacy"
        ViewData("PageHeader") = "Birthday Countdown..."
        Return View("_Countdown")
    End Function

End Class