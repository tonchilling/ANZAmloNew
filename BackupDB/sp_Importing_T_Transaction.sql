
-- select * from Temp_Incoming where instrumentID='180913008477004'
-- select * from T_Transaction
-- delete from T_Transaction
--[sp_Importing_T_Transaction] '7b626112-a58d-42a2-b8a2-0bafa1b5d667','Admin'
ALTER procedure [dbo].[sp_Importing_T_Transaction](
@ImportID nvarchar(50),
@CREATE_BY nvarchar(50)
)
as

DECLARE @CURR_DATE datetime;
 
SET @CURR_DATE = GETDATE();

merge T_Transaction trn
using (select distinct   swift.ImportID TranOID,
                'Incoming' FileType,
         	   'SWIFT' as GroupName,
         	    swift.InstrumentID as CustomerInstrumentId,
				substring(swift.BeneAccountNumber,1,6)  as CustomerBankAccountNumber,
				cus.JuristicIDNo as ANZCustomerId,
				cus.CustomerName as CustRegisterName,
				cus.CustomerID as CustRegisterID,
				cus.PrimaryBusinessTypeCode as CustBusinessCode,
				SUBSTRING(ca.PrincipleAddress,1,100) as CustRegisterAddress,
					ca.Country as CustRegisterAddressCountry,
					
				case when LEN(ca.PrincipleAddress) > 100 then
						  SUBSTRING(ca.PrincipleAddress,100,100)
				else ''
				end as CustCompanyAddress,
				
				'' CustCompanyAddressCountry,
				'' CustContractAddress,
				'' CustContractAddressCountry,
				cus.RegisterDate  CustRegisterDate,
				'' TransactionMethod,
				swift.TransactionDate  TransactionDate,
					case when swift.CurrecyCode <> 'THB' then 
						CAST((REPLACE(swift.CurrAmount, ',', '.')) as decimal(18,2)) *
						(select top 1 
							case when TelexTransfer is null then 1
								 when TelexTransfer = 'N/A' then 1
								 else CAST(TelexTransfer as decimal(18,2))
							end
						 from Temp_Counterrate 
						 where Currency = swift.CurrecyCode and ImportID = swift.ImportID)
					 else CAST((REPLACE(swift.CurrAmount, ',', '.')) as decimal(18,2))
				end as  TranxAmountThb,
				CAST((REPLACE(swift.CurrAmount, ',', '.')) as decimal(18,2))  TranxAmountCurrency,
				swift.CurrecyCode TranxCurrency,
				CAST((REPLACE(swift.CurrAmount, ',', '.')) as decimal(18,2)) as value,				
				swift.CurrecyCode as curr,
				case when swift.CurrecyCode <> 'THB' then 
						(select top 1 TelexTransfer
						 from Temp_Counterrate 
						 where Currency = swift.CurrecyCode and ImportID = swift.ImportID)
					 else '1'
				end as  TranxExchangeRate,
				'' TranxAmountThbInThWord,
				'' TranxInternationalOrDomestic,
				'' TranxSendReceive,
				 '' TranxObjective,
				'' SendTranxRefNo,
				cus.CustomerName SendBankName,
				'TH' SendBankCountry,
				swift.BeneAccountNumber SendBankAccountNo,
				'' SendName,
				'' SendAddress,
				'' SendIdType,
				'' SendIdDescription,
				'' SendIdNo,
				'' SendIdIssueBy,
				swift.BeneAccountNumber BeneBankAccountNo,
				'' BeneTranxRefNo,
				swift.BeneBankName BeneBankName,
				'' BeneBankCountry,
				'' BeneName,
				swift.BeneAddress3 BeneAddress,
				'' BeneIdType,
				'TH' BeneIdDescription,
				swift.BeneAccountNumber  BeneIdNo,
				'' BeneIdIssueBy,
				'' Remark,
				'' MappingSourceDB,
				@CREATE_BY CREATE_BY,
				getdate() CREATE_DATE,
				'' UPDATE_BY,
				getdate() UPDATE_DATE,
				'1' ROW_STATE,
				'1' Active
	
		from (select
		[ImportID]
      ,[TransactionCode]
      ,[InstrumentID]
      ,[TransactionDate]
      ,[CurrecyCode]
      ,[CurrAmount]
      ,[PayerName]
      ,[ANZAccountNo]
      ,[PayerAddress1]
      ,[PayerAddress2]
      ,[PayerAddress3]
      ,[PayerBankName]
      ,[BeneBankName]
      ,[BeneBankAddress1]
      ,[BeneBankAddress2]
      ,[BeneBankAddress3]
      ,[BeneAccountNumber]
      ,[BeneName]
      ,[BeneAddress1]
      ,[BeneAddress2]
      ,[BeneAddress3]
      ,[PuposeDescription1]
      ,[PuposeDescription2]
      ,[PuposeDescription3]
		 from Temp_Incoming group by
		 [ImportID]
      ,[TransactionCode]
      ,[InstrumentID]
      ,[TransactionDate]
      ,[CurrecyCode]
      ,[CurrAmount]
      ,[PayerName]
      ,[ANZAccountNo]
      ,[PayerAddress1]
      ,[PayerAddress2]
      ,[PayerAddress3]
      ,[PayerBankName]
      ,[BeneBankName]
      ,[BeneBankAddress1]
      ,[BeneBankAddress2]
      ,[BeneBankAddress3]
      ,[BeneAccountNumber]
      ,[BeneName]
      ,[BeneAddress1]
      ,[BeneAddress2]
      ,[BeneAddress3]
      ,[PuposeDescription1]
      ,[PuposeDescription2]
      ,[PuposeDescription3]
		 ) swift
			join M_Customer cus on SUBSTRING(swift.BeneAccountNumber,1,6) = cus.CustomerNo
			join M_Customer_Address ca on ca.CustomerOID = cus.CustomerOID
		where swift.ImportID = @ImportID) tmp
