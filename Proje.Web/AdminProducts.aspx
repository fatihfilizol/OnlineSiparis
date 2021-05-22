<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminProducts.aspx.cs" Inherits="Proje.Web.AdminProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    <table class="table table-bordered">
        <tr>
            <th>ÜRÜN ID</th>
            <th>ÜRÜN ADI</th>
            <th>KATEGORİ</th>
            <th>AÇIKLAMA</th>
            <th>FİYAT</th>
            <th>ÜRÜN KODU</th>
            <th>FOTOĞRAF</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Id") %></td>
                    <td><%#Eval("ProductName") %></td>
                    <td><%#Eval("CategoryName") %></td>
                    <td><%#Eval("Explanation") %></td>
                    <td><%#Eval("Price") %></td>
                    <td><%#Eval("Code") %></td>
                    <td><%#Eval("Photo") %></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/AdminRemoveProduct.aspx?Id=" + Eval("Id") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/AdminUpdateProduct.aspx?Id=" + Eval("Id") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>

                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="AdminAddProduct.aspx" class="btn btn-info">Ürün Ekle</a>

</asp:Content>
