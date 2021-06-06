<%@ Page Title="" Language="C#" MasterPageFile="~/Fundamental.Master" AutoEventWireup="true" CodeBehind="DefaultAddOrder.aspx.cs" Inherits="Proje.Web.DefaultAddOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div style="text-align:center">
        Siparişiniz Oluşturuldu <br />

    </div>
        <asp:Repeater ID="Repeater1" runat="server">
           <ItemTemplate>
               <div style="text-align:center">
                    <asp:HyperLink NavigateUrl='<%#"~/Default.aspx?Id=" + Eval("Id") %>' ID="HyperLink1" runat="server" CssClass="btn btn-success"><i class="fa fa-home"></i> Menüye Dön</asp:HyperLink>
               </div>
           </ItemTemplate>
        </asp:Repeater>
    
    
</asp:Content>
