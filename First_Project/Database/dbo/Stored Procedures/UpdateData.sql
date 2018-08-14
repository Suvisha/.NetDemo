CREATE PROCEDURE [dbo].[UpdateData](
       @EmployeeId int,
       @EmployeeName varchar(50),
       @EmployeeTypeId int,
       @Department varchar(50),
       @HourlyPay int,
       @BonuRate int
)
AS
BEGIN
       update Employee Set EmployeeName=@EmployeeName,
                 EmployeetypeId = @EmployeeTypeId,
                 Department=@Department,
                 HourlyPay=@HourlyPay,
                 BonusRate = @BonuRate
       where EmployeeId = @EmployeeId
END 

