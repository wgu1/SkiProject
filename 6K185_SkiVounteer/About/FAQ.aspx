<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
        <div class="subMenu">
        <asp:Menu ID="AboutNavigation" runat="server" CssClass="aboutmenu" EnableViewState="false" IncludeStyleBlock="false" Orientation="vertical">
                    <Items>
                        <asp:MenuItem NavigateUrl="~/About/Default.aspx" Text="About"/>
                        <asp:MenuItem NavigateUrl="~/About/FAQ.aspx" Text="FAQ"/>             
                    </Items>
                </asp:Menu>
    </div>

    <div class="FAQcontent">
        <h2> FAQ </h2> 

        <p class="FAQ">
            Q: What is 2015 FIS Alpine World Ski Championships?</p>

        <p>A: The Alpine World Ski Championships are held every two years and organized by the International Ski Federation, commonly known as FIS. The first championship was held in 1931 in Switzerland. The championships were held here in Vail/Beaver Creek in 1989 and 1999. The
2015 Event will be the 43rd championship and only the 6th championship held in North America.
After the Olympics, this is the largest skiing competition in the world. Athletes from over 70 nations will participate in races over the 2 week period.</p>

<p class="FAQ">Q: Who is running the event?</p>

<p>A: The Vail Valley Foundation is a non-profit organization that is responsible for enhancing and sustaining the Vail Valley through arts, athletics, and education programs.</p>

<p class="FAQ">Q: How many hours are required to volunteer?</p>

<p>A: Each volunteer needs to commit to a minimum of 60 hours during the championships.</p>

<p class="FAQ">Q: What are the benefits of volunteering?</p>

<p>A: You will receive a complete uniform, which includes a winter jacket and snow pants, invites for fun volunteer parties, one free meal per shift, making friends with people from all over the world, being a part of an international event, and other great stuff!</p>

<p class="FAQ">Q: Where do I stay while volunteering?</p>

<p>A: We do expect you to find your own lodging. Some hotels will offer discounts in the Vail</p>
Valley.

<p class="FAQ">Q: What volunteer positions are there?</p>

<p>A: We have volunteer positions for everyone. Below is the list and description of all the volunteer positions. You will pick your top 3 choices when applying.</p>

<p class="FAQ">Q: Why do I need to complete a background check?</p>

<p>A: Since this is an international event, all volunteer applicants are required to have a background check.</p>

<p class="FAQ">Q: When will I find out if I was accepted?</p>

<p>A: We will start to announce the first roster of volunteers starting February 2nd, 2014. Thank you for being patient as we conduct interviews, background checks, and reference checks.</p>
    </div>
</asp:Content>

