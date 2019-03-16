
drop table T_Transaction

CREATE TABLE [dbo].[T_Transaction](
	[TranOID] [nvarchar](50) NULL,
	[FileType] [nvarchar](50) NULL,
	[GroupName] [nvarchar](50) NULL,
	[CustomerInstrumentId] [nvarchar](50) NULL,
	[CustomerBankAccountNumber] [nvarchar](50) NULL,
	[ANZCustomerId] [nvarchar](50) NULL,
	[CustRegisterName] [nvarchar](100) NULL,
	[CustRegisterID] [nvarchar](50) NULL,
	[CustBusinessCode] [nvarchar](50) NULL,
	[CustRegisterAddress] [nvarchar](100) NULL,
	[CustRegisterAddressCountry] [nvarchar](100) NULL,
	[CustCompanyAddress] [nvarchar](100) NULL,
	[CustCompanyAddressCountry] [nvarchar](100) NULL,
	[CustContractAddress] [nvarchar](100) NULL,
	[CustContractAddressCountry] [nvarchar](50) NULL,
	[CustRegisterDate] [nvarchar](50) NULL,
	[TransactionMethod] [nvarchar](50) NULL,
	[TransactionDate] [nvarchar](50) NULL,
	[TranxAmountThb] [nvarchar](50) NULL,
	[TranxAmountCurrency] [nvarchar](50) NULL,
	[TranxCurrency] [nvarchar](50) NULL,
	[TranxExchangeRate] [nvarchar](50) NULL,
	[TranxAmountThbInThWord] [nvarchar](50) NULL,
	[TranxInternationalOrDomestic] [nvarchar](50) NULL,
	[TranxSendReceive] [nvarchar](50) NULL,
	[TranxObjective] [nvarchar](50) NULL,
	[SendTranxRefNo] [nvarchar](50) NULL,
	[SendBankName] [nvarchar](50) NULL,
	[SendBankCountry] [nvarchar](50) NULL,
	[SendBankAccountNo] [nvarchar](50) NULL,
	[SendName] [nvarchar](50) NULL,
	[SendAddress] [nvarchar](100) NULL,
	[SendIdType] [nvarchar](50) NULL,
	[SendIdDescription] [nvarchar](50) NULL,
	[SendIdNo] [nvarchar](50) NULL,
	[SendIdIssueBy] [nvarchar](50) NULL,
	[BeneBankAccountNo] [nvarchar](50) NULL,
	[BeneTranxRefNo] [nvarchar](50) NULL,
	[BeneBankName] [nvarchar](50) NULL,
	[BeneBankCountry] [nvarchar](50) NULL,
	[BeneName] [nvarchar](50) NULL,
	[BeneAddress] [nvarchar](100) NULL,
	[BeneIdType] [nvarchar](50) NULL,
	[BeneIdDescription] [nvarchar](100) NULL,
	[BeneIdNo] [nvarchar](50) NULL,
	[BeneIdIssueBy] [nvarchar](50) NULL,
	[Remark] [nvarchar](100) NULL,
	[MappingSourceDB] [nvarchar](100) NULL,
	[CREATE_BY] [varchar](50) NULL,
	[CREATE_DATE] [datetime] NULL,
	[UPDATE_BY] [varchar](50) NULL,
	[UPDATE_DATE] [datetime] NULL,
	[ROW_STATE] [nchar](10) NULL,
	[Active] [char](1) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


