<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminCategories.aspx.cs" Inherits="Proje.Web.AdminCategories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>KATEGORİ ID</th>
            <th>KATEGORİ AD</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Id") %></td>
                    <td><%#Eval("CategoryName") %></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/AdminRemoveCategory.aspx?Id=" + Eval("Id") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/AdminUpdateCategory.aspx?Id=" + Eval("Id") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>

                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="AdminAddCategory.aspx" class="btn btn-info">Kategori Ekle</a>
</asp:Content>
