use Corporate

-- 1. Retrieve a list of managers.
select *
from Emp
where Job = 'MANAGER'

-- 2. Find out the names and salaries of all employees earning more than 1000 per month.
select Ename, salary from Emp
where Salary > 1000

-- 3. Display the names and salaries of all employees except JAMES.
select ename, salary from emp
where Ename <> 'JAMES'

-- 4. Find out the details of employees whose names begin with ‘S’.
select * from emp
where ename like 'S%'

-- 5. Find out the names of all employees that have ‘A’ anywhere in their name.
select ename from emp
where ename like '%A%'

-- 6. Find out the names of all employees that have ‘L’ as their third character in their name.
select ename from emp
where ename like '__L%'

-- 7. Compute daily salary of JONES.
select salary / 30 as daily_salary_Jones from emp
where ename = 'JONES'

-- 8. Calculate the total monthly salary of all employees.
select sum(salary) as total_monthly_salary from emp

-- 9. Print the average annual salary.
select avg(salary) * 12 as average_annual_salary from emp

-- 10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30.
select ename, job, salary, deptno from emp
where deptno = 30 and job <> 'SALESMAN'

-- 11. List unique departments of the emp table.
select distinct deptno from emp

-- 12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ename as Employee_Name, salary as Monthly_Salary from emp
where salary > 1500 and (deptno = 10 or deptno = 30)

-- 13. Display the name, job, and salary of all the employees whose job is manager or analyst and their salary is not equal to 1000, 3000, or 5000.
select ename, job, salary from emp
where (job = 'MANAGER' or job = 'ANALYST') and salary not in (1000, 3000, 5000)

-- 14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%.
--select ename, salary, commission from emp
--where commission > salary * 1.1

-- 15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
select ename from emp
where (ename like '%L%L%' and deptno = 30) or mgr_id = 7782

-- 16. Display the names of employees with experience of over 30 years and under 40 yrs. Count the total number of employees.
select ename from emp
where datediff(year, Hiredate, getdate()) between 30 and 40

-- To count the total number of employees in the above query:
select count(*) as total_employees from emp
where datediff(year, Hiredate, getdate()) between 30 and 40

-- 17. Retrieve the names of departments in ascending order and their employees in descending order.
select deptno, ename from emp
order by deptno asc, ename desc

-- 18. Find out experience of MILLER.
select datediff(year, Hiredate, getdate()) as Experience from emp
where ename = 'MILLER'
