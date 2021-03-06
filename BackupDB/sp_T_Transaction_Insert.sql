
ALTER PROCEDURE [dbo].[sp_T_Transaction_Insert] (
	@TranOID_1 [nvarchar](50), 
	@FileType_2 [nvarchar](50), 
	@GroupName_3 [nvarchar](50), 
	@CustomerInstrumentId_4 [nvarchar](50), 
	@CustomerBankAccountNumber_5 [nvarchar](50), 
	@ANZCustomerId_6 [nvarchar](50), 
	@CustRegisterName_7 [nvarchar](100), 
	@CustRegisterID_8 [nvarchar](50), 
	@CustBusinessCode_9 [nvarchar](50), 
	@CustRegisterAddress_10 [nvarchar](100), 
	@CustRegisterAddressCountry_11 [nvarchar](100), 
	@CustCompanyAddress_12 [nvarchar](100), 
	@CustCompanyAddressCountry_13 [nvarchar](100), 
	@CustContractAddress_14 [nvarchar](100), 
	@CustContractAddressCountry_15 [nvarchar](50), 
	@CustRegisterDate_16 [nvarchar](50), 
	@TransactionMethod_17 [nvarchar](50), 
	@TransactionDate_18 [nvarchar](50), 
	@TranxAmountThb_19 [nvarchar](50), 
	@TranxAmountCurrency_20 [nvarchar](50), 
	@TranxCurrency_21 [nvarchar](50), 
	@TranxExchangeRate_22 [nvarchar](50), 
	@TranxAmountThbInThWord_23 [nvarchar](50), 
	@TranxInternationalOrDomestic_24 [nvarchar](50), 
	@TranxSendReceive_25 [nvarchar](50), 
	@TranxObjective_26 [nvarchar](50), 
	@SendTranxRefNo_27 [nvarchar](50), 
	@SendBankName_28 [nvarchar](50), 
	@SendBankCountry_29 [nvarchar](50), 
	@SendBankAccountNo_30 [nvarchar](50), 
	@SendName_31 [nvarchar](50), 
	@SendAddress_32 [nvarchar](100), 
	@SendIdType_33 [nvarchar](50), 
	@SendIdDescription_34 [nvarchar](50), 
	@SendIdNo_35 [nvarchar](50), 
	@SendIdIssueBy_36 [nvarchar](50), 
	@BeneBankAccountNo_37 [nvarchar](50), 
	@BeneTranxRefNo_38 [nvarchar](50), 
	@BeneBankName_39 [nvarchar](50), 
	@BeneBankCountry_40 [nvarchar](50), 
	@BeneName_41 [nvarchar](50), 
	@BeneAddress_42 [nvarchar](100), 
	@BeneIdType_43 [nvarchar](50), 
	@BeneIdDescription_44 [nvarchar](100), 
	@BeneIdNo_45 [nvarchar](50), 
	@BeneIdIssueBy_46 [nvarchar](50), 
	@Remark_47 [nvarchar](100), 
	@MappingSourceDB_48 [nvarchar](100), 
	@CREATE_BY_49 [varchar](50), 
	@CREATE_DATE_50 [nvarchar](25), 
	@UPDATE_BY_51 [varchar](50), 
	@UPDATE_DATE_52 [nvarchar](25), 
	@ROW_STATE_53 [nchar], 
	@Active_54 [char](1)
) AS 


declare @duplicate nvarchar(100)

set @duplicate=''

set  @duplicate=isnull((select CustomerInstrumentId from [T_Transaction] where CustomerInstrumentId=@CustomerInstrumentId_4 and CustomerBankAccountNumber=@CustomerBankAccountNumber_5 ),'')


