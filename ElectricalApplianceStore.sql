--create database ElectricalApplianceStore
use ElectricalApplianceStore

--create table Users(
--	Id int not null identity(1, 1) primary key, 
--	Name nvarchar(50), 
--	Email nvarchar(50), 
--	Password nvarchar(50), 
--	Type nvarchar(30)
--)

--create table ElectricalAppliances(
--	Id int not null identity(1, 1) primary key,
--	Name nvarchar(50),
--	DateOfRelease date,
--	Supplier nvarchar(50),
--	Price float,
--	Weight float,
--  Amount int,
--  Type nvarchar(30)
--)

--create table SellElectricalAppliances(
--	Id int not null identity(1, 1) primary key,
--	Name nvarchar(50),
--	DateOfSale date,
--	Price float,
--	Amount int,
--	User_FK int,
--	Type nvarchar(30)
--)

--1.1 select Type from ElectricalAppliances where Price = (select max(Price) from ElectricalAppliances)
--1.2 select Type from ElectricalAppliances where Price = (select min(Price) from ElectricalAppliances)
--1.3 select Type, (sum(Price) / count(Type)) as Average from ElectricalAppliances group by Type

--2 select * from ElectricalAppliances where Price > 1000 and Price < 20000

--3 select * from ElectricalAppliances where Supplier = 'Испания'

--4 select * from ElectricalAppliances where DateOfRelease = '01.07.2023'

--5 select * from ElectricalAppliances where Weight > 1 and Weight < 5

--select top 1 Type, sum(Amount) as Sum from SellElectricalAppliances group by Type order by Sum desc