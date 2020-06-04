Imports System.Xml

Public Class SiteHelpers
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    '********************
    '* GetImageLocation *
    '********************
    '
    <AllowAnonymous>
    Public Shared Function GetImageLocation() As String

        Dim localhost As String = "localhost"

        If RootUrl.Contains(localhost) Then
            Return "/Content/Images/"
        End If

        Return "http://Mikish.com/Content/Images/"

    End Function

    '***************
    '* GetSiteInfo *
    '***************
    '
    ' Get Site Info from SiteInfi.xml file
    '
    ' Some unique site info is stored in an xml file and the file used is determined by the RootURL().
    ' This is an easy way to make sites dynamic based on what web address is viewing the site.
    ' Pretty basic.
    '
    <AllowAnonymous>
    Public Shared Function GetSiteInfo(AttributeName As String) As String

        Dim siteURL As String = RootUrl()

        If siteURL.Contains("localhost") Then
            If AttributeName = "SiteName" Or AttributeName = "SiteDesigner" Then
                Return "Lake Catatoga"
            End If
            If AttributeName = "SiteURL" Or AttributeName = "SiteDesignerURL" Then
                Return "http://LakeCatatoga.com"
            End If
            If AttributeName = "SiteEmail_Sales" Then
                Return "MikishVaughn@Gmail.com"
            End If
            If AttributeName = "SiteEmail_Support" Then
                Return "MikishVaughn@Gmail.com"
            End If
            If AttributeName = "SiteFacebookPageURL" Then
                Return "https://Facebook.com/LakeCatatoga"
            End If
            If AttributeName = "SiteGoogleMapURL" Then
                Return "https://www.google.com/maps/dir//39.1879094,-89.9457662/@39.1860534,-89.9462016,1009m/data=!3m1!1e3"
            End If
            If AttributeName = "fbAdmins" Then
                Return "1521953211"
            End If
            If AttributeName = "fbAppID" Then
                Return "359284227593841"
            End If
            If AttributeName = "LinkShare" Then
                Return "http://mikish.com/Content/Images/Site/LinkShares/LakeCatatoga_Welcome_1200x630.jpg"
            End If
            If AttributeName = "SiteDescription" Then
                Return "This web site is dedicated to enjoying the Lake Catatoga life!"
            End If
        End If

        If siteURL.Contains("mikish.com") Or siteURL.Contains("bluesun.") Then
            If AttributeName = "SiteName" Or AttributeName = "SiteDesigner" Then
                Return "The Mikish Group"
            End If
            If AttributeName = "SiteURL" Or AttributeName = "SiteDesignerURL" Then
                Return "http://Mikish.com"
            End If
            If AttributeName = "SiteEmail_Sales" Then
                Return "MikishVaughn@Gmail.com"
            End If
            If AttributeName = "SiteEmail_Support" Then
                Return "MikishVaughn@Gmail.com"
            End If
            If AttributeName = "SiteFacebookPageURL" Then
                Return "https://Facebook.com/MikishGroup"
            End If
            If AttributeName = "SiteGoogleMapURL" Then
                Return "https://www.google.com/maps/dir//39.1879094,-89.9457662/@39.1860534,-89.9462016,1009m/data=!3m1!1e3"
            End If
            If AttributeName = "fbAdmins" Then
                Return "1521953211"
            End If
            If AttributeName = "fbAppID" Then
                Return "474665616014641"
            End If
            If AttributeName = "LinkShare" Then
                Return "http://mikish.com/Content/Images/Site/LinkShares/TheMikishGroup_Welcome_1200x630.jpg"
            End If
            If AttributeName = "SiteDescription" Then
                Return "This web site is dedicated to The Mikish Group!"
            End If
        End If

        If siteURL.Contains("scentme.com") Then
            If AttributeName = "SiteName" Or AttributeName = "SiteDesigner" Then
                Return "Scent Me"
            End If
            If AttributeName = "SiteURL" Or AttributeName = "SiteDesignerURL" Then
                Return "http://ScentMe.com"
            End If
            If AttributeName = "SiteEmail_Sales" Then
                Return "MikishVaughn@Gmail.com"
            End If
            If AttributeName = "SiteEmail_Support" Then
                Return "MikishVaughn@Gmail.com"
            End If
            If AttributeName = "SiteFacebookPageURL" Then
                Return "https://www.facebook.com/pages/Scent-Me/1640971506116388"
            End If
            If AttributeName = "SiteGoogleMapURL" Then
                Return "https://www.google.com/maps/dir//39.1879094,-89.9457662/@39.1860534,-89.9462016,1009m/data=!3m1!1e3"
            End If
            If AttributeName = "fbAdmins" Then
                Return "1521953211"
            End If
            If AttributeName = "fbAppID" Then
                Return "826152150794793"
            End If
            If AttributeName = "LinkShare" Then
                Return "http://mikish.com/Content/Images/Site/LinkShares/ScentMe_Welcome_1200x630.jpg"
            End If
            If AttributeName = "SiteDescription" Then
                Return "This web site is dedicated to enjoying the Scent of life!"
            End If
        End If

        If siteURL.Contains("lakecatatoga.com") Then
            If AttributeName = "SiteName" Or AttributeName = "SiteDesigner" Then
                Return "Lake Catatoga"
            End If
            If AttributeName = "SiteURL" Or AttributeName = "SiteDesignerURL" Then
                Return "http://LakeCatatoga.com"
            End If
            If AttributeName = "SiteEmail_Sales" Then
                Return "MikishVaughn@Gmail.com"
            End If
            If AttributeName = "SiteEmail_Support" Then
                Return "MikishVaughn@Gmail.com"
            End If
            If AttributeName = "SiteFacebookPageURL" Then
                Return "https://Facebook.com/LakeCatatoga"
            End If
            If AttributeName = "SiteGoogleMapURL" Then
                Return "https://www.google.com/maps/dir//39.1879094,-89.9457662/@39.1860534,-89.9462016,1009m/data=!3m1!1e3"
            End If
            If AttributeName = "fbAdmins" Then
                Return "1521953211"
            End If
            If AttributeName = "fbAppID" Then
                Return "359284227593841"
            End If
            If AttributeName = "LinkShare" Then
                Return "http://mikish.com/Content/Images/Site/LinkShares/LakeCatatoga_Welcome_1200x630.jpg"
            End If
            If AttributeName = "SiteDescription" Then
                Return "This web site is dedicated to enjoying the Lake Catatoga life!"
            End If
        End If

        If siteURL.Contains("illustrate.net") Then
            If AttributeName = "SiteName" Or AttributeName = "SiteDesigner" Then
                Return "Illustrate Net"
            End If
            If AttributeName = "SiteURL" Or AttributeName = "SiteDesignerURL" Then
                Return "http://Illustrate.net"
            End If
            If AttributeName = "SiteEmail_Sales" Then
                Return "MikishVaughn@Gmail.com"
            End If
            If AttributeName = "SiteEmail_Support" Then
                Return "MikishVaughn@Gmail.com"
            End If
            If AttributeName = "SiteFacebookPageURL" Then
                Return "https://Facebook.com/IllustrateNet"
            End If
            If AttributeName = "SiteGoogleMapURL" Then
                Return "https://www.google.com/maps/dir//39.1879094,-89.9457662/@39.1860534,-89.9462016,1009m/data=!3m1!1e3"
            End If
            If AttributeName = "fbAdmins" Then
                Return "1521953211"
            End If
            If AttributeName = "fbAppID" Then
                Return "1095905250426763"
            End If
            If AttributeName = "LinkShare" Then
                Return "http://mikish.com/Content/Images/Site/LinkShares/Illustrate_Welcome_1200x630.jpg"
            End If
            If AttributeName = "SiteDescription" Then
                Return "This web site is dedicated to enjoying the illustrations of life!"
            End If
        End If

        'If we make it here then there was a coding failure!
        Return "Oops!" ' :-(

    End Function

    '*************
    '* RootURL() *
    '*************
    '
    ' Used to return the Root URL to determine the site address and therefore identity.
    '
    <AllowAnonymous>
    Public Shared Function RootUrl()
        Return HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/")
    End Function

    '***************
    '* MaxImages() *
    '***************
    '
    <AllowAnonymous>
    Public Shared Function MaxImages(Msg As String) As Integer

        If Msg = "EventsMenu" Then
            Msg = "Countdowns"
        End If

        Try
            If SiteHelpers.RootUrl.Contains("localhost") Then
                Return IO.Directory.GetFiles("D:\Projects\Rpos\MyWebsite\Content\Images\Categories\" + Msg, "*.jpg").Length()
                'Return IO.Directory.GetFiles("D:\Projects\Rpos\MyWebsite\Content\Images\Categories\" + Msg, "*.jpg").Count()
            End If

            Return IO.Directory.GetFiles("D:\Hosting\10402494\html\Content\Images\Categories\" + Msg, "*.jpg").Length()

        Catch ex As Exception
            Return 30
            Throw
            'MsgBox("Image Directory Not Found", MsgBoxStyle.Critical)
        End Try

        Return 1

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