if(@duplicate='')
begin
INSERT INTO [T_Transaction] (
	[TranOID], 
	[FileType], 
	[GroupName], 
	[CustomerInstrumentId], 
	[CustomerBankAccountNumber], 
	[ANZCustomerId], 
	[CustRegisterName], 
	[CustRegisterID], 
	[CustBusinessCode], 
	[CustRegisterAddress], 
	[CustRegisterAddressCountry], 
	[CustCompanyAddress], 
	[CustCompanyAddressCountry], 
	[CustContractAddress], 
	[CustContractAddressCountry], 
	[CustRegisterDate], 
	[TransactionMethod], 
	[TransactionDate], 
	[TranxAmountThb], 
	[TranxAmountCurrency], 
	[TranxCurrency], 
	[TranxExchangeRate], 
	[TranxAmountThbInThWord], 
	[TranxInternationalOrDomestic], 
	[TranxSendReceive], 
	[TranxObjective], 
	[SendTranxRefNo], 
	[SendBankName], 
	[SendBankCountry], 
	[SendBankAccountNo], 
	[SendName], 
	[SendAddress], 
	[SendIdType], 
	[SendIdDescription], 
	[SendIdNo], 
	[SendIdIssueBy], 
	[BeneBankAccountNo], 
	[BeneTranxRefNo], 
	[BeneBankName], 
	[BeneBankCountry], 
	[BeneName], 
	[BeneAddress], 
	[BeneIdType], 
	[BeneIdDescription], 
	[BeneIdNo], 
	[BeneIdIssueBy], 
	[Remark], 
	[MappingSourceDB], 
	[CREATE_BY], 
	[CREATE_DATE], 
	[UPDATE_BY], 
	[UPDATE_DATE], 
	[ROW_STATE], 
	[Active]
) VALUES (
	@TranOID_1, 
	@FileType_2, 
	@GroupName_3, 
	@CustomerInstrumentId_4, 
	@CustomerBankAccountNumber_5, 
	@ANZCustomerId_6, 
	@CustRegisterName_7, 
	@CustRegisterID_8, 
	@CustBusinessCode_9, 
	@CustRegisterAddress_10, 
	@CustRegisterAddressCountry_11, 
	@CustCompanyAddress_12, 
	@CustCompanyAddressCountry_13, 
	@CustContractAddress_14, 
	@CustContractAddressCountry_15, 
	@CustRegisterDate_16, 
	@TransactionMethod_17, 
	@TransactionDate_18, 
	@TranxAmountThb_19, 
	@TranxAmountCurrency_20, 
	@TranxCurrency_21, 
	@TranxExchangeRate_22, 
	@TranxAmountThbInThWord_23, 
	@TranxInternationalOrDomestic_24, 
	@TranxSendReceive_25, 
	@TranxObjective_26, 
	@SendTranxRefNo_27, 
	@SendBankName_28, 
	@SendBankCountry_29, 
	@SendBankAccountNo_30, 
	@SendName_31, 
	@SendAddress_32, 
	@SendIdType_33, 
	@SendIdDescription_34, 
	@SendIdNo_35, 
	@SendIdIssueBy_36, 
	@BeneBankAccountNo_37, 
	@BeneTranxRefNo_38, 
	@BeneBankName_39, 
	@BeneBankCountry_40, 
	@BeneName_41, 
	@BeneAddress_42, 
	@BeneIdType_43, 
	@BeneIdDescription_44, 
	@BeneIdNo_45, 
	@BeneIdIssueBy_46, 
	@Remark_47, 
	@MappingSourceDB_48, 
	@CREATE_BY_49, 
	@CREATE_DATE_50, 
	@UPDATE_BY_51, 
	@UPDATE_DATE_52, 
	@ROW_STATE_53, 
	@Active_54
)

end
else
begin


/* dRow["CustomerInstrumentId"]= txtInstrumentId.Text; // PK
            dRow["CustomerBankAccountNumber"]= txtBANKAccount.Text; // PK
          
            dRow["CustRegisterID"]= txtANZRegisterID.Text;
            dRow["CustBusinessCode"] = txtANZBusinessCode.Text;
            dRow["CustRegisterAddress"]= txtANZAddress.Text;
            dRow["CustRegisterAddressCountry"]= txtANZCountry.Text;

            dRow["CustRegisterDate"]= txtANZRegisterDate.Text;
   
            dRow["TransactionDate"] = txtTransactionDate.Text;
            dRow["TranxAmountThb"]= txtTranxAmountTHB.Text;
            dRow["TranxAmountCurrency"]=txtANZCountry.Text;
            dRow["TranxCurrency"]= txtCurrency.Text;
            dRow["TranxExchangeRate"]= txtExchangeRate.Text;
            dRow["TranxAmountThbInThWord"]=
            dRow["TranxInternationalOrDomestic"]=
            dRow["TranxSendReceive"]= txtTranxSendReceive.Text;
            dRow["TranxObjective"]= txtObjective.Text;
            dRow["SendTranxRefNo"] = txtSendTranxRefNo.Text;
            dRow["SendBankName"]= txtSendBankName.Text;
            dRow["SendBankCountry"]= txtSendBankCountry.Text;
            dRow["SendBankAccountNo"] = txtSendAccountNumber.Text;
            dRow["SendName"]= txtSendName.Text;
            dRow["SendAddress"]= txtSendAddress.Text;
            dRow["SendIdDescription"]= txtSendDescription.Text;
            dRow["BeneBankAccountNo"]= txtBeneAccountNumber.Text;
            dRow["BeneBankCountry"]= txtBeneBankCountry.Text;
            dRow["BeneName"]= txtBeneName.Text;
            dRow["BeneAddress"] = txtBeneAddress.Text;
            dRow["BeneIdDescription"]= txtBeneDescription.Text;*/
            
            
