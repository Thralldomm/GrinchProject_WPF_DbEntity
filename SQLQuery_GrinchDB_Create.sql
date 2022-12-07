create database [Grinch]
go 
use [Grinch]
go
create table [Place]
(
Id int primary key identity (1,1) not null,
Area nvarchar(max) not null

)
go
create table [Character]
(
Id int primary key identity (1,1) not null,
Name nvarchar(max) not null,
Description nvarchar(max) not null,
Photo nvarchar(max) not null,
PlaceId int not null,

foreign key (PlaceId) references [Place](Id) on delete cascade
)
go
create table [Friend]
(
Id int primary key identity (1,1) not null,
FriendCharacterId int not null,
CharacterId int not null,

foreign key (FriendCharacterId) references [Character](Id) ,
foreign key (CharacterId) references [Character](Id) on delete cascade
)