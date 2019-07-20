@code
    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim siteDesignerURL As String = SiteHelpers.GetSiteInfo("SiteDesignerURL")
    Dim siteDesigner As String = SiteHelpers.GetSiteInfo("SiteDesigner")
End Code

<style>
    #myBox {
        text-shadow: .5px .5px 0 black, -.5px -.5px 0 black, 0 0 3px gray;
    }
</style>

<!-- TOS Policy -->
<div style="color: white; margin-left: auto; margin-right: auto; text-align: center; max-width:90%;">

    <h1 id="myBox">Terms Of Service</h1>

    <!-- TOS Content -->
    <div style="padding: 5px; width: 100%; text-align: left;  color: white;">
        <div style="padding: 5px; width: 100%; text-align: left;">
            <p style="font-weight: 500; font-size: 18px; line-height: 22px;">
                By accessing this web site, you are agreeing to be bound by these
                web site Terms and Conditions of Use, all applicable laws and regulations,
                and agree that you are responsible for compliance with any applicable local
                laws. If you do not agree with any of these terms, you are prohibited from
                using or accessing this site. The materials contained in this web site are
                protected by applicable copyright and trade mark law.
            </p>
        </div>

        <div class="gradientheading">
            Use License
        </div>
        <div class="p_div">
            <ol type="a">
                <li>
                    Permission is granted to temporarily download one copy of the materials
                    (information or software) on @siteName's web site for personal,
                    non-commercial transitory viewing only. This is the grant of a license,
                    not a transfer of title, and under this license you may not:
                    <ol type="i">
                        <li>modify or copy the materials;</li>
                        <li>use the materials for any commercial purpose, or for any public display (commercial or non-commercial);</li>
                        <li>attempt to decompile or reverse engineer any software contained on @siteName's web site;</li>
                        <li>remove any copyright or other proprietary notations from the materials; or</li>
                        <li>transfer the materials to another person or "mirror" the materials on any other server.</li>
                    </ol>
                </li>
                <li>
                    This license shall automatically terminate if you violate any of these restrictions and may be terminated by @siteName at any time. Upon terminating your viewing of these materials or upon the termination of this license, you must destroy any downloaded materials in your possession whether in electronic or printed format.
                </li>
            </ol>
        </div>

        <div class="gradientheading">
            Disclaimer
        </div>
        <div class="p_div">
            <ol type="a">
                <li>
                    The materials on @siteName's web site are provided "as is". @siteName makes no warranties, expressed or implied, and hereby disclaims and negates all other warranties, including without limitation, implied warranties or conditions of merchantability, fitness for a particular purpose, or non-infringement of intellectual property or other violation of rights. Further, @siteName does not warrant or make any representations concerning the accuracy, likely results, or reliability of the use of the materials on its Internet web site or otherwise relating to such materials or on any sites linked to this site.
                </li>
            </ol>
        </div>

        <div class="gradientheading">
            Limitations
        </div>
        <div class="p_div">
            <p style="color: white;">
                In no event shall @siteName or its suppliers be liable for any damages (including, without limitation, damages for loss of data or profit, or due to business interruption,) arising out of the use or inability to use the materials on @siteName's Internet site, even if @siteName or a @siteName authorized representative has been notified orally or in writing of the possibility of such damage. Because some jurisdictions do not allow limitations on implied warranties, or limitations of liability for consequential or incidental damages, these limitations may not apply to you.
            </p>
        </div>

        <div class="gradientheading">
            Revisions and Errata
        </div>
        <div class="p_div">
            <p style="color: white;">
                The materials appearing on @siteName's web site could include technical, typographical, or photographic errors. @siteName does not warrant that any of the materials on its web site are accurate, complete, or current. @siteName may make changes to the materials contained on its web site at any time without notice. @siteName does not, however, make any commitment to update the materials.
            </p>
        </div>

        <div class="gradientheading">
            Links
        </div>
        <div class="p_div">
            <p style="color: white;">
                @siteName has not reviewed all of the sites linked to its Internet web site and is not responsible for the contents of any such linked site. The inclusion of any link does not imply endorsement by @siteName of the site. Use of any such linked web site is at the user's own risk.
            </p>
        </div>

        <div class="gradientheading">
            Site Terms of Use Modifications
        </div>
        <div class="p_div">
            <p style="color: white;">
                @siteName may revise these terms of use for its web site at any time without notice. By using this web site you are agreeing to be bound by the then current version of these Terms and Conditions of Use.
            </p>
        </div>

        <div class="gradientheading">
            Governing Law
        </div>
        <div class="p_div">
            <p style="color: white;">
                Any claim relating to @siteName's web site shall be governed by the laws of the State of Illinois without regard to its conflict of law provisions. General Terms and Conditions applicable to Use of a Web Site.
            </p>
        </div>
    </div>
</div>

<!-- Contact Info -->
@Html.Partial("_Contact")