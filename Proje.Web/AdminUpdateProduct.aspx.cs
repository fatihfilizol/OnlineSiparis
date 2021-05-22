using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class AdminUpdateProduct : System.Web.UI.Page
    {
        OnlineSiparisEntities product = new OnlineSiparisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var c = (from i in product.Category select new { i.Id, i.CategoryName }).ToList();
                DropDownList1.DataTextField = "CategoryName";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataSource = c;
                DropDownList1.DataBind();


                int id = Convert.ToInt32(Request.QueryString["Id"]);
                var p = product.Product.Find(id);
                TxtName.Text = p.ProductName;
                TxtCode.Text = p.Code;
                TxtExplanation.Text = p.Explanation;
                TxtPrice.Text = p.Price.ToString();
                Label1.Text = "Dosya Adı: " + p.Photo;
                DropDownList1.SelectedValue = p.CategoryId.ToString();
            }
        }

        protected void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var p = product.Product.Find(id);
            p.ProductName = TxtName.Text;
            p.Code = TxtCode.Text;
            p.Explanation = TxtExplanation.Text;
            p.Price = decimal.Parse(TxtPrice.Text);


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
                            p.Photo = FileUpload1.PostedFile.FileName.ToString();
                            
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


            p.CategoryId = Convert.ToInt32(DropDownList1.SelectedValue);
            product.SaveChanges();
            Response.Redirect("AdminProducts.aspx");
        }
    }
}