<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UnitedWaySupressionContacts._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <p>
        &nbsp;Select Suppresions Needed</p>
    <asp:DropDownList cssclass="test"  ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="UWPC_TEST" DataTextField="Category" DataValueField="sid">
    </asp:DropDownList>
    <asp:SqlDataSource ID="UWPC_TEST" runat="server" ConnectionString="<%$ ConnectionStrings:UWPC_TestConnectionString %>" SelectCommand="SELECT * FROM [SupressionCategories] ORDER BY [sid]"></asp:SqlDataSource>
    <br />
    <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="SubCategoryListBox" DataTextField="SubCategory" DataValueField="ssid">
    </asp:CheckBoxList>
    <asp:SqlDataSource ID="SubCategoryListBox" runat="server" ConnectionString="<%$ ConnectionStrings:UWPC_TestConnectionString %>" SelectCommand="SELECT [ssid], [SubCategory] FROM [SupressionSubCategories] WHERE ([sid] = @sid)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="sid" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <br />
<br />
<asp:Button ID="Button1" runat="server" Text="Generate List" />
    <br />
<br />
</asp:Content>

