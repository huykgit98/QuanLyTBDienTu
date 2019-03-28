document.querySelector("#ddl_Cate option:nth-child(1)").setAttribute("disabled", true);

var today = new Date;
document.getElementById("txtDateOrder").value = today.getDate() + " - " + (today.getMonth() + 1) + " - " + today.getFullYear();
document.getElementById("txtDateDelivery").setAttribute("placeholder", "dd-MM-yyyy");

// kiểm tra điều kiệm cập nhật
var Code = document.getElementById("Code");
var Quantity = document.getElementById("Quantity"); 
function clickBtnCapNhat() {
    if (Code.value != "")
    {
        if (Number.isNaN(Quantity.value) === false && Number.isInteger(parseInt(Quantity.value)) == true)
        {
            alert("Cập nhật thành công.");
            return true;
        }
        else
            alert("Chỉ được nhập số.")
    }
    else
        alert("Hãy chọn sản phẩm muốn cập nhật.")
    return false;
}

// kiểm tra điều kiện để thêm giỏ hàng
var txtCodePro = document.getElementById("txtCodePro"); // mã sản phẩm
var txtQtyPro = document.getElementById("txtQtyPro"); // số lượng còn lại trong kho
var txtQty = document.getElementById("txtQty"); // số mượn muốn mua
var txtDiscountPro = document.getElementById("txtDiscountPro"); // số mượn muốn mua

function clickBtnMua() {
    if (txtCodePro.value != "")
        return true;
    else
        alert("Hãy chọn sản phẩm muốn mua.");

    return false;
}

// kiểm tra thông tin khi thanh toán
var txtNameCus = document.getElementById("txtNameCus");
var txtAddressCus = document.getElementById("txtAddressCus");
var txtPhoneCus = document.getElementById("txtPhoneCus");
var txtDateDelivery = document.getElementById("txtDateDelivery");
txtPhoneCus.setAttribute("placeholder", "[09|03]+8 chữ số");
function clickBtnThanhToan() {
    if (txtNameCus.value == "" || txtAddressCus.value == "" || txtPhoneCus.value == "" || txtDateDelivery.value == "")
        alert("Hãy nhập đầy đủ thông tin thanh toán.");
    else {
        var phone_regex = /((09|03)+([0-9]{8})\b)/g;
        if (phone_regex.test(txtPhoneCus.value) == false)
            alert("Số điện thoại sai định dạng.");
        else
        {
            alert("Thanh toán thành công.");
            return true;
        }
    }

    return false;
}