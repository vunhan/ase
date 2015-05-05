use RestaurantManagement

create table ProductCategory
(
	CategoryID varchar(10) primary key NOT NULL,
	CategoryName varchar(100) NOT NULL,
)

create table ProductType 
(
	ProductTypeID varchar(10) primary key NOT NULL,
	CategoryID varchar(10) foreign key references ProductCategory(CategoryID) NOT NULL,
	ProductTypeName varchar(50)
)
create table Unit
(
	UnitID varchar(10) primary key NOT NULL,
	UnitName varchar(50) 
)

Create table ProductSupplier
(
	SupplierID varchar(10) primary key NOT NULL,
	SupplierName varchar(50) NOT NULL
)	
create table Product
(
	ProductID varchar(10) primary key NOT NULL,
	ProductTypeID varchar(10) foreign key references ProductType(ProductTypeID) NOT NULL,
	CatagoryID varchar(10) foreign key references ProductCategory(CategoryID) NOT NULL,
	UnitID varchar(10) foreign key references Unit(UnitID) NOT NULL,
	SupplierID varchar(10) foreign key references ProductSupplier(SupplierID) NOT NULL,
	ProductName varchar(50),
	ProductBuyPrice money NOT NULL,
	ProductSalePrice money NOT NULL,
	ProductManufactureDate smalldatetime NOT NULL,
	ProductExpiryDate smalldatetime NOT NULL,
	ProductImportDate smalldatetime NOT NULL,
	ProductVAT float,
	ProductImage Image

)
--Insert ProductCartegory--
Insert into ProductCategory values ('PC001','Nguyên Liệu')
Insert into ProductCategory values ('PC002','Không Phải Chế Biến')
-------------------------------------------------------------------


----Insert ProductType----
Insert into ProductType  values ('PT001','PC001', 'Các loại củ')
Insert into ProductType  values ('PT002','PC001', 'Các loại rau')
Insert into ProductType  values ('PT003','PC001', 'Các loại thịt')
Insert into ProductType  values ('PT004','PC002', 'Bia')
Insert into ProductType  values ('PT005','PC002', 'Bánh Mỳ')
Insert into ProductType  values ('PT006','PC002', 'Nước Ngọt')
-------------------------------------------------------------------

----Insert ProductSupplier----
Insert into ProductSupplier values ('PS001', 'BigC')
Insert into ProductSupplier values ('PS002', 'Coca Cola')
Insert into ProductSupplier values ('PS003', 'Pesi')
Insert into ProductSupplier values ('PS004', 'Bia Sài Gòn')
-------------------------------------------------------------------

----InsertUnit----
Insert into Unit values('U001','Kg')
Insert into Unit values('U002','Chai')
Insert into Unit values('U003','Lon')
Insert into Unit values('U004','Quả')
Insert into Unit values('U005','Chiếc')
Insert into Unit values('U006','Cái')
-------------------------------------------------------------------

----InsertProduct----
Insert into Product values ('PD001', 'PT003', 'PC001', 'U001', 'PS001', 'Thịt Bò', 70000, 140000, '2015-4-5', '2015-10-5', '2015-4-5', 0, NULL)
Insert into Product values ('PD002', 'PT003', 'PC001', 'U004', 'PS001', 'Trừng Gà', 25000, 5000, '2015-4-5', '2015-10-5', '2015-4-5', 0, NULL)
Insert into Product values ('PD003', 'PT003', 'PC001', 'U001', 'PS001', 'Thịt Heo', 40000, 80000, '2015-4-5', '2015-10-5', '2015-4-5', 0, NULL)
Insert into Product values ('PD004', 'PT004', 'PC002', 'U002', 'PS004', 'Bia Sài Gòn', 9000, 14000, '2015-4-5', '2015-10-5', '2015-4-5', 0, NULL)
Insert into Product values ('PD005', 'PT004', 'PC002', 'U002', 'PS004', 'Bia Hà Nội', 8000, 130000, '2015-4-5', '2015-10-5', '2015-4-5', 0, NULL)
Insert into Product values ('PD006', 'PT006', 'PC002', 'U003', 'PS003', 'Pepsi', 10000, 15000, '2015-4-5', '2015-10-5', '2015-4-5', 0, NULL)
Insert into Product values ('PD007', 'PT005', 'PC002', 'U006', 'PS001', 'Bánh Mì Gối', 40000, 80000, '2015-4-5', '2015-10-5', '2015-4-5', 0, NULL)
-------------------------------------------------------------------