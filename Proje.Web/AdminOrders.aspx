<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminOrders.aspx.cs" Inherits="Proje.Web.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered">
        <tr>
            <th>SİPARİŞ ID</th>
            <th>ÜRÜN ADI</th>
            <th>MASA NUMARASI</th>
            <th>FİYAT</th>
            <th>SİPARİŞ DURUMU</th>
            <th>SİPARİŞ İPTAL</th>
            <th>DURUM GÜNCELLE</th>
            <th>ÖDEME AL</th>

        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Id") %></td>
                    <td><%#Eval("ProductName") %></td>
                    <td><%#Eval("TableNumber") %></td>
                    <td><%#Eval("Price") %></td>
                    <td><%#Eval("StatusName") %></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/AdminCancelOrder.aspx?Id=" + Eval("Id") %>' ID="HyperLink1" runat="server" CssClass="btn btn-warning">Sipariş İptal</asp:HyperLink></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/AdminUpdateStatusOrder.aspx?Id=" + Eval("Id") %>' ID="HyperLink2" runat="server" CssClass="btn btn-info">Durum Güncelle</asp:HyperLink></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/AdminPaymentOrder.aspx?Id=" + Eval("Id") %>' ID="HyperLink3" runat="server" CssClass="btn btn-danger">Ödeme Al</asp:HyperLink></td>


                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>
