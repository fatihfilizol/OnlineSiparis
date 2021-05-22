<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminUpdateCategory.aspx.cs" Inherits="Proje.Web.AdminUpdateCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server">
        <span>
            <asp:TextBox ID="TxtId" runat="server"  CssClass="form-control" Enabled="false"></asp:TextBox>
        </span>
        <br />
        <span>
            <asp:TextBox ID="TxtName" runat="server" placeholder="Kategori Adı Giriniz..." CssClass="form-control" ></asp:TextBox>
        </span>
        <br />
       
        <span>
            <asp:Button ID="BtnUpdateCategory" runat="server" Text="Kategori Güncelle" CssClass="btn btn-info" OnClick="BtnUpdateCategory_Click"/>
        </span>
    </form>

</asp:Content>
