

ALTER PROCEDURE [dbo].[sp_M_Customer_FindAccountAndAddress] (
	@CustomerOID varchar(50)
) AS 

SELECT 
    CustomerAccOID,
	[CustomerOID],
	[AccountNumber],
	[CurrencyCode],
	[AccountType],
	[SourceBankBranch],
	[CREATE_BY],
	[CREATE_DATE],
	[UPDATE_BY],
	[UPDATE_DATE],
	[ROW_STATE],
	[ImportID]
FROM [M_Customer_Account]
WHERE 
	[CustomerOID] = @CustomerOID
  
SELECT 
	[AddressOID],
	[CustomerKYCID],
	[CustomerOID],
	[PrincipleAddress],
	[City],
	[State],
	[Zipcode],
	[Country],
	[ContactNumber],
	[CREATE_BY],
	[CREATE_DATE],
	[UPDATE_BY],
	[UPDATE_DATE],
	[ROW_STATE],
	[ImportID]
FROM M_Customer_Address 
WHERE [CustomerOID] = @CustomerOID
