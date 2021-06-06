<%@ Page Title="" Language="C#" MasterPageFile="~/Fundamental.Master" AutoEventWireup="true" CodeBehind="DefaultSelectedTable.aspx.cs" Inherits="Proje.Web.DefaultSelectedTable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div style="text-align:center">
        Masa Numaranızı Seçin<br />
        <br />
     </div>
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <div style="text-align:center">
                    <asp:HyperLink NavigateUrl='<%#"~/Default.aspx?Id=" + Eval("Id") %>' ID="HyperLink1" runat="server" CssClass="btn btn-success tablenumber"><i class="fa fa-coffee"></i><br /><%#Eval ("TableNumber") %></asp:HyperLink>
                <br />
                <br />
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
