<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminAddProduct.aspx.cs" Inherits="Proje.Web.AdminAddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server">
        <span>
            <asp:TextBox ID="TxtName" runat="server" placeholder="Ürün Adı Giriniz..." CssClass="form-control"></asp:TextBox>
        </span>
        <br />
         <span>
             <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </span>
        <br />
         <span>
            <asp:TextBox ID="TxtExplanation" runat="server" placeholder="Ürün Notu Giriniz..." CssClass="form-control"></asp:TextBox>
        </span>
        <br />
         <span>
            <asp:TextBox ID="TxtPrice" runat="server" placeholder="Ürün Fiyatı Giriniz..." CssClass="form-control"></asp:TextBox>
        </span>
        <br />
         <span>
            <asp:TextBox ID="TxtCode" runat="server" placeholder="Ürün Kodunu Giriniz..." CssClass="form-control"></asp:TextBox>
        </span>
        <br />
        <span>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

        </span>
        <br />
        <span>
            <asp:Button ID="BtnAddProduct" runat="server" Text="Ürün Ekle" CssClass="btn btn-primary" OnClick="BtnAddProduct_Click"/>
        </span>
    </form>

</asp:Content>
