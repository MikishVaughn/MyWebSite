@code
    Dim catagory As String = ViewData("message")
    Dim maxImages As Integer
    Try
        maxImages = IO.Directory.GetFiles("D:\Hosting\10402494\html\Content\Images\Catagories\Countdown", "*.jpg").Count()
    Catch ex As Exception
        maxImages = 0
    End Try

End Code

<h2>Calendar Countdowns</h2>
<hr />
<br />
<p style="color: black;">
    A collection of @maxImages Calendar Countdowns including Seasons, Holidays, and Birthdays (not all are menu selections).
</p>
<br />
<hr />