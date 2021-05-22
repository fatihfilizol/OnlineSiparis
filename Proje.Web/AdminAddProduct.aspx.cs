using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class AdminAddProduct : System.Web.UI.Page
    {
        OnlineSiparisEntities product = new OnlineSiparisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                var c = (from i in product.Category select new { i.Id, i.CategoryName }).ToList();
                DropDownList1.DataTextField = "CategoryName";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataSource = c;
                DropDownList1.DataBind();
            }
            
        }

        protected void TxtCategory_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void BtnAddProduct_Click(object sender, EventArgs e)
        {
           





            if (FileUpload1.HasFile)
            {
                try
                {
                    if (FileUpload1.PostedFile.ContentType == "image/jpeg")
                    {
                        if (FileUpload1.PostedFile.ContentLength < 10240000)
                        {

                            FileUpload1.SaveAs(Server.MapPath("~/template/img/") + FileUpload1.FileName);
                            Label1.Text = "Dosya Adı: " + FileUpload1.PostedFile.FileName;
                            Product newproduct = new Product();
                            newproduct.ProductName = TxtName.Text;
                            newproduct.CategoryId = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
                            newproduct.Explanation = TxtExplanation.Text;
                            newproduct.Price = decimal.Parse(TxtPrice.Text);
                            newproduct.Code = TxtCode.Text;
                            newproduct.CreateDate = DateTime.Now;
                            newproduct.Active = true;
                            newproduct.Photo ="~/template/img/"+ FileUpload1.PostedFile.FileName.ToString();
                            product.Product.Add(newproduct);
                            product.SaveChanges();
                            Response.Redirect("AdminProducts.aspx");
                        }
                        else
                        {
                            Label1.Text = "Maksimum Boyut 10MB Olmalı.";
                        }
                    }
                    else
                    {
                        Label1.Text = "Resim Dosyası Seçin.";
                    }
                }
                catch (Exception ex)
                {
                    Label1.Text = "Hata oluştu: " + ex.Message.ToString();
                }
            }
            else
            {
                Label1.Text = "Dosya Seçin ve GÖNDER Butonuna Tıklayın.";
            }

        }

        
    }
}