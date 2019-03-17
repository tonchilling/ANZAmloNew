DROP TABLE [dbo].[M_Customer_Account]


CREATE TABLE [dbo].[M_Customer_Account](
	[CustomerAccOID] [nvarchar](50) NOT NULL,
	[CustomerOID] [nvarchar](50) NOT NULL,
	[AccountNumber] [nvarchar](50) NOT NULL,
	[CurrencyCode] [nvarchar](50) NULL,
	[AccountType] [nvarchar](50) NULL,
	[SourceBankBranch] [nvarchar](50) NULL,
	[CREATE_BY] [varchar](50) NULL,
	[CREATE_DATE] [datetime] NULL,
	[UPDATE_BY] [varchar](50) NULL,
	[UPDATE_DATE] [datetime] NULL,
	[ROW_STATE] [nchar](10) NULL,
	[ImportID] [nvarchar](50) NULL,
 CONSTRAINT [PK_M_Customer_Account] PRIMARY KEY CLUSTERED 
(
	[CustomerAccOID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_M_Customer_Update]    Script Date: 03/17/2019 18:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_M_Customer_Update] (
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
GO
/****** Object:  StoredProcedure [dbo].[sp_M_Customer_Address_Update]    Script Date: 03/17/2019 18:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_M_Customer_Address_Update] (
	@AddressOID nvarchar(50),
	@CustomerKYCID varchar(50),
	@CustomerOID nvarchar(50),
	@PrincipleAddress varchar(50),
	@City varchar(50),
	@State varchar(50),
	@Zipcode varchar(50),
	@Country varchar(50),
	@ContactNumber varchar(50),
	@UPDATE_BY varchar(50)
) AS 
UPDATE [dbo].[M_Customer_Address] 
SET 
	[CustomerKYCID] = @CustomerKYCID,
	[CustomerOID] = @CustomerOID,
	[PrincipleAddress] = @PrincipleAddress,
	[City] = @City,
	[State] = @State,
	[Zipcode] = @Zipcode,
	[Country] = @Country,
	[ContactNumber] = @ContactNumber,
	[UPDATE_BY] = @UPDATE_BY,
	[UPDATE_DATE] = getdate()
WHERE 
	[AddressOID] = @AddressOID
GO
/****** Object:  StoredProcedure [dbo].[sp_M_Customer_Account_Update]    Script Date: 03/17/2019 18:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_M_Customer_Account_Update] (
	@CustomerAccOID nvarchar(50),
	@CustomerOID nvarchar(50),
	@AccountNumber nvarchar(50),
	@CurrencyCode nvarchar(50),
	@AccountType nvarchar(50),
	@SourceBankBranch nvarchar(50),
	@UPDATE_BY varchar(50)
) AS 
UPDATE [dbo].[M_Customer_Account] 
SET 
	[AccountNumber] = @AccountNumber,
	[CurrencyCode] = @CurrencyCode,
	[AccountType] = @AccountType,
	[SourceBankBranch] = @SourceBankBranch,
	[UPDATE_BY] = @UPDATE_BY,
	[UPDATE_DATE] = getdate()
WHERE 
	[CustomerAccOID] = @CustomerAccOID
GO
/****** Object:  StoredProcedure [dbo].[sp_Importing_TempToCustomer]    Script Date: 03/17/2019 18:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- select * from Temp_Customer_Account_Numbers
--sp_Importing_TempToCustomer '7b626112-a58d-42a2-b8a2-0bafa1b5d667','Admin'
alter procedure [dbo].[sp_Importing_TempToCustomer](
@ImportID nvarchar(50),
@CREATE_BY nvarchar(50)
)
as

DECLARE @CURR_DATE datetime;
 
SET @CURR_DATE = GETDATE();

merge [M_Customer] cust
using (select distinct
			cust.CustomerId, 
			ipi.CustNo,
			ipi.RegisteredBusinessName,
			ipi.RegisteredBusinessNameThai,
			ipi.CNAME,
			ipi.JuristicIdentificationNumber,
			ipi.JuristicRegisteredDate,
			ipi.PrimaryBusinessType,
			@CREATE_BY as CREATE_BY,
			@CURR_DATE as CURR_DATE,
			'1' as ROW_STATE,
			'1' as SourceFile_MappingDetailID,	
			@ImportID as ImportID
		from Temp_Customer_Account_Numbers cust
			join Temp_IPI ipi 
				on cust.AccountNumber is not null and SUBSTRING(cust.AccountNumber,1,6) = ipi.CustNo
		where cust.ImportID = @ImportID) tmp
on cust.CustomerId = tmp.CustomerId
when matched then
	update set
		[CustomerNo] = tmp.CustNo,
		[RegBusinessName] = tmp.RegisteredBusinessName,
		[RegBusinessNameTH] = tmp.RegisteredBusinessNameThai,
		[CustomerName] = tmp.CNAME,
		[JuristicIDNo] = tmp.JuristicIdentificationNumber,
		[RegisterDate] = tmp.JuristicRegisteredDate,
		[PrimaryBusinessTypeCode] = tmp.PrimaryBusinessType,
		[ROW_STATE] = tmp.ROW_STATE,
		[SourceFile_MappingDetailID] = tmp.SourceFile_MappingDetailID,
		[ImportID] = tmp.ImportID,
		[UPDATE_BY] = tmp.CREATE_BY,
		[UPDATE_DATE] = tmp.CURR_DATE
when not matched then
	insert(
		[CustomerOID],
		[CustomerID],
		[CustomerNo],
		[RegBusinessName],
		[RegBusinessNameTH],
		[CustomerName],
		[JuristicIDNo],
		[RegisterDate],
		[PrimaryBusinessTypeCode],
		[CREATE_BY],
		[CREATE_DATE],
		[ROW_STATE],
		[SourceFile_MappingDetailID],
		[ImportID]
	)
	values(
		NEWID(),
		tmp.CustomerId, 
		tmp.CustNo,
		tmp.RegisteredBusinessName,
		tmp.RegisteredBusinessNameThai,
		tmp.CNAME,
		tmp.JuristicIdentificationNumber,
		tmp.JuristicRegisteredDate,
		tmp.PrimaryBusinessType,
		tmp.CREATE_BY,
		tmp.CURR_DATE,
		tmp.ROW_STATE,
		tmp.SourceFile_MappingDetailID,	
		tmp.ImportID
	);

merge [M_Customer_Account] acc
using ( select distinct
			cust.CustomerOID,
			tmpCust.AccountNumber,
			tmpCust.AcctNumberCurrCode,
			tmpCust.AccountType,
			tmpCust.SourceBankBranch,
			@CREATE_BY as CREATE_BY,
			@CURR_DATE as CURR_DATE,
			'1' as ROW_STATE,
			@ImportID as ImportID
		from M_Customer cust
			join Temp_Customer_Account_Numbers tmpCust 
				on cust.CustomerID is not null and len(cust.CustomerID) > 0 and cust.CustomerID = tmpCust.CustomerId
		where cust.ImportID = @ImportID) tmp
on acc.CustomerOID = tmp.CustomerOID and acc.AccountNumber = tmp.AccountNumber
when matched then
	update set
		[CurrencyCode] = tmp.AcctNumberCurrCode,
		[AccountType] = tmp.AccountType,
		[SourceBankBranch] = tmp.SourceBankBranch,
		[UPDATE_BY] = tmp.CREATE_BY,
		[UPDATE_DATE] = tmp.CURR_DATE,
		[ROW_STATE] = tmp.ROW_STATE,
		[ImportID] = tmp.ImportID
when not matched then
	insert (
		[CustomerAccOID],
		[CustomerOID],
		[AccountNumber],
		[CurrencyCode],
		[AccountType],
		[SourceBankBranch],
		[CREATE_BY],
		[CREATE_DATE],
		[ROW_STATE]
	)
	values(
		NEWID(),
		tmp.CustomerOID,
		tmp.AccountNumber,
		tmp.AcctNumberCurrCode,
		tmp.AccountType,
		tmp.SourceBankBranch,
		tmp.CREATE_BY,
		tmp.CURR_DATE,
		tmp.ROW_STATE
	);
	
	--delete from [M_Customer_Address]
	-- select * from Temp_DATA_EXT
merge [M_Customer_Address] addr
using ( select distinct
			ext.CustomerID,
			cust.CustomerOID,
			ext.PrincipleAddress,
			ext.City,
			ext.State,
			ext.Zipcode,
			ext.Country,
			ext.ContactNumber,
			@CREATE_BY as CREATE_BY,
			@CURR_DATE as CURR_DATE,
			'1' as ROW_STATE,
			@ImportID as ImportID		
		from M_Customer cust
			join Temp_DATA_EXT ext 
				on cust.JuristicIDNo is not null and len(cust.JuristicIDNo) > 0 and cust.JuristicIDNo = ext.UniqueIdentifier
		where cust.ImportID = @ImportID) tmp
on addr.CustomerOID = tmp.CustomerOID 
	and addr.CustomerKYCID= tmp.CustomerID
	and addr.ContactNumber = tmp.ContactNumber
when matched then
	update set
		[PrincipleAddress] = tmp.[PrincipleAddress],
		[City] = tmp.[City],
		[State] = tmp.[State],
		[Zipcode] = tmp.[Zipcode],
		[Country] = tmp.[Country],
		[ContactNumber] = tmp.[ContactNumber],
		[UPDATE_BY] = tmp.[CREATE_BY],
		[UPDATE_DATE] = tmp.[CURR_DATE],
		[ROW_STATE] = tmp.[ROW_STATE],
		[ImportID] = tmp.[ImportID]
when not matched then
	insert(
		[AddressOID],
		CustomerKYCID,
		[CustomerOID],
		[PrincipleAddress],
		[City],
		[State],
		[Zipcode],
		[Country],
		[ContactNumber],
		[CREATE_BY],
		[CREATE_DATE],
		[ROW_STATE],
		[ImportID]
	)
	values(
		NEWID() , 
		tmp.CustomerID,
		tmp.CustomerOID,
		tmp.PrincipleAddress,
		tmp.City,
		tmp.State,
		tmp.Zipcode,
		tmp.Country,
		tmp.ContactNumber,
		tmp.CREATE_BY,
		tmp.CURR_DATE,
		tmp.ROW_STATE,
		tmp.ImportID
	);
GO