on trn.ANZCustomerId = tmp.ANZCustomerId
when matched then
	update set
		
         --    FileType= tmp.FileType,
         --	 GroupName=tmp.GroupName,
         	 CustomerInstrumentId=tmp.CustomerInstrumentId,
			CustomerBankAccountNumber=substring(tmp.CustomerBankAccountNumber,1,6),
			ANZCustomerId =tmp.ANZCustomerId,
		--	CustRegisterName=tmp.CustRegisterName,
			CustRegisterID=tmp.CustRegisterID,
			CustBusinessCode=tmp.CustBusinessCode,
			CustRegisterAddress = tmp.CustRegisterAddress,
			CustRegisterAddressCountry= tmp.CustRegisterAddressCountry,
			CustCompanyAddress = tmp.CustCompanyAddress,
				CustCompanyAddressCountry = tmp.CustCompanyAddressCountry,
			CustContractAddress=tmp.CustContractAddress,
			CustContractAddressCountry =tmp.CustContractAddressCountry,
			CustRegisterDate = tmp.CustRegisterDate,
			TransactionMethod =tmp.TransactionMethod,
			TransactionDate = tmp.TransactionDate,
			TranxAmountThb= tmp.TranxAmountThb,
			TranxAmountCurrency = tmp.TranxAmountCurrency,
			TranxCurrency =  tmp.TranxCurrency,
			TranxExchangeRate = tmp.TranxExchangeRate,
			TranxAmountThbInThWord = tmp.TranxAmountThbInThWord,
			TranxInternationalOrDomestic =tmp.TranxInternationalOrDomestic,
			TranxSendReceive = tmp.TranxSendReceive,
			TranxObjective =tmp.TranxObjective,
			SendTranxRefNo =tmp.SendTranxRefNo,
			SendBankName=tmp.SendBankName,
			SendBankCountry =tmp.SendBankCountry,
			SendBankAccountNo =tmp.SendBankAccountNo,
			SendName =tmp.SendName,
			SendAddress =tmp.SendAddress,
			SendIdType=tmp.SendIdType,
			SendIdDescription =tmp.SendIdDescription,
			SendIdNo =tmp.SendIdNo,
			SendIdIssueBy =tmp.SendIdIssueBy,
			BeneBankAccountNo= tmp.BeneBankAccountNo,
			BeneTranxRefNo =tmp.BeneTranxRefNo,
			BeneBankName =tmp.BeneBankName,
			BeneBankCountry =tmp.BeneBankCountry,
			BeneName=tmp.BeneName,
			BeneAddress = tmp.BeneAddress,
			BeneIdType =tmp.BeneIdType,
			BeneIdDescription=tmp.BeneIdDescription,
			BeneIdNo=tmp.BeneIdNo,
			BeneIdIssueBy=tmp.BeneIdIssueBy,
			Remark=tmp.Remark,
			MappingSourceDB=tmp.MappingSourceDB,
           UPDATE_DATE =getdate()

