
ALTER PROCEDURE [dbo].[sp_M_Customer_Update] (
	@CustomerOID [nvarchar](50),
	@CustomerID [nvarchar](50),
	@CustomerNo [nvarchar](6),
	@RegBusinessName [nvarchar](100) ,
	@RegBusinessNameTH [nvarchar](100) ,
	@CustomerName [nvarchar](200) ,
	@JuristicIDNo [nvarchar](50),
	@RegisterDate [nvarchar](10) ,
	@PrimaryBusinessTypeCode [nvarchar](50) ,
	@UPDATE_BY [varchar](50) 
) AS 
UPDATE [dbo].[M_Customer] 
SET 
	[CustomerID] = @CustomerID,
	[CustomerNo] = @CustomerNo,
	[RegBusinessName] = @RegBusinessName,
	[RegBusinessNameTH] = @RegBusinessNameTH,
	[CustomerName] = @CustomerName,
	[JuristicIDNo] = @JuristicIDNo,
	[RegisterDate] = @RegisterDate,
	[PrimaryBusinessTypeCode] = @PrimaryBusinessTypeCode,
	[UPDATE_BY] = @UPDATE_BY,
	[UPDATE_DATE] = getdate()
WHERE 
	[CustomerOID] = @CustomerOID
