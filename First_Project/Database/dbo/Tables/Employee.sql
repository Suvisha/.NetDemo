CREATE TABLE [dbo].[Employee] (
    [EmployeeId]     INT           IDENTITY (1, 1) NOT NULL,
    [EmployeeName]   VARCHAR (100) NOT NULL,
    [Department]     VARCHAR (100) NULL,
    [HourlyPay]      INT           NULL,
    [BonusRate]      INT           NULL,
    [EmployeeTypeId] INT           NOT NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([EmployeeId] ASC),
    CONSTRAINT [FK_Employees_Employee] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([EmployeeId])
);

