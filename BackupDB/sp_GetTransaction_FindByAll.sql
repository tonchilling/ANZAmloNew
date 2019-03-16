

CREATE procedure [dbo].[sp_GetTransaction_FindByAll](
@FromDate nvarchar(10)=''
)
as

select
ROW_NUMBER() OVER(PARTITION BY GroupName ORDER BY GroupName ASC) colNo ,
 * from 
(
select distinct pay.GroupName GroupName,
       pay.Remark Remark,
       pay.MappingSourceDB SourceFileMappingDB,
       pay.CustomerInstrumentId ANZCustomerInstrumentId,
       substring(pay.CustomerBankAccountNumber,1,6) ANZCustomerBANKAccountNumber,
     cu.CustomerID ANZCustomerRegisterID,
     cu.RegBusinessName,
     cu.JuristicIDNo RegTAXID,
     cu.PrimaryBusinessTypeCode ANZCutomerBusinessCode,
     cu.CustomerName  ANZCutomerRegisterName,
    (select top 1 PrincipleAddress from  M_Customer_Address cc where cc.CustomerOID=cu.CustomerOID) ANZCutomerRegisterAddress,
     pay.CustRegisterAddressCountry ANZCutomerRegisterAddressCountry,
     cu.RegBusinessNameTH CompanyAddress,
      pay.CustCompanyAddressCountry CompanyAddressCountry ,
      (select top 1 PrincipleAddress from  M_Customer_Address cc where cc.CustomerOID=cu.CustomerOID)  ContactAddress,
     pay.CustContractAddressCountry ContactAddressCountry ,
     cu.RegisterDate ANZCustomerRegisterDate ,
     pay.TransactionMethod TransactionMethod,
     pay.TransactionDate TransactionDate,
    pay.TranxAmountThb TranxAmountTHB,
    pay.TranxAmountCurrency TranxAmountCurrency,
    recv.InstrumentCurrency TranxCurrency,
    pay.TranxExchangeRate TranxExchangeRate,
    pay.TranxSendReceive  TranxSendReceive,
    pay.TranxObjective TranxObjective,
    pay.SendBankAccountNo SendBankAccountNumber,
    pay.SendTranxRefNo SendTranxRefNo,
    pay.SendBankName SendBankName,
    pay.SendBankCountry SendBankCountry,
    cu.CustomerName  SendName,
    (select top 1 PrincipleAddress from  M_Customer_Address cc where cc.CustomerOID=cu.CustomerOID) SendAddress,
    pay.SendIdDescription SendDescription,
    substring(pay.SendBankAccountNo,1,6) SendIdNo,
   pay.SendIdIssueBy SendIdIssueBy,
    pay.BeneBankAccountNo BeneBankAccountNumber,
    pay.BeneTranxRefNo  BeneTranxRefNo,
    pay.BeneBankName BeneBankName,
   pay.BeneBankCountry BeneBankCountry,
    pay.BeneName BeneName,
    pay.BeneAddress BeneAddress,
    pay.BeneIdDescription BeneIdDescription,
    pay.CustomerInstrumentId BeneIdNo,
    pay.BeneIdIssueBy BeneIdIssueBy
        from  T_Transaction pay left join
               M_Customer cu on
               substring(pay.CustomerBankAccountNumber,1,6)= cu.CustomerNo left join
               [Temp_Payment_-_Op_Org_Prompt] recv on pay.CustomerInstrumentId=recv.InstrumentId
               ) a order by ANZCustomerBANKAccountNumber
               
           --    select * from M_Customer
            /*   select * from Temp_Payment_Release order by AccountNumber 
               select * from [Temp_Payment_-_Op_Org_Prompt] order by InstrumentId
               select *  from M_Customer*/
               
         --      select * from Temp_Counterrate where Currency='usd'
GO


