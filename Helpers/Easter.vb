Public Class Easter
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    '*****************
    '* GetEasterDate *
    '*****************
    '
    ' Returns the EventDate of the next Easter
    '
    <AllowAnonymous>
    Public Shared Function GetEasterDate() As Date

        Dim eventYear As Integer = Date.UtcNow.Year
        Dim eventDate = New DateTime(eventYear, 3, 1)
        Dim eventDay As Integer = (((255 - 11 * (eventYear Mod 19)) - 21) Mod 30) + 21

        eventDate = eventDate.AddDays(+eventDay + CInt((eventDay > 48)) + 6 - ((eventYear + eventYear \ 4 + eventDay + CInt((eventDay > 48)) + 1) Mod 7))

        If eventDate.AddDays(1) < Date.UtcNow Then

            eventYear = Date.UtcNow.Year + 1
            eventDate = New DateTime(eventYear, 3, 1)
            eventDay = (((255 - 11 * (eventYear Mod 19)) - 21) Mod 30) + 21

            eventDate = eventDate.AddDays(+eventDay + CInt((eventDay > 48)) + 6 - ((eventYear + eventYear \ 4 + eventDay + CInt((eventDay > 48)) + 1) Mod 7))

        End If

        Return (eventDate)

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