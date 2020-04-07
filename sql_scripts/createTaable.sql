create table Restaurants
(
    Id       int identity
        constraint PK_Restaurants
            primary key,
    Name     nvarchar(80) not null,
    Location nvarchar(80) not null,
    Cuisine  int          not null
)
go


