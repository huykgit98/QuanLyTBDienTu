CREATE DATABASE demo_QLBH_3layer
GO
USE demo_QLBH_3layer
GO

--
CREATE TABLE Category(
	id VARCHAR(10) NOT NULL,
	name_cate NVARCHAR(100) NULL,
	CONSTRAINT PK_Category PRIMARY KEY (id)
)
--
CREATE TABLE Product(
	id VARCHAR(10) NOT NULL,
	id_cate VARCHAR(10) NOT NULL,
	name_pro NVARCHAR(100) NOT NULL,
	qty INT NOT NULL,
	price INT NOT NULL,
	CONSTRAINT FK_Product_Category FOREIGN KEY (id_cate) REFERENCES Category(id),
	CONSTRAINT PK_Product PRIMARY KEY (id)
)
--
CREATE TABLE Employee(
	id VARCHAR(10) NOT NULL,
	name_emp NVARCHAR(50) NOT NULL,
	address_emp NVARCHAR(255) NULL,
	phone VARCHAR(15) NULL,
	CONSTRAINT PK_Employee PRIMARY KEY (id)
)
--
CREATE TABLE Customer(
	id VARCHAR(10) NOT NULL,
	name_cus NVARCHAR(50) NOT NULL,
	address_cus NVARCHAR(255) NOT NULL,
	phone VARCHAR(15) NOT NULL,
	CONSTRAINT PK_Customer PRIMARY KEY (id)
)
--
CREATE TABLE Bill(
	id VARCHAR (10) NOT NULL,
	id_cus VARCHAR (10) NOT NULL,
	date_order DATETIME NOT NULL,
    date_delivery DATETIME NOT NULL,
	total INT NOT NULL,
	status INT NOT NULL,
	CONSTRAINT FK_Order_Customer FOREIGN KEY (id_cus) REFERENCES Customer(id),
    CONSTRAINT PK_Order PRIMARY KEY (id)
)
--
CREATE TABLE BillDetails(
	id_bill VARCHAR (10) NOT NULL,
	id_pro VARCHAR (10) NOT NULL,
	qty INT NOT NULL,
	price INT NOT NULL,
	discount INT NOT NULL,
	amount INT NOT NULL,
    CONSTRAINT FK_BillDetails_Bill FOREIGN KEY (id_bill) REFERENCES Bill(id), 
    CONSTRAINT FK_BillDetails_Product FOREIGN KEY (id_pro) REFERENCES Product(id), 
    CONSTRAINT PK_BillDetails PRIMARY KEY (id_bill,id_pro)
)

--
INSERT INTO Category(id,name_cate) VALUES('CT0001',N'Bo Mạch Chủ')
INSERT INTO Category(id,name_cate) VALUES('CT0002',N'CPU-Bộ vi xử lý')
INSERT INTO Category(id,name_cate) VALUES('CT0003',N'RAM')
INSERT INTO Category(id,name_cate) VALUES('CT0004',N'Nguồn-PSU')
INSERT INTO Category(id,name_cate) VALUES('CT0005',N'Ổ Cứng')
INSERT INTO Category(id,name_cate) VALUES('CT0006',N'Ổ Đĩa Quang')
INSERT INTO Category(id,name_cate) VALUES('CT0007',N'Tản Nhiệt')
INSERT INTO Category(id,name_cate) VALUES('CT0008',N'Card Màn Hình-VGA')
INSERT INTO Category(id,name_cate) VALUES('CT0009',N'Case-Thùng máy')
--
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0001','CT0001',N'Mainboard ASUS ROG STRIX B360-G GAMING',15,2350000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0002','CT0002',N'CPU Intel Core I7-9700K(3.6GHz-4.9GHz)',7,11710000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0003','CT0005',N'Ổ cứng HDD WD 4TB WD4005FZBX(Đen)',25,5285000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0004','CT0001',N'Mainboard MSI H310M PRO-VDH',15,1790000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0005','CT0008',N'ROG-STRIX-GTX1660Ti-O6G-GAMING',5,9290000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0006','CT0005',N'Ổ cứng HDD WD 8TB WD81PURZ(Tím)',4,7500000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0007','CT0001',N'Mainboard GIGABYTE GA-B250-FinTech',25,2090000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0008','CT0008',N'ROG-STRIX-GTX1660Ti-A6G-GAMING',7,9740000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0009','CT0004',N'PSU GIGABYTE PB500-500W-80 Plus Bronze',18,1250000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0010','CT0001',N'Mainboard GIGABYTE B360 M AORUS PRO',14,2150000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0011','CT0004',N'PSU GIGABYTE G750H-750W-80 Plus Gold-Semi Modular',13,2750000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0012','CT0008',N'GV-N1050WF2OC-2GD',15,4348000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0013','CT0009',N'Case máy tính Cooler Master Pro 3',25,2400000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0014','CT0003',N'RAM GeIL 1x4GB DDR4 2400MHz',42,720000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0015','CT0002',N'CPU Intel Core I3-7100(3.9GHz)',4,3350000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0016','CT0007',N'Tản khí Cooler Master XDream L115',82,210000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0017','CT0002',N'CPU Intel Core I5-7500 (3.4GHz-3.8GHz)',2,5970000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0018','CT0003',N'RAM Adata XPG Z1 1x4GB DDR4 2666MHz',32,890000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0019','CT0007',N'Quạt Sama Halo Dual Ring Red Led',34,150000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0020','CT0001',N'Mainboard MSI H310M PRO-VL',1,1789000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0021','CT0009',N'Case máy tính Sahara P07',14,750000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0022','CT0003',N'RAM KINGMAX 1x8GB DDR4 2666MHz',5,1690000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0023','CT0003',N'RAM KINGMAX 1x8GB DDR4 2400MHz',18,990000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0024','CT0009',N'Case máy tính XIGMATEK Scorpio(EN40339)',14,666000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0025','CT0007',N'Tản nước AIO DEEPCOOL Maelstrom 240 RGB',12,1650000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0026','CT0006',N'Ổ đĩa DVD WR ASUS 2D5MT-Tray',1,387000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0027','CT0006',N'Ổ đĩa DVD WR Fujitsu External',2,900000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0028','CT0007',N'Quạt DEEPCOOL XFAN 120 L/B',42,110000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0029','CT0009',N'Case máy tính Patriot Galaxy S9',3,1050000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0030','CT0006',N'Ổ đĩa DVD WR laptop Sata Slim',5,840000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0031','CT0005',N'Ổ cứng SDD WD Black 500GB M.2 2280 NVMe PCle',7,4385000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0032','CT0004',N'PSU Thermaltake LitePower 350-350W',12,550000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0033','CT0008',N'VGA GIGABYTE Radeon RX 580 8GB GDDR5 AORUS',9,6600000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0034','CT0006',N'Ổ đĩa DVD Rom Asus 18X E818A9T Sata Tray',4,278000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0035','CT0004',N'PSU AcBel HK400N-300W',15,515000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0036','CT0008',N'VGA GIGABYTE GeFORCE GTX 1080Ti 11GB GDDR5X GAMING',3,21350000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0037','CT0007',N'Tản nước AIO DEEPCOOL Maelstrom 240 RGB',13,1650000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0038','CT0009',N'Case máy tính EROSI X11',5,320000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0039','CT0002',N'CPU AMD Ryzen 3 2200G(3.5GHz-3.7GHz)',18,2630000)
INSERT INTO Product(id,id_cate,name_pro,qty,price) VALUES('PD0040','CT0002',N'CPU AMD Ryzen 7 2700X(3.7GHz-4.3GHz)',4,9200000)
--

