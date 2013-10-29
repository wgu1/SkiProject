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

    <div class="Aboutcontent">
        <h2> 2015 Vail Beaver Creek Organizing Committee </h2> <br />
        <h4>Executive Committee</h4>
        <p>Ceil Folz, President<br /> 
            Erik Borgen<br />
            Bill Esrey<br />
            Harry Frampton<br />
            John Garnsey<br />
            George Gillett<br />
            Michael Imhof<br />
            Bill Marolt<br />
            Steve McConahey<br />
            Dexter Paine<br />
            Eric Resnick  </p>

        <h4>Coordination Committee </h4>
        <p>Ingo Hannesson, EBU<br />
            Sarah Lewis, FIS<br />
            Christian Pirzer, Tridem<br />
            Host Broadcaster</p>
        
        <h4>Advisory Committee</h4>
        <p>Mike Balk, BCMD<br />
            Michael Berry, NSAA<br />
            Dick Coe, USSA<br />
            Andrew Judelson, USSA<br />
            Mark Fenstermacher, VVF CFO<br />
            Patrik Jaerbyn, Athlete Rep<br />
            Doug Lovell, VRI<br />
            Aldo Radamus, SSCV<br />
            Stan Zemler, TOV<br />
            Tim Baker, BCRC<br />
            Keith Montag, ECG<br />
            Dave Ingemie, Snow Sports<br />
            Larry Brooks, TOA<br />
            US Forest Service<br />
        </p>

        <h4>2015 OPERATIONS COMMITTEES</h4>
        <p>Administration Committee Roger Behler<br />
            Ceremonies Committee Jenn Bruno<br />
            Communications/Technology Committee Robert Urwiler<br />
            Culture Committee Damian Woetzel<br />
            Donors Committee Lucy Davis<br />
            Environment Committee Markian Feduschak<br />
            Facilities Committee Chupa Nelson<br />
            Festival Committee Susie Tjossem<br />
            Hospitality Committee Brian Nolan<br />
            Legacy Committee Harry Frampton<br />
            Lodging Committee Johannes Faessler<br />
            Marketing Committee Chris Jarnot<br />
            Medical Committee Jack Eck<br />
            Municipal Services Committee Bill Simmons<br />
            Race Committee Greg Johnson<br />
            Security Committee Dwight Henninger<br />
            Social Committee Susan Frampton<br />
            Television Committee Ken Schanzer<br />
            Volunteers Committee Cheryl Jensen<br />
            Youth Committee Margie Gart</p>
    </div>

</asp:Content>

