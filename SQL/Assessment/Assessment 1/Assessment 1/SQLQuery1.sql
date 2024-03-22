create database SqlTest

use SqlTest

create table Books(
  id int primary key identity,
  title varchar(20),
  author varchar(25),
  isbn varchar(20) unique,
  published_date Datetime
)


insert into Books values
('My First SQL Book', 'May Parker', '981483029127', '2022-02-12 12:08:17'),
('My Second SQL Book', 'John Mayer', '823489010461', '1972-07-03 09:22:45'), 
('My Third SQL Book', 'Cary Flint', '523787837878', '2015-10-18 14:05:44') 



create table Reviews(
	id int primary key identity,
	book_id int,
	reviewer_name varchar(25),
	content varchar(25),
	rating int,
	published_date datetime
)

insert into Reviews values
(1,'John Smith', 'My First Review', 4, '2017-12-10 05:30:11'),
(2,'John Smith','My Second Review', 5, '2017-10-13 15:05:12'),
(2,'Alice Walker','Another Review', 1, '2017-10-22 23:47:10')


--1. Write a query to fetch the details of the books written by author whose name ends with er.
select * from Books where author like '%er'

--2. Display the Title ,Author and ReviewerName for all the books from the above table
select b.Title, b.Author, r.reviewer_name from Books b, Reviews r where b.id = r.id

--3.Display the  reviewer name who reviewed more than one book.
select distinct(reviewer_name) from Reviews where rating > 1


create table Customer (
  id int primary key identity,
  name varchar(25),
  age int,
  address varchar(24),
  salary float
)


insert into Customer values
('Ramesh', 32, 'Ahmedabad', 2000.00),
('Khilan', 25, 'Delhi', 1500.00),
('kaushik', 23, 'Kota', 2000.00),
('Chaitali', 25, 'Mumbai', 6500.00),
('Hardik', 27, 'Bhopal', 8500.00),
('Komal', 22, 'MP', 4500.00),
('Muffy', 24, 'Indore', 10000.00),
('Steve', 25, 'Kota', 123000.33)

--4. Display the Name for the customer from above customer table  
--who live in same address which has character o anywhere in address
select c.name from Customer c where address in (select address from Customer) and address like '%o%'


create table Orders (
  o_id int primary key,
  date datetime,
  customer_id int,
  amount int
)

create table Employee (
  id int primary key,
  name varchar(25),
  age int,
  address varchar(25),
  salary float
)

select * from Employee
truncate table Employee

insert into Employee values
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP', null),
(7, 'Muffy', 24, 'Indore', null)

--5. Write a query to display the   Date,Total no of customer  placed order on same Date
select date, count(distinct customer_id) as total_customers_placed_order
from Orders
group by date

--6. Display the Names of the Employee in lower case, whose salary is null
select lower(name) as lower_case_name
from Employee where salary is null


create table Studentdetails (
  RegisterNo int primary key,
  Name varchar(50),
  Age int ,
  Qualification varchar(50),
  MobileNo varchar(15),
  Mail_id varchar(50),
  Location varchar(50),
  Gender varchar(10)
)

insert into Studentdetails values
(1, 'Sai', 22, 'B.E', '9952836777', 'Sai@gmail.com', 'Chennai', 'M'),
(2, 'Kumar', 20, 'BSC', '7890125648', 'Kumar@gmail.com', 'Madurai', 'M'),
(3, 'Selvi', 22, 'B.Tech', '8904567342', 'selvi@gmail.com', 'Selam', 'F'),
(4, 'Nisha', 25, 'Μ.Ε', '7834672310', 'Nisha@gmail.com', 'Theni', 'F'),
(5, 'SaiSaran', 21, 'B.A', '7890345678', 'saran@gmail.com', 'Madurai', 'F'),
(6, 'Tom', 23, 'BCA', '8901234675', 'Tom@gmail.com', 'Pune', 'M')

select gender, count(*) as total_count
from Studentdetails
group by gender
