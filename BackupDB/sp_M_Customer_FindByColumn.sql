

ALTER procedure  [dbo].[sp_M_Customer_FindByColumn](
@CustomerName nvarchar(50)=''
)
as
SELECT 
       ROW_NUMBER() OVER (ORDER BY c.[CustomerNo]) [No]
      ,c.[CustomerOID]
      ,c.[CustomerNo]
      ,c.[CustomerID]
      ,c.[RegBusinessName]
      ,c.[RegBusinessNameTH]
      ,c.[CustomerName]
      ,c.[JuristicIDNo]
      ,convert(nvarchar(10),convert(datetime,c.[RegisterDate]),103)[RegisterDate]
      ,c.[PrimaryBusinessTypeCode]
      ,c.[CREATE_BY]
      ,c.[CREATE_DATE]
      ,c.[UPDATE_BY]
      ,c.[UPDATE_DATE]
      ,c.[ROW_STATE]
      ,c.[SourceFile_MappingDetailID]
      ,c.[ImportID]
      ,d.SourceFileRefName SourceFile_MappingDetailName
            into #tempCustomer
FROM [M_Customer] c 
   join SourceFile_MappingDetail d 
		on c.SourceFile_MappingDetailID=d.DID
    where c.CustomerName like '%'+@CustomerName+'%' or @CustomerName=''
order by d.SourceFileRefName


select * from #tempCustomer

SELECT 
	a.[CustomerOID],
	a.[AccountNumber],
	a.[CurrencyCode],
	a.[AccountType],
	a.[SourceBankBranch],
	a.[CREATE_BY],
	a.[CREATE_DATE],
	a.[UPDATE_BY],
	a.[UPDATE_DATE],
	a.[ROW_STATE],
	a.[ImportID]
FROM [M_Customer_Account] a
inner join #tempCustomer b
on a.CustomerOID=b.CustomerOID
 
SELECT 
	a.[AddressOID],
	a.[CustomerKYCID],
	a.[CustomerOID],
	a.[PrincipleAddress],
	a.[City],
	a.[State],
	a.[Zipcode],
	a.[Country],
	a.[ContactNumber],
	a.[CREATE_BY],
	a.[CREATE_DATE],
	a.[UPDATE_BY],
	a.[UPDATE_DATE],
	a.[ROW_STATE],
	a.[ImportID]
FROM M_Customer_Address a
inner join #tempCustomer b
on a.[CustomerOID]=b.CustomerOID




        
      