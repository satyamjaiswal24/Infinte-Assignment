
use Corporate
select * from Emp
--1.	Write a T-SQL Program to find the factorial of a given number.

begin 
	declare @n int = 5
	declare @fact int =1

	print 'Factorial of '+cast(@n as varchar(10))+' is: '
	while @n >		0
		begin
			set @fact = @fact * @n
			set @n -= 1
		end
	print cast(@fact as varchar(10))
end

--2.	Create a stored procedure to generate multiplication tables up to a given number.

create or alter proc multiplication_table(@num int)
as 
begin
  declare @n int = 1
  declare @res int

  while @n <= @num
	begin
		declare @i int =1
		print 'Multiplication Table of '+ cast(@i as varchar(5))
		while @i <= 10
			begin
				set @res = @n * @i
				print cast(@n as varchar(5)) + ' x '+ cast(@i as varchar(5)) + ' = '+cast(@res as varchar(5))
				set @i +=1
			end
		set @n += 1
	end
end

exec multiplication_table 5

--3.  Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc
--Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation 

create table holiday (
    holiday_date date,
    Holiday_name varchar(25)
)

insert into holiday values
('2024-03-25','Holi'),
('2024-08-15','Independance Day'),
('2024-10-29','Deepawali'),
('2024-12-25','Christmas')

select * from holiday

create or alter trigger trigger_manupulation

