drop database if exists LibrarySystem

create database LibrarySystem



create table Country(
CountryId int identity Primary key ,
Name varchar(200) not null,
CurrencyCode varchar(200) not null,
SecondaryCurrencyCode varchar(200) not null,
);

insert into Country (Name, CurrencyCode, SecondaryCurrencyCode)
values('Pakistan', 'RS','Paisa'),
('Saudia Arab', 'SR','Halala');

select * from Country;