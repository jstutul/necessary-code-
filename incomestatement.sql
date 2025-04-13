DECLARE @BranchId INT=1,@TTP INT=1094,@ACCCODE VARCHAR(40)='I10-003-008'

WHILE @BranchId <= 9
BEGIN

	--INSERT INTO [dbo].[TradeTransactionWithAccountingMapping_New] ([BrokerBranchId], [OtherBranchId], [MarketId], [TransactionMode], [TransactionTypeId], [TransactionTypeName], [AccIdDr], [AccMasterIdDr], [AccCodeDr], [NarrationDr], [AccIdCr], [AccMasterIdCr], [AccCodeCr], [NarrationCr], [IsAutoVoucher], [IsValid], [ValidFrom], [ValidTo], [GroupableDr], [GroupableCr])

	SELECT M.BrokerBranchId,M.OtherBranchId,M.MarketId,M.TransactionMode,TTP.Id,TTP.TransactionTypeName,
	M.AccIdDr,M.AccMasterIdDr,M.AccCodeDr,M.NarrationDr,
	ACC.AccID AccIdCr,ACC.AccMasterId AccMasterIdCr,ACC.AccCode AccCodeCr,ACC.AccName NarrationCr,
	M.IsAutoVoucher,M.IsValid,M.ValidFrom,M.ValidTo,M.GroupableDr,M.GroupableCr
	FROM [dbo].[TradeTransactionWithAccountingMapping_New] M
	CROSS APPLY (SELECT *  FROM TradeTransactionType  WHERE Id = @TTP) TTP
	CROSS APPLY (SELECT * FROM AccChart AC WHERE AC.BrokerBranchId=@BranchId AND AC.AccCode=@ACCCODE) ACC
	WHERE M.TransactionTypeId=15 AND M.BrokerBranchId=@BranchId AND M.TransactionMode=1 
	UNION ALL
	SELECT M.BrokerBranchId,M.OtherBranchId,M.MarketId,M.TransactionMode,TTP.Id,TTP.TransactionTypeName,
	ACC.AccID AccIdDr,ACC.AccMasterId AccMasterIdDr,ACC.AccCode AccCodeDr,ACC.AccName NarrationDr,
	M.AccIdCr,M.AccMasterIdCr,M.AccCodeCr,M.NarrationCr,
	M.IsAutoVoucher,M.IsValid,M.ValidFrom,M.ValidTo,M.GroupableDr,M.GroupableCr
	FROM [dbo].[TradeTransactionWithAccountingMapping_New] M
	CROSS APPLY (SELECT *  FROM TradeTransactionType  WHERE Id = @TTP) TTP
	CROSS APPLY (SELECT * FROM AccChart AC WHERE AC.BrokerBranchId=@BranchId AND AC.AccCode=@ACCCODE) ACC
	WHERE M.TransactionTypeId=15 AND M.BrokerBranchId=@BranchId AND M.TransactionMode=0

	 SET @BranchId = @BranchId + 1;
END


