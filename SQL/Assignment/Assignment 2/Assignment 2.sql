--Creating Corporate Database 
create database Corporate

use Corporate
--Creating Employee Table
create table Emp(
   Empno int primary key,
   Ename varchar(25),
   Job varchar(20),
   Mgr_id int,
   Hiredate date,
   Salary int,
   Comm int,
   Deptno int
)

--Inserting Data into Employee Table
insert into Emp values
(7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10)


--Showing Employee Data
select *from Emp


--Creating Department table
create table Dept(
   Deptno int,
   Dname varchar(20),
   Loc varchar(20)
)

--inserting data into Department table
insert into Dept values
(10, 'ACCOUNTING', 'NEW YORK'),
(20, 'RESEARCH', 'DALLAS'),
(30, 'SALES', 'CHICAGO'),
(40, 'OPERATIONS', 'BOSTON')

--1. List all employees whose name begins with 'A'. 
select *from Emp where Ename like 'A%'

--2. Select all those employees who don't have a manager. 
--a. if 2nd question is asking related to Employees  who don't have a manager job then answer is:
select *from Emp where Job != 'MANAGER'

--b. if 2nd question is asking related to Employees  who don't have a manager ID then answer is:
select *from Emp where Mgr_id is Null;


--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
select Empno, Ename, Salary from Emp where Salary between 1200 and 1400

--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 
update Emp set Salary = Salary * 1.1
Where Deptno = (Select Deptno from Dept where Dname = 'RESEARCH')

--5. Find the number of CLERKS employed. Give it a descriptive heading. 
Select count(*) as 'Employed Clerk' from Emp where Job = 'CLERK'

--6. Find the average salary for each job type and the number of people employed in each job. 
select Job, avg(Salary) as 'Average Salary', count(Empno) as 'Number of Employee' from Emp Group by Job

--7. List the employees with the lowest and highest salary. 
select min(Salary) as 'Lowest Salary', max(Salary) as 'Maximum Salary' from Emp

--8. List full details of departments that don't have any employees. 
select d.Deptno, d.Dname, d.Loc from Dept d Left join Emp e on d.Deptno = e.Deptno
where e.Deptno is Null

--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
select e.Ename, e.Salary from Emp e where e.Job = 'Analyst' and e.Salary > 1200 and e.Deptno = 20 
order by e.Ename asc

--10. For each department, list its name and number together with the total salary paid to employees in that department. 
select d.Dname, d.Deptno, sum(e.Salary) as 'Total Salary'
from Dept d Left join Emp e on d.Deptno = e.Deptno
group by d.Dname, d.Deptno

--11. Find out salary of both MILLER and SMITH.
select Ename, Salary from Emp where ename in ('MILLER', 'SMITH')

--12. Find out the names of the employees whose name begin with �A� or �M�. 
select Ename from Emp where Ename like '[A,M]%'

--13. Compute yearly salary of SMITH. 
select (Salary * 12) as Yearly_Salary from Emp where Ename = 'SMITH'

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select Ename , Salary from Emp where Salary not between 1500 and 2850

--15. Find all managers who have more than 2 employees reporting to them
select  Mgr_id, count(Empno) as EMP_COUNT
from Emp
group by Mgr_id
having count(Empno) > 2;