UPDATE [T_Transaction] 
SET 

	--[FileType] = @FileType_2, 
	--[GroupName] = @GroupName_3, 


	[CustRegisterName] = @CustRegisterName_7, 
	[CustRegisterID] = @CustRegisterID_8, 
	[CustBusinessCode] = @CustBusinessCode_9, 
	[CustRegisterAddress] = @CustRegisterAddress_10, 
	[CustRegisterAddressCountry] = @CustRegisterAddressCountry_11, 
	--[CustCompanyAddress] = @CustCompanyAddress_12, 
	--[CustCompanyAddressCountry] = @CustCompanyAddressCountry_13, 
	--[CustContractAddress] = @CustContractAddress_14, 
	--[CustContractAddressCountry] = @CustContractAddressCountry_15, 
	[CustRegisterDate] = @CustRegisterDate_16, 
	
	--[TransactionMethod] = @TransactionMethod_17, 
	
/*	 dRow["TransactionDate"] = txtTransactionDate.Text;
            dRow["TranxAmountThb"]= txtTranxAmountTHB.Text;
            dRow["TranxAmountCurrency"]=txtANZCountry.Text;
            dRow["TranxCurrency"]= txtCurrency.Text;
            dRow["TranxExchangeRate"]= txtExchangeRate.Text;
            dRow["TranxAmountThbInThWord"]=
            dRow["TranxInternationalOrDomestic"]=
            dRow["TranxSendReceive"]= txtTranxSendReceive.Text;
            dRow["TranxObjective"]= txtObjective.Text;
      */      
            
	[TransactionDate] = @TransactionDate_18, 
	[TranxAmountThb] = @TranxAmountThb_19, 
	[TranxAmountCurrency] = @TranxAmountCurrency_20, 
	[TranxCurrency] = @TranxCurrency_21, 
	[TranxExchangeRate] = @TranxExchangeRate_22, 
	[TranxAmountThbInThWord] = @TranxAmountThbInThWord_23, 
	[TranxInternationalOrDomestic] = @TranxInternationalOrDomestic_24, 
	[TranxSendReceive] = @TranxSendReceive_25, 
	[TranxObjective] = @TranxObjective_26, 
	
	
	/* 
	dRow["SendTranxRefNo"] = txtSendTranxRefNo.Text;
            dRow["SendBankName"]= txtSendBankName.Text;
            dRow["SendBankCountry"]= txtSendBankCountry.Text;
            dRow["SendBankAccountNo"] = txtSendAccountNumber.Text;
            dRow["SendName"]= txtSendName.Text;
            dRow["SendAddress"]= txtSendAddress.Text;
            dRow["SendIdDescription"]= txtSendDescription.Text;
	*/
	[SendTranxRefNo] = @SendTranxRefNo_27, 
	[SendBankName] = @SendBankName_28, 
	[SendBankCountry] = @SendBankCountry_29, 
	[SendBankAccountNo] = @SendBankAccountNo_30, 
	[SendName] = @SendName_31, 
	[SendAddress] = @SendAddress_32, 
	--[SendIdType] = @SendIdType_33, 
	[SendIdDescription] = @SendIdDescription_34, 
	--[SendIdNo] = @SendIdNo_35, 
	--[SendIdIssueBy] = @SendIdIssueBy_36, 
	
	-- dRow["BeneBankAccountNo"]= txtBeneAccountNumber.Text;
         --   dRow["BeneBankCountry"]= txtBeneBankCountry.Text;
         --   dRow["BeneName"]= txtBeneName.Text;
        --    dRow["BeneAddress"] = txtBeneAddress.Text;
         --   dRow["BeneIdDescription"]= txtBeneDescription.Text;*/
            
	[BeneBankAccountNo] = @BeneBankAccountNo_37, 
	[BeneTranxRefNo] = @BeneTranxRefNo_38, 
	[BeneBankName] = @BeneBankName_39, 
	[BeneBankCountry] = @BeneBankCountry_40, 
	[BeneName] = @BeneName_41, 
	[BeneAddress] = @BeneAddress_42, 
--	[BeneIdType] = @BeneIdType_43, 
	[BeneIdDescription] = @BeneIdDescription_44, 
--	[BeneIdNo] = @BeneIdNo_45, 
	--[BeneIdIssueBy] = @BeneIdIssueBy_46, 
	[Remark] = @Remark_47, 
	--[MappingSourceDB] = @MappingSourceDB_48, 

	[UPDATE_BY] = @UPDATE_BY_51, 
	[UPDATE_DATE] = GETDATE(), 
	[ROW_STATE] = @ROW_STATE_53, 
	[Active] = @Active_54 
	where CustomerInstrumentId=@CustomerInstrumentId_4 
	and CustomerBankAccountNumber=@CustomerBankAccountNumber_5
	
	end