<%@ Page Title="" Language="C#" MasterPageFile="~/Fundamental.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proje.Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        Masa Numaranız: 
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></div>
        Kategori Seçiniz: <br />
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <asp:HyperLink NavigateUrl='<%#"~/DefaultFilterProduct.aspx?Id=" + Eval("Id") %>' ID="HyperLink2" runat="server" CssClass="btn"><%#Eval("CategoryName") %> </asp:HyperLink>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
                <div>
                   
                    <asp:Image ID="Image1" runat="server" ImageUrl=<%#Eval("Photo") %> CssClass="img-fluid" Height="450px" Width="500px"/> <br />
                    <asp:HyperLink NavigateUrl='<%#"~/DefaultAddCart.aspx?Id=" + Eval("Id") %>' ID="HyperLink1" runat="server" CssClass="btn btn-warning">Sepete Ekle</asp:HyperLink>

                </div>
                <div style="margin-left : 40%"  >  
                     <%#Eval ("ProductName") %>
                    <br />  
                     <%#Eval ("Price") %>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        
                <table class="table table-bordered align-top">
                        <tr>
                            <th class="shoping__product">Ürün</th>
                            <th>Miktar</th>
                            <th>Fiyat</th>
                            <th>Sepetten Sil</th>
                        </tr>
                    <asp:Repeater ID="Repeater3" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval ("ProductName") %></td>
                                <td><%#Eval ("Count") %></td>
                                <td><%#Eval ("Price") %></td>
                                <td><asp:HyperLink NavigateUrl='<%#"~/DefaultRemoveProductInCart.aspx?Id=" + Eval("Id") %>' ID="HyperLink3" runat="server" CssClass="btn-danger">Sil</asp:HyperLink></td>

                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
        <asp:HyperLink NavigateUrl='/DefaultAddOrder.aspx' ID="HyperLink1" runat="server" CssClass="btn btn-warning">Siparişi Tamamla</asp:HyperLink>

    </form>
</asp:Content>
