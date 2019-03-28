using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using DTO;

namespace GUI
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                loadCate();
            }
        }

        // 
        protected void searchNamePro_TextChanged(object sender, EventArgs e) { }
        protected void txtCodePro_TextChanged(object sender, EventArgs e) { }
        protected void txtCodeCate_TextChanged(object sender, EventArgs e) { }
        protected void txtNamePro_TextChanged(object sender, EventArgs e) { }
        protected void txtPricePro_TextChanged(object sender, EventArgs e) { }
        protected void txtQtyPro_TextChanged(object sender, EventArgs e) { }
        protected void txtNameCus_TextChanged(object sender, EventArgs e) { }
        protected void txtAddressCus_TextChanged(object sender, EventArgs e) { }
        protected void txtPhoneCus_TextChanged(object sender, EventArgs e) { }
        protected void txtDateOrder_TextChanged(object sender, EventArgs e) { }
        protected void txtDateDelivery_TextChanged(object sender, EventArgs e) { }
        protected void txtTotal1_TextChanged(object sender, EventArgs e) { }
        protected void txtDiscount_TextChanged(object sender, EventArgs e) { }
        protected void txtTotal2_TextChanged(object sender, EventArgs e) { }
        protected void Code_TextChanged(object sender, EventArgs e) { }
        protected void Quantity_TextChanged(object sender, EventArgs e) { }



        // đổ ra toàn bộ dữ liệu của loại thiết bị
        public void loadCate()
        {
            CategoryBLL b = new CategoryBLL();
            ddl_Cate.DataSource = b.getAll();
            ddl_Cate.DataTextField = "name_cate";
            ddl_Cate.DataValueField = "id";
            ddl_Cate.DataBind();
            ddl_Cate.Items.Insert(0, new ListItem("---- Chọn Loại ----","0"));
        }

        //
        protected void ddl_Cate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductBLL b = new ProductBLL();
            lb_ProByCate.DataSource = b.getByNameAndIdCate("", ddl_Cate.SelectedValue.ToString());
            lb_ProByCate.DataTextField = "name_pro";
            lb_ProByCate.DataValueField = "id";
            lb_ProByCate.DataBind();
        }

        // tìm kiếm thiết bị
        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            string name_pro = searchNamePro.Text;
            string id_cate = ddl_Cate.SelectedValue.ToString();
            ProductBLL b = new ProductBLL();
            lb_ProByCate.DataSource = b.getByNameAndIdCate(name_pro,id_cate);
            lb_ProByCate.DataTextField = "name_pro";
            lb_ProByCate.DataValueField = "id";
            lb_ProByCate.DataBind();
        }

        // lấy ra thông tin của thiết bị
        protected void lb_ProByCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id_pro = lb_ProByCate.SelectedValue.ToString();
            ProductBLL b = new ProductBLL();
            List<Product> l = new List<Product>();
            l = b.getById(id_pro);
            txtCodePro.Text = l[0].Id;
            txtCodeCate.Text = l[0].Id_cate;
            txtNamePro.Text = l[0].Name_pro;
            txtPricePro.Text = l[0].Price.ToString();
            txtQtyPro.Text = l[0].Qty.ToString();
        }

        // thêm vào giỏ hàng
        protected void btnMua_Click(object sender, EventArgs e)
        {
            
            DataTable cart = new DataTable();
            if (Session["cart"] == null)
            {
                cart.Columns.Add("Mã");
                cart.Columns.Add("Tên");
                cart.Columns.Add("Giá");
                cart.Columns.Add("Số Lượng");
                cart.Columns.Add("Tổng");
            }
            else
                cart = (DataTable)Session["cart"];
            bool isExisted = false;
            foreach(DataRow r in cart.Rows)
            {
                if(r["Mã"].ToString() == txtCodePro.Text.ToString())
                {
                    r["Số Lượng"] = Int32.Parse(r["Số Lượng"].ToString()) + 1;
                    r["Tổng"] = Int32.Parse(r["Giá"].ToString()) * Int32.Parse(r["Số Lượng"].ToString());
                    isExisted = true;
                    break;
                }
            }
            if(isExisted == false)
            {
                DataRow r = cart.NewRow();
                r["Mã"] = txtCodePro.Text;
                r["Tên"] = txtNamePro.Text;
                r["Giá"] = txtPricePro.Text;
                r["Số Lượng"] = 1;
                r["Tổng"] = Int32.Parse(txtPricePro.Text);
                cart.Rows.Add(r);
            }
            Session["cart"] = cart;

            // đổ vào giỏ hàng và tổng hóa đơn của giỏ hàng
            gv_Cart.DataSource = cart;
            gv_Cart.DataBind();

            // đặt lại giá trị rỗng cho các ô text
            txtCodePro.Text = "";
            txtCodeCate.Text = "";
            txtNamePro.Text = "";
            txtPricePro.Text = "";
            txtQtyPro.Text = "";

            // tổng chi phí
            if (gv_Cart.Rows.Count >= 2)
                txtDiscount.Text = "5";
            else
                txtDiscount.Text = "0";
            txtTotal1.Text = totalBill().ToString();
            txtTotal2.Text = (totalBill() - (totalBill() * Int32.Parse(txtDiscount.Text.ToString()))/100).ToString();
        }

        // xóa đi 1 thiết bị trong giỏ hàng, xóa luôn cả thiết bị nằm trong combo
        protected void gv_Cart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable cart = (DataTable)Session["cart"];
            foreach (DataRow r in cart.Rows)
            {
                if (r["Mã"].ToString() == gv_Cart.DataKeys[e.RowIndex].Value.ToString())
                {
                    r.Delete();
                    break;
                }
            }
            Session["cart"] = cart;
            gv_Cart.DataSource = cart;
            gv_Cart.DataBind();

            // tổng chi phí
            if (gv_Cart.Rows.Count >= 2)
                txtDiscount.Text = "5";
            else
                txtDiscount.Text = "0";
            
            txtTotal1.Text = totalBill().ToString();
            txtTotal2.Text = (totalBill() - (totalBill() * Int32.Parse(txtDiscount.Text.ToString())) / 100).ToString();

        }

        // sửa thông tin giỏ hàng
        protected void gv_Cart_SelectedIndexChanged(object sender, EventArgs e)
        {
            Code.Text = gv_Cart.SelectedRow.Cells[1].Text.ToString();
            Quantity.Text = gv_Cart.SelectedRow.Cells[4].Text.ToString();
        }
        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataTable cart = (DataTable)Session["cart"];
            foreach (DataRow r in cart.Rows)
            {
                if (r["Mã"].ToString() == Code.Text)
                {
                    ProductBLL b = new ProductBLL();
                    if (Int32.Parse(Quantity.Text) <= Int32.Parse(b.getById(Code.Text)[0].Qty.ToString()))
                        r["Số Lượng"] = Int32.Parse(Quantity.Text);
                    else
                        r["Số Lượng"] = Int32.Parse(b.getById(Code.Text)[0].Qty.ToString());
                    r["Tổng"] = Int32.Parse(r["Giá"].ToString()) * Int32.Parse(r["Số Lượng"].ToString());
                    break;
                }
            }
            Session["cart"] = cart;
            gv_Cart.DataSource = cart;
            gv_Cart.DataBind();

            // tổng chi phí
            if (gv_Cart.Rows.Count >= 2)
                txtDiscount.Text = "5";
            else
                txtDiscount.Text = "0";

            txtTotal1.Text = totalBill().ToString();
            txtTotal2.Text = (totalBill() - (totalBill() * Int32.Parse(txtDiscount.Text.ToString())) / 100).ToString();

            Code.Text = "";
            Quantity.Text = "";
        }

        // tính tổng hóa đơn
        public int totalBill()
        {
            DataTable ds = new DataTable();
            ds = (DataTable)gv_Cart.DataSource;
            int total = 0;
            foreach (DataRow t in ds.Rows)
            {
                total += Int32.Parse(t[4].ToString());
            }
            return total;
        }

        // thanh toán
        protected void btnThanhToan_Click(object sender, EventArgs e)
        {
            CustomerBLL b1 = new CustomerBLL();
            b1.Insert(txtNameCus.Text, txtAddressCus.Text, txtPhoneCus.Text);
            string id_cus = b1.getByIdJustCreated()[0].Id;

            BillBLL b2 = new BillBLL();
            b2.Insert(id_cus,DateTime.Parse(txtDateDelivery.Text),Int32.Parse("1"));
            string id_bill = b2.getByIdJustCreated()[0].Id;


            BillDetailsBLL b3 = new BillDetailsBLL();
            DataTable cart = (DataTable)Session["cart"];
            foreach (DataRow r in cart.Rows)
            {
                string id_pro = r[0].ToString();
                int price = Int32.Parse(r[2].ToString());
                int qty = Int32.Parse(r[3].ToString());
                int discount = Int32.Parse(txtDiscount.Text);
                int amount = price * qty - price * discount / 100;
                ProductBLL b4 = new ProductBLL(); 
                int qty_pro = b4.getById(id_pro)[0].Qty; // lấy giá trị số lượng tồn
                b3.Insert(id_bill,id_pro,qty_pro,qty,price,discount,amount);              
            }
            for (int i=0; i<gv_Cart.Rows.Count; i++)
            {
                gv_Cart.DeleteRow(i);
            }
            Session.Contents.Remove("cart");
        }

    }
}