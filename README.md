# WebApp
VB MVC Website with some basic features fitting multiple screen sizes...phones, tablets, and desktops.

This is a complete working Visual Basic MVC Bootstrap 4 Website (minus Package files). 

The Site's personality features such as site name and email contact addresses, along with url links are kept in an xml info file called "SiteInfo.xml" under the Contents subfolder. 

This framework can be published to multiple sites with very little change by having the SiteHelper.GetSiteInfo() function check whether to use alternate site info files based on the *current URL*. The alternate name format for the siteinfo files would be, "{sitename-}SiteInfo.xml". To add new sites using new info files, the GetSiteInfo function must be manually edited (simple edits). The function is located in the class file SiteHelpers, which is located in the subfolder, "Helpers".

Other enhancements to the site include custom use of the Bootstrap 4 Carousel where a Javascript counts the number of files in the target image dirctory and self-creates the needed image list. The images must be incrementally named "000001.jpg, 000002.jpg, 000003.jpg" and files with square ratios work best overall. This allows adding new images to the different image folders and them automatically showing up in the carousel image list...(an easy way to add more images without ANY code changes). The JavaScript file containing all the site's js functions (the ones not written at the page level) is located in the "Scripts" subfolder and is called, "SiteScripts".

Another addition to this site are the "Event Countdowns". This is 'Date and Time' playtime involving several confusing steps to return the correct countdown to the selected event in Days and Hours relivent to the viewer's time zone including accounting for DST (Daylight Savings Time) where applicable. 

There are VB functions to return the Equinoxes and Solstices using equations based on the work of Jean Meeus in the book, Astronomical Algorithms, Chapter 26. Equinoxes and Solstices. Also, a function to calculate and return the next date of Easter. These functions eliminate the need for lookup tables for both Seasons and Easter. There are also funtions for returning other types of floating event dates such as an event falling on the third Sunday of a month. The dates of ALL events are calculated rather than using lookup tables other than those falling on the same day annually, which are just hard coded in as needed.

For the most part, this site fits well on Desktops, Tablets, and Phones; that's the goal and epic battle with the "Site.css" file, where much of the site's .css is stored, though there are also places where formatting is inline, or included in a <style> section of a page piece.

We are trying to simplify and automate, along with improve...and this is the current starting point left over from prior work. It can currently be published to our four different GoDaddy sites Those sites are, Mikish.com, ScentMe.com. Illustrate.Net, and LakeCatatoga.com. Checks modify the content based on the Sitename, which is retrieved from the page's URL upon loading. 

One note... for the SiteHelpers.MaxImage() function to work correctly, the function needs a hard path to the directory containing the images to be counted. It points to our local project image folder, but must point to the Web server's hard drive and image location when published in order to count the files in the target catagory directory correctly.

This code is an example of what is needed for the site(s) to point to the correct directories both local and on GoDaddy and is located in "_Pictures.vbhtml":

	' GoDaddy Image location
    Dim maxImages As Integer = IO.Directory.GetFiles("D:\Hosting\10402494\html\Content\Images\Categories\" + catagory, "*.jpg").Count()

    'Local Image Location
    If SiteHelpers.RootUrl.Contains("localhost") Then
        maxImages = IO.Directory.GetFiles("D:\Projects\WebApp\WebApp\WebApp\Content\Images\Categories\" + catagory, "*.jpg").Count()
    End If  
