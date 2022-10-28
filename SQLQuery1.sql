use test

create table products(
id int identity(1,1) NOT NULL,
type_of varchar(50) NOT NULL,
count_of int NOT NULL,
supply varchar(50) NOT NULL,
price int NOT NULL,
primary key (id)
);

insert into products (type_of, count_of, supply, price) values ('Вода (литры)', 230, 'WaterForPeople', 6900)

delete from products where id = 3

select * from products