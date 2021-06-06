<%@ Page Title="" Language="C#" MasterPageFile="~/Fundamental.Master" AutoEventWireup="true" CodeBehind="DefaultFilterProduct.aspx.cs" Inherits="Proje.Web.DefaultFilterProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form runat="server">
        <div style="text-align:center">
        Masa Numaranız: 
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label" CssClass="btn btn-info"></asp:Label></div>
        Kategori Seçiniz: <br />
        
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                 <asp:HyperLink NavigateUrl='<%#"~/DefaultFilterProduct.aspx?Id=" + Eval("Id") %>' ID="HyperLink2" runat="server" CssClass="btn btn-success"><i class="fa fa-list"></i> <%#Eval("CategoryName") %></asp:HyperLink>

            </ItemTemplate>
        </asp:Repeater></div>
         <br />
         <br />
        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
                <div style="text-align:center">
                   
                    <asp:Image ID="Image1" runat="server" ImageUrl=<%#Eval("Photo") %> CssClass="img-fluid" Height="450px" Width="500px"/> <br />
                    

                </div>
                <div style="text-align:center"  >  
                     <%#Eval ("ProductName") %>
                    <br />  
                     <%#Eval ("Price") %>
                    <br />
                    <asp:HyperLink NavigateUrl='<%#"~/DefaultAddCart.aspx?Id=" + Eval("Id") %>' ID="HyperLink1" runat="server" CssClass="btn btn-success"><i class="fa fa-shopping-basket"></i> Sepete Ekle</asp:HyperLink>
                    <br />
                    <br />
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
                                <td><asp:HyperLink NavigateUrl='<%#"~/DefaultRemoveProductInCart.aspx?Id=" + Eval("Id") %>' ID="HyperLink3" runat="server" CssClass="btn btn-danger"><i class="fa fa-remove"></i> Sil</asp:HyperLink></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
         <div style="text-align:center">
        <asp:HyperLink NavigateUrl='/DefaultAddOrder.aspx' ID="HyperLink1" runat="server" CssClass="btn btn-success"><i class="fa fa-check"></i> Siparişi Tamamla</asp:HyperLink>

         </div>
         </form>
</asp:Content>
