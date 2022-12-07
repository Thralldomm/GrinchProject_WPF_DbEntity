# GrinchProject_WPF_DbEntity


## Script for Db

```
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
```

## Connection

1. Download 

Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

2. App.config -> add ConnectionString

```
<connectionStrings>
    <add name="DbConnectionString"
        connectionString="Server=localhost,63027;Database=SportStore;Trusted_Connection=True"
        prividerName="System.Data.SqlClient">

         <add name="DbConnectionString"
        connectionString="Server=(localdb)\mssqllocaldb;Database=SportStore;Trusted_Connection=True"
        prividerName="System.Data.SqlClient">

<connectionStrings>
```

3. Консоль диспетчера пакетов

```
Scaffold-DbContext "Server=(localdb)\mssqllocaldb;Database=SportStore;Trusted_Connection=True" Microsoft.EntityFramworkCore.SqlServer -OutputDir Models
```

4. В созданном контексте изменить метод OnConfiguring:

```
optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ConnectionLocalDb"].ToString());
```

- это для того, чтобы прямого доступа к строке подключения у нас не было. Эта строка идет в App.config -> ConnectionStrings, ищет сторку подключения с указанным именем и превращает ее в строку





## Adjusting elements to the window size

In WPF there are certain 'container' controls that automatically resize their contents and there are some that don't.

Here are some that do not resize their contents (I'm guessing that you are using one or more of these):

StackPanel
WrapPanel
Canvas
TabControl

Here are some that do resize their contents:

Grid
UniformGrid
DockPanel

Therefore, it is almost always preferable to use a Grid instead of a StackPanel unless you do not want automatic resizing to occur. Please note that it is still possible for a Grid to not size its inner controls... it all depends on your Grid.RowDefinition and Grid.ColumnDefinition settings:

