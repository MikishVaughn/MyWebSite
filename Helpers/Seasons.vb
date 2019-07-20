Imports System.Math

Public Class Seasons
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    '**********************
    '* GetUtcSeasonDate() *
    '**********************
    '
    ' Calculate and return the Equinox and Solstices Dates closely duplicating the
    ' equations from the infamous Jean Meeus' book, "Astronomical Algorithms",
    ' Chapter 26, "Equinoxes and Solstices".
    '
    ' I've tried to stay true to the book equations, variables, and variable names where possible
    ' but also added a tzOffset (Time zone Offset) field for flexibility. There is an abundance
    ' of parenthesis in overkill to help visualize the equation logic.
    '
    ' Inputs: season, targetYear, tzOffset
    '
    '           season: String containing one of the following Seasons:
    '             "Spring", "Summer", "Autumn", or "Winter". Default = "Spring".
    '           targetYear: 4 digit Integer of the year of the 'Season Date' sought.
    '           tz_Offset: Time zone Offset desired.
    '
    ' Output: Date of the target season, year, and time zone offset.
    '
    '           The date and time of the start of the {Season} passed for the {Year}
    '           adjusted for the Time zone Offset {tzOffset}
    '
    ' Examples: GetUtcSeasonDate({Season}, {targetYear}, {tzOffset})
    '
    '     GetUtcSeasonDate("spring", 2018, -1)
    '     GetUtcSeasonDate("Winter", 2021, -7)
    '
    Public Shared Function GetUtcSeasonDate(season As String, targetYear As Integer, tzOffset As Integer) As Date

        ' Define variables for the raised the power of the year Y, Y², Y³, Y⁴
        ' Used in the Table 24.B Region
        Dim Y As Double = (targetYear - 2000) / 1000
        Dim Y2 As Double = Y * Y
        Dim Y3 As Double = Y2 * Y
        Dim Y4 As Double = Y3 * Y

        ' Chapter 26 page 166 Table 26.B
        '[Page 165](http://Mikish.com/Content/Images/Categories/JeanMeeus/000002.jpg)
        '
        ' For the years +1000 to +3000
        ' (use Table  26.A for -1000 to +1000)

        ' March Equinox (Spring) is Default Season
        Dim JDE As Double = 2451623.80984 + (365242.37404 * Y) + (0.05169 * Y2) - (0.00411 * Y3) - (0.00057 * Y4)
        Select Case LCase(season)
            Case "summer" ' June Solstice (Summer)
                JDE = 2451716.56767 + (365241.62603 * Y) + (0.00325 * Y2) + (0.00888 * Y3) - (0.0003 * Y4)
            Case "autumn" ' September Equinox (Autumn)
                JDE = 2451810.21715 + (365242.01767 * Y) - (0.11575 * Y2) + (0.00337 * Y3) + (0.00078 * Y4)
            Case "winter" ' December Solstice (Winter)
                JDE = 2451900.05952 + (365242.74049 * Y) - (0.06223 * Y2) - (0.00823 * Y3) + (0.00032 * Y4)
        End Select

        ' Chapter 26 page 167 Table 26.C
        '[Page 165](http://Mikish.com/Content/Images/Categories/JeanMeeus/000003.jpg)
        '
        ' Periodic Term array used below to find the sum 'S' for calculating the 'mean' Equinox or Solstice.
        Dim A As Double() = {485, 203, 199, 182, 156, 136, 77, 74, 70, 58, 52, 50, 45, 44, 29, 18, 17, 16, 14, 12, 12, 12, 9, 8}
        Dim B As Double() = {324.96, 337.23, 342.08, 27.85, 73.14, 171.52, 222.54, 296.72, 243.58, 119.81, 297.17, 21.02, 247.54, 325.15, 60.93, 155.12, 288.79, 198.04, 199.76, 95.39, 287.11, 320.81, 227.73, 15.45}
        Dim C As Double() = {1934.136, 32964.467, 20.186, 445267.112, 45036.886, 22518.443, 65928.934, 3034.906, 9037.513, 33718.147, 150.678, 2281.226, 29929.562, 31555.956, 4443.417, 67555.328, 4562.452, 62894.029, 31436.921, 14577.848, 31931.756, 34777.259, 1222.114, 16859.074}

        ' Define 'T', 'W'  and 'Δλ' variable using equation from page 165.
        '[Page 165](http://Mikish.com/Content/Images/Categories/JeanMeeus/000001.jpg)
        '
        Dim T As Double = (JDE - 2451545.0) / 36525
        Dim W As Double = 35999.373 * T - 2.47
        Dim Δλ As Double = 1 + 0.0334 * Cos(((W * PI) / 180)) + 0.0007 * Cos(2 * ((W * PI) / 180))

        ' S will hold the Equinox or Solstice Periodic Term sum after loop through the Terms arrays.
        ' i is the count iteration when reading the 24 A, B, and C Periotic Terms from the Table 26.C array data
        Dim S As Double = 0
        Dim i As Integer = 0

        ' Loop through and add up the Periodic Terms.
        For count = i To 23

            ' The Periodic Term equation on page 165 and 167 is:
            ' "S = ∑ A Cos(B + C * T)" Meaning the array of 0-23 terms are summed to S to calculate a 'mean'.
            ' NOTE: The argument for Cos() is given in degrees needing the "(({arg}* PI) / 180)" conversions.
            'S = S + (A(i) * Cos(((B(i) * PI) / 180) + (((C(i) * PI) / 180) * T)))
            S += (A(i) * Cos(((B(i) * PI) / 180) + (((C(i) * PI) / 180) * T)))
            i += 1

        Next

        ' Now we have the sum S of the Equinox or Solstice Periodic Terms and can continue.

        ' Adjustment for Time zone Offset
        Dim tzAdustment = ((tzOffset + 1) / 24)

        ' JDE equation on page 167.
        '[Page 167](http://Mikish.com/Content/Images/Categories/JeanMeeus/000003.jpg)
        '
        ' Note: "2415019 + 0.5" = Start of Julian Century
        JDE = JDE - 2415019 + 0.5 + ((0.00001 * S) / Δλ) + tzAdustment

        ' Convert from Julian and return Season Date.
        Return Date.FromOADate(JDE)

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