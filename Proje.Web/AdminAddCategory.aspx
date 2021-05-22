<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminAddCategory.aspx.cs" Inherits="Proje.Web.AdminAddCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        <span>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Kategori Adı Giriniz..." CssClass="form-control"></asp:TextBox>
        </span>
        <br />
       
        <span>
            <asp:Button ID="BtnAddCategory" runat="server" Text="Kategori Ekle" CssClass="btn btn-primary" OnClick="BtnAddCategory_Click"/>
        </span>
    </form>
</asp:Content>
