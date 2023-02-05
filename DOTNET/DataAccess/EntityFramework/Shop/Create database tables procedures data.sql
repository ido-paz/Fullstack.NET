/****** Object:  Database Shop    Script Date: 18/01/2023 13:49:28 ******/
CREATE DATABASE Shop
go
--
USE Shop
GO
--
CREATE TABLE Products(
	Id int IDENTITY(1,1) NOT NULL primary key,
	Name nvarchar(256) not null unique,
	Price decimal NOT NULL,
)
go
--
create proc SelectAllProducts as select * from Products
go
--
create proc SelectProducts @name varchar(max)  as select * from Products where name=@name
go
--
create proc InsertProduct @name varchar(max) , @price decimal as insert into Products (Name,Price) values(@Name,@price) ;return @@identity
go
--
create proc UpdateProduct @id int ,@name varchar(max) , @price decimal as update Products set Name=@name,Price=@price where id=@id ;return @@rowcount
go
--
create proc DeleteProductByID @id int as delete Products where id=@id ;return @@rowcount
go
--
create proc DeleteProductByName @name int as delete Products where name=@name ;return @@rowcount
go
--insert sample data
insert into Products values('Bread',12)
insert into Products values('Bamba',5)
insert into Products values('Tomato',1)
insert into Products values('Oat Milk',12)
insert into Products values('Pita',1)