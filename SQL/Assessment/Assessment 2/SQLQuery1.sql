create database SQLAssessment2
use SQLAssessment2
use Corporate

--		1.Write a query to display your birthday( day of week)
		select datename(dw, '1999-07-22') AS BirthDayofWeek

--		2.Write a query to display your age in days
		select datediff(day,'1999-07-22',getdate()) as Current_Age

--		3.Write a query to display all employees information those who joined before 5 years in the current month
		select * from Emp
		where datediff(yy,hiredate,getdate()) > 5

--	  4.	Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
 --   a. First insert 3 rows 
	--b. Update the second row sal with 15% increment  
 --   c. Delete first row.
	--After completing above all actions how to recall the deleted row without losing increment of second row.
	
	
  --a. First insert 3 rows 
	create table Employee(
		empno int,
		ename varchar(20),
		sal float,
		doj date
	)

	begin transaction
		insert into Employee values
		(1,'Akash',90000, '1980-12-17'),
		(2,'Sagar', 55000,'1981-02-20'),
		(3,'Ankit', 97000,'1981-02-22')

	commit

	select * from Employee

	--b. Update the second row sal with 15% increment  
		
	  begin transaction

	  update Employee set sal = sal * 1.15
	  where empno = 2


	--c. Delete first row
	  delete from Employee where empno = 1

	  commit

	--5.   Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions
	--a.   For Deptno 10 employees 15% of sal as bonus.
	--b.   For Deptno 20 employees  20% of sal as bonus
	--c    For Others employees 5%of sal as bonus

	--creating function for calculating bonus
	  create or alter function calculate_bonus(@deptno int)
		returns int
		begin
			declare @bonus int

			if @deptno = 10
			--For Deptno 10 employees 15% of sal as bonus.
				begin
					select @bonus = (Salary * 0.15) from Emp where Deptno = @deptno
				end
			else if @deptno = 20
			-- For Deptno 20 employees  20% of sal as bonus
				begin
					select @bonus = (Salary * 0.20) from Emp where Deptno = @deptno
				end
			else
			--For Others employees 5%of sal as bonus
				begin
					select @bonus = (Salary * 0.05) from Emp where Deptno = @deptno
				end

			return @bonus
		end

select dbo.calculate_bonus(10) AS Bonus_For_Dept_10,