when not matched then
	insert(
		TranOID,
         FileType,
         GroupName,
         CustomerInstrumentId,
		CustomerBankAccountNumber,
		ANZCustomerId,
		CustRegisterName,
		CustRegisterID,
		CustBusinessCode,
		CustRegisterAddress,
		CustRegisterAddressCountry,
		CustCompanyAddress,
		CustCompanyAddressCountry,
		CustContractAddress,
		CustContractAddressCountry,
		CustRegisterDate,
		TransactionMethod,
		TransactionDate,
		TranxAmountThb,
		TranxAmountCurrency,
		TranxCurrency,
		TranxExchangeRate,
		TranxAmountThbInThWord,
		TranxInternationalOrDomestic,
		TranxSendReceive,
		TranxObjective,
		SendTranxRefNo,
		SendBankName,
		SendBankCountry,
	     SendBankAccountNo,
		SendName,
		SendAddress,
		SendIdType,
		SendIdDescription,
		SendIdNo,
		SendIdIssueBy,
		BeneBankAccountNo,
		BeneTranxRefNo,
		BeneBankName,
		BeneBankCountry,
		BeneName,
		BeneAddress,
		BeneIdType,
		BeneIdDescription,
		BeneIdNo,
		BeneIdIssueBy,
		Remark,
		MappingSourceDB,
		CREATE_BY,
		CREATE_DATE,
		 UPDATE_BY,
		UPDATE_DATE,
		ROW_STATE,
		Active
	)
	values(
		NEWID(),
         tmp.FileType,
         tmp.GroupName,
         tmp.CustomerInstrumentId,
		substring(tmp.CustomerBankAccountNumber,1,6),
		tmp.ANZCustomerId,
		tmp.CustRegisterName,
		tmp.CustRegisterID,
		tmp.CustBusinessCode,
		tmp.CustRegisterAddress,
		tmp.CustRegisterAddressCountry,
		tmp.CustCompanyAddress,
		tmp.CustCompanyAddressCountry,
		tmp.CustContractAddress,
		tmp.CustContractAddressCountry,
		tmp.CustRegisterDate,
		tmp.TransactionMethod,
		tmp.TransactionDate,
		tmp.TranxAmountThb,
		tmp.TranxAmountCurrency,
		tmp.TranxCurrency,
		tmp.TranxExchangeRate,
		tmp.TranxAmountThbInThWord,
		tmp.TranxInternationalOrDomestic,
		tmp.TranxSendReceive,
		tmp.TranxObjective,
		tmp.SendTranxRefNo,
		tmp.SendBankName,
		tmp.SendBankCountry,
	     tmp.SendBankAccountNo,
		tmp.SendName,
		tmp.SendAddress,
		tmp.SendIdType,
		tmp.SendIdDescription,
		tmp.SendIdNo,
		tmp.SendIdIssueBy,
		tmp.BeneBankAccountNo,
		tmp.BeneTranxRefNo,
		tmp.BeneBankName,
		tmp.BeneBankCountry,
		tmp.BeneName,
		tmp.BeneAddress,
		tmp.BeneIdType,
		tmp.BeneIdDescription,
		tmp.BeneIdNo,
		tmp.BeneIdIssueBy,
		tmp.Remark,
		tmp.MappingSourceDB,
		tmp.CREATE_BY,
		tmp.CREATE_DATE,
		 tmp.UPDATE_BY,
		tmp.UPDATE_DATE,
		tmp.ROW_STATE,
		tmp.Active
	);

	
SET ANSI_NULLS ON
