use Corporate

create or alter proc GeneratePayslip @empID int
as
begin
    declare @salary float
    declare @hra float
    declare @da float
    declare @pf float
    declare @it float
    declare @deductions float
    declare @grossSalary float
    declare @netSalary float

    -- Fetch salary for the given employee
    select @salary = salary from Emp where Empno = @empId

    -- Calculate HRA, DA, PF, IT
    set @hra = @salary * 0.10
    set @da = @salary * 0.20
    set @pf = @salary * 0.08
    set @it = @salary * 0.05

    -- Calculate deductions
    set @deductions = @pf + @it

    -- Calculate gross salary
    set @grossSalary = @salary + @hra + @da

    -- Calculate net salary
    set @netSalary = @grossSalary - @deductions

    -- Display payslip
    select 
        @empID as employeeID,
        @salary as basicSalary,
        @hra as hra,
        @da as da,
        @pf as pf,
        @it as it,
        @deductions as deductions,
        @grossSalary as grossSalary,
        @netSalary as netSalary

end

select * from Emp

exec GeneratePaySlip 7369
