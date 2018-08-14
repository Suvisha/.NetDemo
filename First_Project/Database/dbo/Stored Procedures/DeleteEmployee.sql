CREATE PROCEDURE [dbo].[DeleteData](
       @EmployeeId int
)
AS
BEGIN
       Delete from Employee
       where EmployeeId = @EmployeeID  
END 
