CREATE TRIGGER TRG_DepositRequest_Notification
ON DepositRequest
AFTER INSERT
AS
BEGIN
    INSERT INTO Notification (TypeName, Message, EntryTime)
    SELECT 
        'DepositRequest',
        i.InvestorName + ' ' +
        i.InvestorCode + 
        ' Deposit Tk.' + CAST(i.DepositRequestAmount AS VARCHAR(50)) +
        ' By ' + i.DepositMode,
        CAST(GETDATE() AS DATE)
    FROM inserted i;
END
GO

CREATE TRIGGER TRG_WithdrawRequest_Notification
ON WithdrawRequest
AFTER INSERT
AS
BEGIN
    INSERT INTO Notification (TypeName, Message, EntryTime)
    SELECT 
        'WithdrawRequest',
        i.InvestorName + ' ' +
        i.InvestorCode +
        ' Withdraw Tk.' + CAST(i.WithdrawRequestAmount AS VARCHAR(50)) +
        ' By ' + i.WithdrawRequestMode,
        CAST(GETDATE() AS DATE)
    FROM inserted i;
END
GO


CREATE TRIGGER TRG_BuySaleOrderRequest_Notification
ON BuySaleOrderRequest
AFTER INSERT
AS
BEGIN
    INSERT INTO Notification (TypeName, Message, EntryTime)
    SELECT 
        'BuySaleOrderRequest',
        i.InvestorCode + ' ' +
        i.TransactionType + ' ' +
        CAST(i.Quantity AS VARCHAR(20)) + ' shares of ' +
        i.CompanyCode + ' @ Tk.' + CAST(i.OrderRate AS VARCHAR(50)),
        CAST(GETDATE() AS DATE)
    FROM inserted i;
END
GO
