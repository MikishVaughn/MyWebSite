Imports WebApp.Easter
Imports WebApp.Seasons

<AllowAnonymous>
Public Class Countdowns
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    '***************************
    '* GetEventUTCDateString() *
    '***************************
    '
    ' Main Function to return an EventDate. It calls
    ' other functions To Get the EventDate requested.
    '
    ' Input:
    '   eventName = String of EventName (Hope it is valid)
    '   eventYear = the target year of the requested EventDate.
    '
    ' Output Utc EventDate String
    '
    <AllowAnonymous>
    Public Shared Function GetEventUTCDateString(ByVal eventName As String, ByVal eventYear As Integer) As String

        Dim UtcSeasonDate As Date
        Dim UtcSeasonDateString As String
        Dim tz_Offset As Integer = -1

        ' Seasons - (Date is Calculated)
        Select Case eventName
            Case "Spring"
                UtcSeasonDate = GetUtcSeasonDate("Spring", eventYear, tz_Offset)
                UtcSeasonDateString = CStr(UtcSeasonDate.Year) + "-" + Right("00" + CStr(UtcSeasonDate.Month), 2) + "-" + Right("00" + CStr(UtcSeasonDate.Day), 2) + "T" + Right("00" + CStr(UtcSeasonDate.Hour), 2) + ":" + Right("00" + CStr(UtcSeasonDate.Minute), 2) + ":" + Right("00" + CStr(UtcSeasonDate.Second), 2) + "Z"
                Return UtcSeasonDateString
            Case "Summer"
                UtcSeasonDate = GetUtcSeasonDate("Summer", eventYear, tz_Offset)
                UtcSeasonDateString = CStr(UtcSeasonDate.Year) + "-" + Right("00" + CStr(UtcSeasonDate.Month), 2) + "-" + Right("00" + CStr(UtcSeasonDate.Day), 2) + "T" + Right("00" + CStr(UtcSeasonDate.Hour), 2) + ":" + Right("00" + CStr(UtcSeasonDate.Minute), 2) + ":" + Right("00" + CStr(UtcSeasonDate.Second), 2) + "Z"
                Return UtcSeasonDateString
            Case "Autumn"
                UtcSeasonDate = GetUtcSeasonDate("Autumn", eventYear, tz_Offset)
                UtcSeasonDateString = CStr(UtcSeasonDate.Year) + "-" + Right("00" + CStr(UtcSeasonDate.Month), 2) + "-" + Right("00" + CStr(UtcSeasonDate.Day), 2) + "T" + Right("00" + CStr(UtcSeasonDate.Hour), 2) + ":" + Right("00" + CStr(UtcSeasonDate.Minute), 2) + ":" + Right("00" + CStr(UtcSeasonDate.Second), 2) + "Z"
                Return UtcSeasonDateString
            Case "Winter"
                UtcSeasonDate = GetUtcSeasonDate("Winter", eventYear, tz_Offset)
                UtcSeasonDateString = CStr(UtcSeasonDate.Year) + "-" + Right("00" + CStr(UtcSeasonDate.Month), 2) + "-" + Right("00" + CStr(UtcSeasonDate.Day), 2) + "T" + Right("00" + CStr(UtcSeasonDate.Hour), 2) + ":" + Right("00" + CStr(UtcSeasonDate.Minute), 2) + ":" + Right("00" + CStr(UtcSeasonDate.Second), 2) + "Z"
                Return UtcSeasonDateString
        End Select

        ' Holidays - (Date is Fixed)
        Select Case eventName
            Case "New Years"
                Return CStr(eventYear) + "-01-01T00:00:00"
            Case "Legalization"
                Return CStr(eventYear) + "-01-01T00:00:00"
            Case "Valentines"
                Return CStr(eventYear) + "-02-14T00:00:00"
            Case "Independence"
                Return CStr(eventYear) + "-07-04T00:00:00"
            Case "Veterans"
                Return CStr(eventYear) + "-11-11T00:00:00"
            Case "Halloween"
                Return CStr(eventYear) + "-10-31T00:00:00"
            Case "Elections"
                Return CStr(2020) + "-11-03T00:00:00"
            Case "Christmas"
                Return CStr(eventYear) + "-12-25T00:00:00"
        End Select

        ' Holidays - (Date is Calculated)
        Select Case eventName
            Case "Easter"
                Return CStr(GetEasterDate.Year) + "-" + Right("00" + CStr(GetEasterDate.Month), 2) + "-" + Right("00" + CStr(GetEasterDate.Day), 2) + "T00:00:00"
            Case "Mothers"
                Return GetEventDate(5, 2, 1) 'Month, Week, Day (Sun = 1)
            Case "Fathers"
                Return GetEventDate(6, 3, 1)
            Case "Memorial"
                Return GetEventDate(5, 4, 2)
            Case "Labor"
                Return GetEventDate(9, 1, 2)
            Case "Thanksgiving"
                Return GetEventDate(11, 4, 5)
            Case "MartinLutherKing"
                Return GetEventDate(1, 3, 2)
            Case "Presidents"
                Return GetEventDate(2, 3, 2)
        End Select

        ' Birthdays - Presidents - (Date is Fixed)
        Select Case eventName
            Case "Lincoln"
                Return CStr(eventYear) + "-02-12T00:00:00"
            Case "Washington"
                Return CStr(eventYear) + "-02-22T00:00:00"
            Case "Jefferson"
                Return CStr(eventYear) + "-04-13T00:00:00"
        End Select

        ' Birthdays - Military - (Date is Fixed)
        Select Case eventName
            Case "Army"
                Return CStr(eventYear) + "-06-14T00:00:00"
            Case "AirForce"
                Return CStr(eventYear) + "-09-18T00:00:00"
            Case "Navy"
                Return CStr(eventYear) + "-10-13T00:00:00"
            Case "MarineCorp"
                Return CStr(eventYear) + "-11-10T00:00:00"
            Case "NationalGuard"
                Return CStr(eventYear) + "-12-13T00:00:00"
        End Select

        ' Birthdays - Friends - (Date is Fixed)
        Select Case eventName
            Case "Aleda"
                Return CStr(eventYear) + "-10-01T00:00:00"
            Case "April"
                Return CStr(eventYear) + "-03-27T00:00:00"
            Case "Melissa"
                Return CStr(eventYear) + "-12-08T00:00:00"
            Case "Bridget"
                Return CStr(eventYear) + "-06-15T00:00:00"
            Case "PattyKake"
                Return CStr(eventYear) + "-06-24T00:00:00"
            Case "Tina"
                Return CStr(eventYear) + "-01-27T00:00:00"
            Case "Mary"
                Return CStr(eventYear) + "-02-18T00:00:00"
            Case "Mike"
                Return CStr(eventYear) + "-03-31T00:00:00"
            Case "Fred"
                Return CStr(eventYear) + "-05-04T00:00:00"
            Case "Steve"
                Return CStr(eventYear) + "-10-04T00:00:00"
            Case "Patricia"
                Return CStr(eventYear) + "-05-26T00:00:00"
            Case "Heidi"
                Return CStr(eventYear) + "-06-09T00:00:00"
            Case "Stacy"
                Return CStr(eventYear) + "-02-05T00:00:00"
            Case "Terry"
                Return CStr(eventYear) + "-09-22T00:00:00"

        End Select

        ' Return a default Date if target Date not found in .XML table (Shouldn't happen) '
        Return "2019-03-31T00:00:00" ' No Error Checking... :-(

    End Function

    '****************
    '* GetEventDate *
    '****************
    '
    ' Get EventDate String  (based on Month, Week, and Day of Event with 1 = Sunday)
    ' Handy for events falling on days like the second Tuesday of a Month.
    '
    ' Input:
    '   eventMonth = Month of the Event
    '   eventWeek = Week number of Event (ie. Event is in the third week of the month.)
    '   evenDay = Day of Event. Sunday = 1, Monday = 2,...
    '
    ' Output:
    '   EventDate
    '
    <AllowAnonymous>
    Public Shared Function GetEventDate(eventMonth As Integer, eventWeek As Integer, eventDay As Integer) As String
        Dim eventYear As Integer = Date.UtcNow.Year
        Dim wkday As Integer = Weekday(Date.Parse(CStr(eventYear) + "-" + CStr(eventMonth) + "-" + CStr(8 - eventDay), System.Globalization.CultureInfo.InvariantCulture))
        Dim eventDate As Date = Date.Parse(CStr(eventYear) + "-" + CStr(eventMonth) + "-" + CStr(1 + (7 * eventWeek) - wkday), System.Globalization.CultureInfo.InvariantCulture).ToUniversalTime


        If eventDate < Date.UtcNow Then
            eventYear = Date.UtcNow.Year + 1
            wkday = Weekday(Date.Parse(CStr(eventYear) + "-" + CStr(eventMonth) + "-" + CStr(8 - eventDay), System.Globalization.CultureInfo.InvariantCulture))
            eventDate = Date.Parse(CStr(eventYear) + "-" + CStr(eventMonth) + "-" + CStr(1 + (7 * eventWeek) - wkday), System.Globalization.CultureInfo.InvariantCulture).ToUniversalTime
        End If

        Return CStr(eventDate.Year) + "-" + Right("00" + CStr(eventDate.Month), 2) + "-" + Right("00" + CStr(eventDate.Day), 2) + "T00:00:00"

    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return MyBase.Equals(obj)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function
End Class