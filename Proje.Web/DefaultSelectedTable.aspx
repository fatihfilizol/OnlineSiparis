<%@ Page Title="" Language="C#" MasterPageFile="~/Fundamental.Master" AutoEventWireup="true" CodeBehind="DefaultSelectedTable.aspx.cs" Inherits="Proje.Web.DefaultSelectedTable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    Masa Numaranızı Seçin:<br />
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
                    <asp:HyperLink NavigateUrl='<%#"~/Default.aspx?Id=" + Eval("Id") %>' ID="HyperLink1" runat="server" CssClass="btn btn-warning"><%#Eval ("TableNumber") %></asp:HyperLink>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
