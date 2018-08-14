CREATE PROCEDURE [dbo].[DeleteEmployee](
       @EmployeeId int
)
AS
BEGIN
       Delete from Employee
       where EmployeeId = @EmployeeID  
END 
