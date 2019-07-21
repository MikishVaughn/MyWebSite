Public Class ImagesController
    Inherits System.Web.Mvc.Controller

    <HttpGet>
    Function Humor() As ActionResult
        ViewData("Message") = "Humor"
        ViewData("PageHeader") = "Humor"
        ViewData("PageTitle") = ""
        Return View()
    End Function

    <HttpGet>
    Function Photos() As ActionResult
        ViewData("Message") = "Photos"
        ViewData("PageHeader") = "Photos"
        ViewData("PageTitle") = ""
        Return View()
    End Function

    <HttpGet>
    Function JeanMeeus() As ActionResult
        ViewData("Message") = "JeanMeeus"
        ViewData("PageHeader") = "JeanMeeus"
        ViewData("PageTitle") = "Jean Meeus"
        Return View("_Images")
    End Function

    <HttpGet>
    Function Wildlife() As ActionResult
        ViewData("Message") = "Wildlife"
        ViewData("PageHeader") = "Wildlife"
        ViewData("PageTitle") = "Wildlife"
        Return View("_Images")
    End Function

    <HttpGet>
    Function Fishing() As ActionResult
        ViewData("Message") = "Fishing"
        ViewData("PageHeader") = "Fishing"
        ViewData("PageTitle") = "Fishing"
        Return View("_Images")
    End Function

    <HttpGet>
    Function Sunsets() As ActionResult
        ViewData("Message") = "Sunsets"
        ViewData("PageHeader") = "Beautiful Sunsets"
        ViewData("PageTitle") = "Beautiful Sunsets"
        Return View("_Images")
    End Function

    <HttpGet>
    Function ScentMe() As ActionResult
        ViewData("Message") = "ScentMe"
        ViewData("PageHeader") = "Scent Me"
        ViewData("PageTitle") = "Scent Me"
        Return View("_Images")
    End Function

    <HttpGet>
    Function Political() As ActionResult
        ViewData("Message") = "Political"
        ViewData("PageHeader") = "Political Humor"
        ViewData("PageTitle") = "Political Humor"
        Return View("_Images")
    End Function

    <HttpGet>
    Function Memes() As ActionResult
        ViewData("Message") = "Memes"
        ViewData("PageHeader") = "Bridget's Memes"
        ViewData("PageTitle") = "Bridget's Memes"
        Return View("_Images")
    End Function

    <HttpGet>
    Function Cartoons() As ActionResult
        ViewData("Message") = "Cartoons"
        ViewData("PageHeader") = "Cartoons"
        ViewData("PageTitle") = "Cartoons"
        Return View("_Images")
    End Function

    <HttpGet>
    Function Jokes() As ActionResult
        ViewData("Message") = "Jokes"
        ViewData("PageHeader") = "Steve's Old Jokes Home"
        ViewData("PageTitle") = "Steve's Old Jokes Home"
        Return View("_Images")
    End Function

    <HttpGet>
    Function NSFW() As ActionResult
        ViewData("Message") = "NSFW"
        ViewData("PageHeader") = "NSFW Humor"
        ViewData("PageTitle") = "NSFW Humor"
        Return View("_Images")
    End Function

    <HttpGet>
    Function Totempole() As ActionResult
        ViewData("Message") = "Totempole"
        ViewData("PageHeader") = "Totem Poles"
        ViewData("PageTitle") = "Totem Poles"
        Return View("_Images")
    End Function

    <HttpGet>
    Function Snow1() As ActionResult
        ViewData("Message") = "Snow1"
        ViewData("PageHeader") = "Snow1"
        ViewData("PageTitle") = "Snow1"
        Return View()
    End Function

    <HttpGet>
    Function Snow2() As ActionResult
        ViewData("Message") = "Snow2"
        ViewData("PageHeader") = "Snow2"
        ViewData("PageTitle") = "Snow2"
        Return View()
    End Function

    <HttpGet>
    Function Snow3() As ActionResult
        ViewData("Message") = "Snow3"
        ViewData("PageHeader") = "Snow3"
        ViewData("PageTitle") = "Snow3"
        Return View()
    End Function

    <HttpGet>
    Function Snow4() As ActionResult
        ViewData("Message") = "Snow4"
        ViewData("PageHeader") = "Snow4"
        ViewData("PageTitle") = "Snow4"
        Return View()
    End Function

    <HttpGet>
    Function Snow5() As ActionResult
        ViewData("Message") = "Snow5"
        ViewData("PageHeader") = "Snow5"
        ViewData("PageTitle") = "Snow5"
        Return View()
    End Function

    <HttpGet>
    Function Election() As ActionResult
        ViewData("Message") = "Election"
        ViewData("PageHeader") = "Election"
        ViewData("PageTitle") = "Election"
        Return View()
    End Function

    <HttpGet>
    Function SvgFiles() As ActionResult
        ViewData("Message") = "SvgFiles"
        ViewData("PageHeader") = "Svg Files"
        ViewData("PageTitle") = "Svg Files"
        Return View()
    End Function
End Class