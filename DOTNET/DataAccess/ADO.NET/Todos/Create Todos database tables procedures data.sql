/****** Object:  Database Todos    Script Date: 18/01/2023 13:49:28 ******/
CREATE DATABASE Todos
go
--
USE Todos
GO
--
CREATE TABLE Items(
	Id int IDENTITY(1,1) NOT NULL primary key,
	Title nvarchar(256) not null unique,
	IsCompleted bit NOT NULL,
)
go
--
create proc SelectAllItems as select * from Items
go
--
create proc SelectItems @title varchar(max)  as select * from Items where title=@title
go
--
create proc InsertItem @title varchar(max) , @isCompleted bit as insert into Items (Title,IsCompleted) values(@Title,@isCompleted) ;return @@identity
go
--
create proc UpdateItem @id int ,@title varchar(max) , @isCompleted bit as update Items set Title=@title,IsCompleted=@isCompleted where id=@id ;return @@rowcount
go
--
create proc DeleteItemByID @id int as delete Items where id=@id ;return @@rowcount
go
--
create proc DeleteItemByTitle @title int as delete Items where title=@title ;return @@rowcount
go
--insert sample data
insert into Items values('Buy bread',0)
insert into Items values('Visit family',0)
insert into Items values('Sell car',1)
insert into Items values('Make resume',0)
insert into Items values('Learn HTML',1)