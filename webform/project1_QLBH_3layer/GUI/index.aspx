<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="GUI.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Projec1_QLBH_3layer</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" style="box-shadow:10px 5px 15px #ddd,-10px 5px 15px #ddd;padding-top:15px;padding-bottom:15px;">
            <h3 class="text-primary"><ins>Danh sách thiết bị</ins></h3>
            <div class="row mt-3">
                <div class="col-md-5">
                    <div class="form-group row">
                        <label for="ddl_Cate" class="col-sm-4 col-form-label" style="font-size:18px;font-weight:600">Loại thiết bị</label>
                        <div class="col-sm-8">
                            <asp:DropDownList ID="ddl_Cate" CssClass="form-control" Width="220px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_Cate_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="col-md-5">
                    <div class="form-group row">
                        <label for="searchNamePro" class="col-sm-4 col-form-label" style="font-size:18px;font-weight:600">Tên thiết bị</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="searchNamePro" class="form-control" runat="server" OnTextChanged="searchNamePro_TextChanged"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="col-md-2">
                    <asp:Button ID="btnTimKiem" CssClass="btn btn-primary" runat="server" Text="Tìm kiếm" OnClick="btnTimKiem_Click" />
                </div>
            </div>
            <div class="row my-3">
                <div class="col-md-5">
                    <h5 class="text-center"><ins>Chọn thiết bị</ins></h5>
                    <asp:ListBox ID="lb_ProByCate" style="width:100%;height:90%" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lb_ProByCate_SelectedIndexChanged"></asp:ListBox>
                </div>
                <div class="col-md-7">
                    <h5 class="text-center"><ins>Thông tin thiết bị</ins></h5>
                    <div class="form-row">
                        <div class="col-md-6 mb-3">
                            <label for="txtCodePro">Mã sản phẩm</label>
                            <asp:TextBox ID="txtCodePro" CssClass="form-control" runat="server" disabled OnTextChanged="txtCodePro_TextChanged" ></asp:TextBox>
                        </div>
                        <div class="col-md-6 mb-3">
                            <label for="txtCodeCate">Mã loại</label>
                            <asp:TextBox ID="txtCodeCate" CssClass="form-control" runat="server" disabled OnTextChanged="txtCodeCate_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-8 mb-3">
                            <label for="txtNamePro">Tên sản phẩm</label>
                            <asp:TextBox ID="txtNamePro" CssClass="form-control" runat="server" disabled OnTextChanged="txtNamePro_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-4 mb-3">
                            <label for="txtPricePro">Giá sản phẩm</label>
                            <asp:TextBox ID="txtPricePro" CssClass="form-control" runat="server" disabled OnTextChanged="txtPricePro_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-4 mb-3">
                            <label for="txtQtyPro">Số lượng tồn kho</label>
                            <asp:TextBox ID="txtQtyPro" CssClass="form-control" runat="server" disabled OnTextChanged="txtQtyPro_TextChanged"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="ml-auto">
                            <asp:Button ID="btnMua" CssClass="btn btn-primary" runat="server" Text="Thêm Vào Giỏ" OnClick="btnMua_Click" OnClientClick="return clickBtnMua();" />
                        </div>
                    </div>
                </div>
            </div>

            <h3 class="text-primary"><ins>Giỏ hàng và thanh toán</ins></h3>
            <div class="row my-3">
                <div class="col-md-4">
                    <div class="form-group row">
                        <label for="txtNameCus" class="col-sm-4 col-form-label">Họ Tên</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtNameCus" class="form-control" placeholder="Nhập tên của khách hàng..." runat="server" OnTextChanged="txtNameCus_TextChanged"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="txtAddressCus" class="col-sm-4 col-form-label">Nơi Giao</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtAddressCus" CssClass="form-control" placeholder="Nhập địa chỉ giao hàng..." runat="server" OnTextChanged="txtAddressCus_TextChanged"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="txtPhoneCus" class="col-sm-4 col-form-label">Điện Thoại</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtPhoneCus" CssClass="form-control" placeholder="Nhập điện thoại của khách hàng..." runat="server" OnTextChanged="txtPhoneCus_TextChanged"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="txtDateOrder" class="col-sm-4 col-form-label">Ngày Đặt</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtDateOrder" CssClass="form-control" runat="server" disabled OnTextChanged="txtDateOrder_TextChanged"></asp:TextBox>
                        </div>                          
                    </div>
                    <div class="form-group row">
                        <label for="txtDateDelivery" class="col-sm-4 col-form-label">Ngày Giao Dự Kiến</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtDateDelivery" CssClass="form-control" runat="server" OnTextChanged="txtDateDelivery_TextChanged"></asp:TextBox>
                        </div>
                    </div>
                    <asp:Button ID="btnThanhToan" CssClass="btn btn-primary" runat="server" Text="Thanh Toán" OnClick="btnThanhToan_Click" OnClientClick="return clickBtnThanhToan();" />
                </div>
                <div class="col-md-8">

                    <div class="form-row">
                        <div class="col-md-5 mb-3">
                            <label for="Code">Mã sản phẩm</label>
                            <asp:TextBox ID="Code" CssClass="form-control" runat="server" disabled OnTextChanged="Code_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-5 mb-3">
                            <label for="Quantity">Số lượng</label>
                            <asp:TextBox ID="Quantity" CssClass="form-control" runat="server" OnTextChanged="Quantity_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-2 mb-3">
                            <label for="Quantity">Cập nhật</label>
                            <asp:Button ID="btnCapNhat" CssClass="btn btn-primary" runat="server" Text="Cập Nhật" OnClick="btnCapNhat_Click" OnClientClick="return clickBtnCapNhat();" />
                        </div>
                    </div>

                    <asp:GridView ID="gv_Cart" CssClass="table" runat="server" AutoGenerateDeleteButton="True" DataKeyNames="Mã" OnRowDeleting="gv_Cart_RowDeleting" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gv_Cart_SelectedIndexChanged">
                    </asp:GridView>                     
                    <div class="offset-md-6">
                        <ul class="list-group">
                            <li class="list-group-item">
                                <table width="100%">
                                    <tr width="100%">
                                        <td width="20%">Tất cả:</td>
                                        <td style="text-align:right">
                                            <asp:TextBox ID="txtTotal1" style="border:0;background:none;font-size:18px;font-weight:600" runat="server" disabled OnTextChanged="txtTotal1_TextChanged"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </li>
                            <li class="list-group-item">
                                <table width="100%">
                                    <tr width="100%">
                                        <td width="20%">Giảm(%):</td>
                                        <td style="text-align:right">
                                            <asp:TextBox ID="txtDiscount" style="border:0;background:none;font-size:18px;font-weight:600" runat="server" disabled OnTextChanged="txtDiscount_TextChanged"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </li>
                            <li class="list-group-item" style="background:#ccc">
                               <table width="100%">
                                    <tr width="100%">
                                        <td width=20%>Tổng:</td>
                                        <td style="text-align:right">
                                            <asp:TextBox ID="txtTotal2" style="border:0;background:none;color:red;font-size:18px;font-weight:600" runat="server" disabled OnTextChanged="txtTotal2_TextChanged"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <!--- script --->
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <script src="javascript.js"></script>
    <!--- script --->

</body>
</html>
