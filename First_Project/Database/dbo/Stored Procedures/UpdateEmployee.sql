CREATE PROCEDURE [dbo].[UpdateEmployee](
       @EmployeeId int,
       @EmployeeName varchar(50),
       @EmployeeTypeId int,
       @Department varchar(50),
       @HourlyPay int,
       @BonusRate int
)
AS
BEGIN
       update Employee Set EmployeeName=@EmployeeName,
                 EmployeetypeId = @EmployeeTypeId,
                 Department=@Department,
                 HourlyPay=@HourlyPay,
                 BonusRate = @BonusRate
       where EmployeeId = @EmployeeId
END 

