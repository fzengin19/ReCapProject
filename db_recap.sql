create database db_recap
go
use db_recap

create table Cars 
(
CarId int identity(1,1)primary key not null,
BrandId int not null,
ColorId int not null,
ModelYear int not null,
DailyPrice int not null,
[Description] nvarchar(100)

)

create table Colors
(
ColorId int identity(1,1)primary key not null,
ColorName nvarchar(60) not null
)
create table Brands
(
BrandId int identity(1,1)primary key not null,
BrandName nvarchar(60) not null
)

alter table Cars
add foreign key(ColorId) references Colors(ColorId)


alter table Cars
add foreign key(BrandId) references Brands(BrandId)

