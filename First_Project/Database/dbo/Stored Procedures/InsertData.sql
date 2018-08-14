CREATE Procedure [dbo].[InsertData]
 
(
       @EmployeeName varchar(50),
       @EmployeeTypeId int,
       @Department varchar(50),
       @HourlyPay int,
       @BonusRate int
)
AS
Begin
       Insert Into Employee(EmployeeName,EmployeetypeId,Department,HourlyPay,BonusRate)
       values (@EmployeeName,@EmployeeTypeId,@Department,@HourlyPay,@BonusRate)
End 
