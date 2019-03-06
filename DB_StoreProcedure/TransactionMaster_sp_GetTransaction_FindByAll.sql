alter procedure sp_GetTransaction_FindByAll(
@FromDate nvarchar(10)=''
)
as

 


select
ROW_NUMBER() OVER(PARTITION BY GroupName ORDER BY GroupName ASC) colNo ,
 * from 
(
select distinct 'Tranx GroupName' GroupName,
       '' Remark,
       '' SourceFileMappingDB,
       pay.InstrumentId ANZCustomerInstrumentId,
       substring(pay.AccountNumber,1,6) ANZCustomerBANKAccountNumber,
     cu.CustomerID ANZCustomerRegisterID,
     cu.RegBusinessName,
     cu.JuristicIDNo RegTAXID,
     cu.PrimaryBusinessTypeCode ANZCutomerBusinessCode,
    (select top 1 PrincipleAddress from  M_Customer_Address cc where cc.CustomerOID=cu.CustomerOID) ANZCutomerRegisterAddress,
     '' ANZCutomerRegisterAddressCountry,
     cu.RegBusinessNameTH CompanyAddress,
      '' CompanyAddressCountry ,
      (select top 1 PrincipleAddress from  M_Customer_Address cc where cc.CustomerOID=cu.CustomerOID)  ContactAddress,
     '' ContactAddressCountry ,
     cu.RegisterDate ANZCustomerRegisterDate ,
     'DOCUMENTS' TransactionMethod,
     pay.ValueDate TransactionDate,
    recv.AmountBase TranxAmountTHB,
    recv.Amount TranxAmountCurrency,
    recv.InstrumentCurrency TranxCurrency,
    pay.FXRate TranxExchangeRate,
    'SEND'  TranxSendReceive,
    'Settlement for Goods and Services.' TranxObjective,
    pay.AccountNumber SendBankAccountNumber,
    pay.InstrumentId SendTranxRefNo,
    'ANZ BANK (THAI) PCL' SendBankName,
    'Thailand' SendBankCountry,
    cu.CustomerName  SendName,
    (select top 1 PrincipleAddress from  M_Customer_Address cc where cc.CustomerOID=cu.CustomerOID) SendAddress,
    'AFFIDAVIT' SendDescription,
    substring(pay.AccountNumber,1,6) SendIdNo,
    'SendIdIssueBy' SendIdIssueBy,
    pay.BeneficiaryAccountNumber BeneBankAccountNumber,
    pay.InstrumentId  BeneTranxRefNo,
    pay.BeneficiaryBankName BeneBankName,
    '' BeneBankCountry,
    pay.BeneficiaryName BeneName,
    pay.BeneficiaryAddress1+' '+pay.BeneficiaryAddress2+' '+pay.BeneficiaryAddress3 BeneAddress,
    pay.PaymentMethodTypeDescription BeneIdDescription,
    pay.InstrumentId BeneIdNo,
    pay.BeneficiaryBankName BeneIdIssueBy
        from  Temp_Payment_Release pay left join
               M_Customer cu on
               substring(pay.AccountNumber,1,6)= cu.CustomerNo left join
               [Temp_Payment_-_Op_Org_Prompt] recv on pay.InstrumentId=recv.InstrumentId
               ) a order by ANZCustomerBANKAccountNumber
               
               
            /*   select * from Temp_Payment_Release order by AccountNumber 
               select * from [Temp_Payment_-_Op_Org_Prompt] order by InstrumentId
               select *  from M_Customer*/