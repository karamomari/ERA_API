using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ERAAPI.Data;

public partial class EraPosDbNewLastContext : DbContext
{
    public EraPosDbNewLastContext()
    {
    }

    public EraPosDbNewLastContext(DbContextOptions<EraPosDbNewLastContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CashInOutFlow1> CashInOutFlow1s { get; set; }

    public virtual DbSet<EraPosEmployeeSalaryDetail> EraPosEmployeeSalaryDetails { get; set; }

    public virtual DbSet<EraPosEmployeeSalarySummary> EraPosEmployeeSalarySummaries { get; set; }

    public virtual DbSet<Postransaction> Postransactions { get; set; }

    public virtual DbSet<TblAccountGroup> TblAccountGroups { get; set; }

    public virtual DbSet<TblAccountGroupToCopy> TblAccountGroupToCopies { get; set; }

    public virtual DbSet<TblAccountLedger> TblAccountLedgers { get; set; }

    public virtual DbSet<TblAccountLedgerToCopy> TblAccountLedgerToCopies { get; set; }

    public virtual DbSet<TblAdditionalCost> TblAdditionalCosts { get; set; }

    public virtual DbSet<TblAdditionalCostMaster> TblAdditionalCostMasters { get; set; }

    public virtual DbSet<TblAdvancePayment> TblAdvancePayments { get; set; }

    public virtual DbSet<TblArea> TblAreas { get; set; }

    public virtual DbSet<TblAttachment> TblAttachments { get; set; }

    public virtual DbSet<TblAttendance> TblAttendances { get; set; }

    public virtual DbSet<TblBankReconciliation> TblBankReconciliations { get; set; }

    public virtual DbSet<TblBankTransaction> TblBankTransactions { get; set; }

    public virtual DbSet<TblBankTransfer> TblBankTransfers { get; set; }

    public virtual DbSet<TblBarcodeSetting> TblBarcodeSettings { get; set; }

    public virtual DbSet<TblBatch> TblBatches { get; set; }

    public virtual DbSet<TblBatchBak> TblBatchBaks { get; set; }

    public virtual DbSet<TblBom> TblBoms { get; set; }

    public virtual DbSet<TblBonusDeduction> TblBonusDeductions { get; set; }

    public virtual DbSet<TblBrand> TblBrands { get; set; }

    public virtual DbSet<TblBudgetDetail> TblBudgetDetails { get; set; }

    public virtual DbSet<TblBudgetMaster> TblBudgetMasters { get; set; }

    public virtual DbSet<TblCompany> TblCompanies { get; set; }

    public virtual DbSet<TblCompany1> TblCompany1s { get; set; }

    public virtual DbSet<TblCompanyPath> TblCompanyPaths { get; set; }

    public virtual DbSet<TblContraDetail> TblContraDetails { get; set; }

    public virtual DbSet<TblContraMaster> TblContraMasters { get; set; }

    public virtual DbSet<TblCostCenter> TblCostCenters { get; set; }

    public virtual DbSet<TblCounter> TblCounters { get; set; }

    public virtual DbSet<TblCreditNoteDetail> TblCreditNoteDetails { get; set; }

    public virtual DbSet<TblCreditNoteMaster> TblCreditNoteMasters { get; set; }

    public virtual DbSet<TblCurrency> TblCurrencies { get; set; }

    public virtual DbSet<TblCurrencyToCopy> TblCurrencyToCopies { get; set; }

    public virtual DbSet<TblDailyAttendanceDetail> TblDailyAttendanceDetails { get; set; }

    public virtual DbSet<TblDailyAttendanceMaster> TblDailyAttendanceMasters { get; set; }

    public virtual DbSet<TblDailySalaryVoucherDetail> TblDailySalaryVoucherDetails { get; set; }

    public virtual DbSet<TblDailySalaryVoucherMaster> TblDailySalaryVoucherMasters { get; set; }

    public virtual DbSet<TblDebitNoteDetail> TblDebitNoteDetails { get; set; }

    public virtual DbSet<TblDebitNoteMaster> TblDebitNoteMasters { get; set; }

    public virtual DbSet<TblDeliveryNoteDetail> TblDeliveryNoteDetails { get; set; }

    public virtual DbSet<TblDeliveryNoteMaster> TblDeliveryNoteMasters { get; set; }

    public virtual DbSet<TblDepartment> TblDepartments { get; set; }

    public virtual DbSet<TblDesignation> TblDesignations { get; set; }

    public virtual DbSet<TblDetail> TblDetails { get; set; }

    public virtual DbSet<TblDetailsCopy> TblDetailsCopies { get; set; }

    public virtual DbSet<TblEmployee> TblEmployees { get; set; }

    public virtual DbSet<TblEmployeeFingerprint> TblEmployeeFingerprints { get; set; }

    public virtual DbSet<TblEmployeeSocialSecurity> TblEmployeeSocialSecurities { get; set; }

    public virtual DbSet<TblExchangeRate> TblExchangeRates { get; set; }

    public virtual DbSet<TblExpense> TblExpenses { get; set; }

    public virtual DbSet<TblExpensesCategory> TblExpensesCategories { get; set; }

    public virtual DbSet<TblExpensesDetail> TblExpensesDetails { get; set; }

    public virtual DbSet<TblExpensesMaster> TblExpensesMasters { get; set; }

    public virtual DbSet<TblField> TblFields { get; set; }

    public virtual DbSet<TblFieldsCopy> TblFieldsCopies { get; set; }

    public virtual DbSet<TblFinancialYear> TblFinancialYears { get; set; }

    public virtual DbSet<TblForm> TblForms { get; set; }

    public virtual DbSet<TblFormActionType> TblFormActionTypes { get; set; }

    public virtual DbSet<TblFormCopy> TblFormCopies { get; set; }

    public virtual DbSet<TblGodown> TblGodowns { get; set; }

    public virtual DbSet<TblHoliday> TblHolidays { get; set; }

    public virtual DbSet<TblJournalDetail> TblJournalDetails { get; set; }

    public virtual DbSet<TblJournalDetailsBak> TblJournalDetailsBaks { get; set; }

    public virtual DbSet<TblJournalMaster> TblJournalMasters { get; set; }

    public virtual DbSet<TblJournalMasterBak> TblJournalMasterBaks { get; set; }

    public virtual DbSet<TblLedgerPosting> TblLedgerPostings { get; set; }

    public virtual DbSet<TblLedgerPostingBak> TblLedgerPostingBaks { get; set; }

    public virtual DbSet<TblLicenseKey> TblLicenseKeys { get; set; }

    public virtual DbSet<TblMaster> TblMasters { get; set; }

    public virtual DbSet<TblMasterCopy> TblMasterCopies { get; set; }

    public virtual DbSet<TblMasterDataPrivilege> TblMasterDataPrivileges { get; set; }

    public virtual DbSet<TblMaterialReceiptDetail> TblMaterialReceiptDetails { get; set; }

    public virtual DbSet<TblMaterialReceiptMaster> TblMaterialReceiptMasters { get; set; }

    public virtual DbSet<TblModelNo> TblModelNos { get; set; }

    public virtual DbSet<TblMonthlySalary> TblMonthlySalaries { get; set; }

    public virtual DbSet<TblMonthlySalaryDetail> TblMonthlySalaryDetails { get; set; }

    public virtual DbSet<TblPartyBalance> TblPartyBalances { get; set; }

    public virtual DbSet<TblPayHead> TblPayHeads { get; set; }

    public virtual DbSet<TblPaymentDetail> TblPaymentDetails { get; set; }

    public virtual DbSet<TblPaymentMaster> TblPaymentMasters { get; set; }

    public virtual DbSet<TblPaymentTerm> TblPaymentTerms { get; set; }

    public virtual DbSet<TblPdcclearanceMaster> TblPdcclearanceMasters { get; set; }

    public virtual DbSet<TblPdcpayableMaster> TblPdcpayableMasters { get; set; }

    public virtual DbSet<TblPdcreceivableMaster> TblPdcreceivableMasters { get; set; }

    public virtual DbSet<TblPhysicalStockDetail> TblPhysicalStockDetails { get; set; }

    public virtual DbSet<TblPhysicalStockInDetail> TblPhysicalStockInDetails { get; set; }

    public virtual DbSet<TblPhysicalStockInMaster> TblPhysicalStockInMasters { get; set; }

    public virtual DbSet<TblPhysicalStockMaster> TblPhysicalStockMasters { get; set; }

    public virtual DbSet<TblPhysicalStockOutDetail> TblPhysicalStockOutDetails { get; set; }

    public virtual DbSet<TblPhysicalStockOutMaster> TblPhysicalStockOutMasters { get; set; }

    public virtual DbSet<TblPostingSetup> TblPostingSetups { get; set; }

    public virtual DbSet<TblPriceList> TblPriceLists { get; set; }

    public virtual DbSet<TblPricingLevel> TblPricingLevels { get; set; }

    public virtual DbSet<TblPrivilege> TblPrivileges { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<TblProductGroup> TblProductGroups { get; set; }

    public virtual DbSet<TblProductPrinterSetup> TblProductPrinterSetups { get; set; }

    public virtual DbSet<TblPurchaseBillTax> TblPurchaseBillTaxes { get; set; }

    public virtual DbSet<TblPurchaseDetail> TblPurchaseDetails { get; set; }

    public virtual DbSet<TblPurchaseMaster> TblPurchaseMasters { get; set; }

    public virtual DbSet<TblPurchaseOrderDetail> TblPurchaseOrderDetails { get; set; }

    public virtual DbSet<TblPurchaseOrderMaster> TblPurchaseOrderMasters { get; set; }

    public virtual DbSet<TblPurchaseRequisitionDetail> TblPurchaseRequisitionDetails { get; set; }

    public virtual DbSet<TblPurchaseRequisitionMaster> TblPurchaseRequisitionMasters { get; set; }

    public virtual DbSet<TblPurchaseReturnBilltax> TblPurchaseReturnBilltaxes { get; set; }

    public virtual DbSet<TblPurchaseReturnDetail> TblPurchaseReturnDetails { get; set; }

    public virtual DbSet<TblPurchaseReturnMaster> TblPurchaseReturnMasters { get; set; }

    public virtual DbSet<TblQuickLaunchItem> TblQuickLaunchItems { get; set; }

    public virtual DbSet<TblQuickLaunchItemsToCopy> TblQuickLaunchItemsToCopies { get; set; }

    public virtual DbSet<TblRack> TblRacks { get; set; }

    public virtual DbSet<TblReceiptDetail> TblReceiptDetails { get; set; }

    public virtual DbSet<TblReceiptMaster> TblReceiptMasters { get; set; }

    public virtual DbSet<TblRejectionInDetail> TblRejectionInDetails { get; set; }

    public virtual DbSet<TblRejectionInMaster> TblRejectionInMasters { get; set; }

    public virtual DbSet<TblRejectionOutDetail> TblRejectionOutDetails { get; set; }

    public virtual DbSet<TblRejectionOutMaster> TblRejectionOutMasters { get; set; }

    public virtual DbSet<TblReminder> TblReminders { get; set; }

    public virtual DbSet<TblRole> TblRoles { get; set; }

    public virtual DbSet<TblRoute> TblRoutes { get; set; }

    public virtual DbSet<TblSalaryPackage> TblSalaryPackages { get; set; }

    public virtual DbSet<TblSalaryPackageDetail> TblSalaryPackageDetails { get; set; }

    public virtual DbSet<TblSalaryVoucherDetail> TblSalaryVoucherDetails { get; set; }

    public virtual DbSet<TblSalaryVoucherMaster> TblSalaryVoucherMasters { get; set; }

    public virtual DbSet<TblSalesBillPayment> TblSalesBillPayments { get; set; }

    public virtual DbSet<TblSalesBillTax> TblSalesBillTaxes { get; set; }

    public virtual DbSet<TblSalesDetail> TblSalesDetails { get; set; }

    public virtual DbSet<TblSalesMaster> TblSalesMasters { get; set; }

    public virtual DbSet<TblSalesOrderDetail> TblSalesOrderDetails { get; set; }

    public virtual DbSet<TblSalesOrderMaster> TblSalesOrderMasters { get; set; }

    public virtual DbSet<TblSalesQuotationDetail> TblSalesQuotationDetails { get; set; }

    public virtual DbSet<TblSalesQuotationMaster> TblSalesQuotationMasters { get; set; }

    public virtual DbSet<TblSalesReturnBillTax> TblSalesReturnBillTaxes { get; set; }

    public virtual DbSet<TblSalesReturnDetail> TblSalesReturnDetails { get; set; }

    public virtual DbSet<TblSalesReturnMaster> TblSalesReturnMasters { get; set; }

    public virtual DbSet<TblSection> TblSections { get; set; }

    public virtual DbSet<TblService> TblServices { get; set; }

    public virtual DbSet<TblServiceCategory> TblServiceCategories { get; set; }

    public virtual DbSet<TblServiceDetail> TblServiceDetails { get; set; }

    public virtual DbSet<TblServiceMaster> TblServiceMasters { get; set; }

    public virtual DbSet<TblSetting> TblSettings { get; set; }

    public virtual DbSet<TblSettingsToCopy> TblSettingsToCopies { get; set; }

    public virtual DbSet<TblSize> TblSizes { get; set; }

    public virtual DbSet<TblSmartList> TblSmartLists { get; set; }

    public virtual DbSet<TblSmtpsetting> TblSmtpsettings { get; set; }

    public virtual DbSet<TblSocialSecurityType> TblSocialSecurityTypes { get; set; }

    public virtual DbSet<TblStandardRate> TblStandardRates { get; set; }

    public virtual DbSet<TblStockInDetail> TblStockInDetails { get; set; }

    public virtual DbSet<TblStockInMaster> TblStockInMasters { get; set; }

    public virtual DbSet<TblStockJournalDetail> TblStockJournalDetails { get; set; }

    public virtual DbSet<TblStockJournalMaster> TblStockJournalMasters { get; set; }

    public virtual DbSet<TblStockPosting> TblStockPostings { get; set; }

    public virtual DbSet<TblStockPosting1> TblStockPosting1s { get; set; }

    public virtual DbSet<TblStockPostingBak> TblStockPostingBaks { get; set; }

    public virtual DbSet<TblStockStaging> TblStockStagings { get; set; }

    public virtual DbSet<TblStockTransferDetail> TblStockTransferDetails { get; set; }

    public virtual DbSet<TblStockTransferMaster> TblStockTransferMasters { get; set; }

    public virtual DbSet<TblStocktakingDetail> TblStocktakingDetails { get; set; }

    public virtual DbSet<TblStocktakingMaster> TblStocktakingMasters { get; set; }

    public virtual DbSet<TblSuffixPrefix> TblSuffixPrefixes { get; set; }

    public virtual DbSet<TblSystemLog> TblSystemLogs { get; set; }

    public virtual DbSet<TblTax> TblTaxes { get; set; }

    public virtual DbSet<TblTaxDetail> TblTaxDetails { get; set; }

    public virtual DbSet<TblTaxIntegrationDetail> TblTaxIntegrationDetails { get; set; }

    public virtual DbSet<TblTaxIntegrationMaster> TblTaxIntegrationMasters { get; set; }

    public virtual DbSet<TblTaxIntegrationProfile> TblTaxIntegrationProfiles { get; set; }

    public virtual DbSet<TblTaxIntegrationResult> TblTaxIntegrationResults { get; set; }

    public virtual DbSet<TblUnit> TblUnits { get; set; }

    public virtual DbSet<TblUnitConvertion> TblUnitConvertions { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TblVoucherType> TblVoucherTypes { get; set; }

    public virtual DbSet<TblVoucherTypeTax> TblVoucherTypeTaxes { get; set; }

    public virtual DbSet<TblVoucherTypeToCopy> TblVoucherTypeToCopies { get; set; }

    public virtual DbSet<TblWorkPeriod> TblWorkPeriods { get; set; }

    public virtual DbSet<TblWorkPeriodDetail> TblWorkPeriodDetails { get; set; }

    public virtual DbSet<TblWorkPeriodMaster> TblWorkPeriodMasters { get; set; }

    public virtual DbSet<TblWorkflow> TblWorkflows { get; set; }

    public virtual DbSet<TblWorkflowSetup> TblWorkflowSetups { get; set; }

    public virtual DbSet<TblWorkflowStep> TblWorkflowSteps { get; set; }

    public virtual DbSet<TblWorkflowStepAssignment> TblWorkflowStepAssignments { get; set; }

    public virtual DbSet<TblWorkflowStepCondition> TblWorkflowStepConditions { get; set; }

    public virtual DbSet<Temp> Temps { get; set; }

    public virtual DbSet<Temp1> Temp1s { get; set; }

    public virtual DbSet<Temp81> Temp81s { get; set; }

    public virtual DbSet<View1> View1s { get; set; }

    public virtual DbSet<ViewCashBank> ViewCashBanks { get; set; }

    public virtual DbSet<VwAllMasterTransaction> VwAllMasterTransactions { get; set; }

    public virtual DbSet<VwAllTransaction> VwAllTransactions { get; set; }

    public virtual DbSet<VwAptransaction> VwAptransactions { get; set; }

    public virtual DbSet<VwAptransactions1> VwAptransactions1s { get; set; }

    public virtual DbSet<VwArtransaction> VwArtransactions { get; set; }

    public virtual DbSet<VwBanktransaction> VwBanktransactions { get; set; }

    public virtual DbSet<VwMaxRate> VwMaxRates { get; set; }

    public virtual DbSet<VwMinRate> VwMinRates { get; set; }

    public virtual DbSet<VwStock> VwStocks { get; set; }

    public virtual DbSet<VwStockQuery> VwStockQueries { get; set; }

    public virtual DbSet<VwTax> VwTaxes { get; set; }

    public virtual DbSet<VwTrialBalance> VwTrialBalances { get; set; }

    public virtual DbSet<VwTrialBalanceSummary> VwTrialBalanceSummaries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-EQJM04S\\SQLEXPRESS;Database=eraPOS_DB_NEW_LAST;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CashInOutFlow1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CashInOutFlow1");

            entity.Property(e => e.AccountGroupId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
        });

        modelBuilder.Entity<EraPosEmployeeSalaryDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("eraPOS_EmployeeSalaryDetails");

            entity.Property(e => e.BaseSalaryBonus).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.EmployeeName)
                .IsUnicode(false)
                .HasColumnName("employeeName");
            entity.Property(e => e.GeneralDeduction).HasColumnType("decimal(38, 5)");
            entity.Property(e => e.MonthlyWage)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("monthlyWage");
            entity.Property(e => e.PackageAmount).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.PrivateBonus).HasColumnType("decimal(38, 5)");
            entity.Property(e => e.PrivateDeduction).HasColumnType("decimal(38, 5)");
            entity.Property(e => e.SalaryPackageName)
                .IsUnicode(false)
                .HasColumnName("salaryPackageName");
        });

        modelBuilder.Entity<EraPosEmployeeSalarySummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("eraPOS_EmployeeSalarySummary");

            entity.Property(e => e.BaseSalaryBonus).HasColumnType("decimal(38, 5)");
            entity.Property(e => e.EmployeeCode)
                .IsUnicode(false)
                .HasColumnName("employeeCode");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.EmployeeName)
                .IsUnicode(false)
                .HasColumnName("employeeName");
            entity.Property(e => e.MonthlyWage)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("monthlyWage");
            entity.Property(e => e.PackageAmount).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.PrivateBonus).HasColumnType("decimal(38, 5)");
            entity.Property(e => e.PrivateDeduction).HasColumnType("decimal(38, 5)");
            entity.Property(e => e.SalaryPackageName)
                .IsUnicode(false)
                .HasColumnName("salaryPackageName");
        });

        modelBuilder.Entity<Postransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("POSTransaction");

            entity.Property(e => e.Cash)
                .HasColumnType("decimal(38, 5)")
                .HasColumnName("CASH");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(38, 5)")
                .HasColumnName("DEBIT");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.MailingName)
                .IsUnicode(false)
                .HasColumnName("mailingName");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.Visa)
                .HasColumnType("decimal(38, 5)")
                .HasColumnName("VISA");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.WorkPeriodId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("workPeriodId");
        });

        modelBuilder.Entity<TblAccountGroup>(entity =>
        {
            entity.HasKey(e => e.AccountGroupId).HasName("PK__tbl_Acco__74C422AE625A9A57");

            entity.ToTable("tbl_AccountGroup");

            entity.Property(e => e.AccountGroupId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.AccountGroupName)
                .IsUnicode(false)
                .HasColumnName("accountGroupName");
            entity.Property(e => e.AccountGroupType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("accountGroupType");
            entity.Property(e => e.AffectGrossProfit).HasColumnName("affectGrossProfit");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GroupUnder)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupUnder");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Nature)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nature");
        });

        modelBuilder.Entity<TblAccountGroupToCopy>(entity =>
        {
            entity.HasKey(e => e.AccountGroupId);

            entity.ToTable("tbl_AccountGroupToCopy");

            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.AccountGroupName)
                .IsUnicode(false)
                .HasColumnName("accountGroupName");
            entity.Property(e => e.AffectGrossProfit).HasColumnName("affectGrossProfit");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GroupUnder)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupUnder");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Nature)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nature");
        });

        modelBuilder.Entity<TblAccountLedger>(entity =>
        {
            entity.HasKey(e => e.LedgerId).HasName("PK_tbl_AccountLedger_1");

            entity.ToTable("tbl_AccountLedger");

            entity.Property(e => e.LedgerId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.AreaId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("areaId");
            entity.Property(e => e.BankAccountNumber)
                .IsUnicode(false)
                .HasColumnName("bankAccountNumber");
            entity.Property(e => e.BankIban)
                .IsUnicode(false)
                .HasColumnName("bankIBAN");
            entity.Property(e => e.BillByBill).HasColumnName("billByBill");
            entity.Property(e => e.BranchCode)
                .IsUnicode(false)
                .HasColumnName("branchCode");
            entity.Property(e => e.BranchName)
                .IsUnicode(false)
                .HasColumnName("branchName");
            entity.Property(e => e.CrOrDr)
                .IsUnicode(false)
                .HasColumnName("crOrDr");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CreditLimit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("creditLimit");
            entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");
            entity.Property(e => e.Cst)
                .IsUnicode(false)
                .HasColumnName("cst");
            entity.Property(e => e.CurrencyId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("currencyId");
            entity.Property(e => e.Email)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.LedgerName)
                .IsUnicode(false)
                .HasColumnName("ledgerName");
            entity.Property(e => e.LedgerNumber)
                .IsUnicode(false)
                .HasColumnName("ledgerNumber");
            entity.Property(e => e.LedgerType)
                .IsUnicode(false)
                .HasColumnName("ledgerType");
            entity.Property(e => e.MailingName)
                .IsUnicode(false)
                .HasColumnName("mailingName");
            entity.Property(e => e.Mobile)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.OpeningBalance)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("openingBalance");
            entity.Property(e => e.Pan)
                .IsUnicode(false)
                .HasColumnName("pan");
            entity.Property(e => e.PaymentTermId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentTermId");
            entity.Property(e => e.Phone)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.PostingType)
                .IsUnicode(false)
                .HasColumnName("postingType");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.RouteId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("routeId");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.Tin)
                .IsUnicode(false)
                .HasColumnName("tin");
            entity.Property(e => e.Vatno)
                .IsUnicode(false)
                .HasColumnName("VATNo");
        });

        modelBuilder.Entity<TblAccountLedgerToCopy>(entity =>
        {
            entity.HasKey(e => e.LedgerId);

            entity.ToTable("tbl_AccountLedgerToCopy");

            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.AreaId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("areaId");
            entity.Property(e => e.BankAccountNumber)
                .IsUnicode(false)
                .HasColumnName("bankAccountNumber");
            entity.Property(e => e.BillByBill).HasColumnName("billByBill");
            entity.Property(e => e.BranchCode)
                .IsUnicode(false)
                .HasColumnName("branchCode");
            entity.Property(e => e.BranchName)
                .IsUnicode(false)
                .HasColumnName("branchName");
            entity.Property(e => e.CrOrDr)
                .IsUnicode(false)
                .HasColumnName("crOrDr");
            entity.Property(e => e.CreditLimit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("creditLimit");
            entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");
            entity.Property(e => e.Cst)
                .IsUnicode(false)
                .HasColumnName("cst");
            entity.Property(e => e.Email)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.LedgerName)
                .IsUnicode(false)
                .HasColumnName("ledgerName");
            entity.Property(e => e.MailingName)
                .IsUnicode(false)
                .HasColumnName("mailingName");
            entity.Property(e => e.Mobile)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.OpeningBalance)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("openingBalance");
            entity.Property(e => e.Pan)
                .IsUnicode(false)
                .HasColumnName("pan");
            entity.Property(e => e.Phone)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.RouteId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("routeId");
            entity.Property(e => e.State)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Tin)
                .IsUnicode(false)
                .HasColumnName("tin");
        });

        modelBuilder.Entity<TblAdditionalCost>(entity =>
        {
            entity.HasKey(e => e.AdditionalCostId).HasName("PK__tbl_Addi__D89F761D24092D7A");

            entity.ToTable("tbl_AdditionalCost");

            entity.Property(e => e.AdditionalCostId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("additionalCostId");
            entity.Property(e => e.AdditionalCostMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("additionalCostMasterId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsEstimation).HasColumnName("isEstimation");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.VoucherMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherMasterId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblAdditionalCostMaster>(entity =>
        {
            entity.HasKey(e => e.AdditionalCostId).HasName("PK__tbl_AdditionalCostMaster__08A9D0236497E884");

            entity.ToTable("tbl_AdditionalCostMaster");

            entity.Property(e => e.AdditionalCostId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("additionalCostId");
            entity.Property(e => e.AdditionalCostName)
                .IsUnicode(false)
                .HasColumnName("additionalCostName");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblAdvancePayment>(entity =>
        {
            entity.HasKey(e => e.AdvancePaymentId).HasName("PK__tbl_Adva__1A7BF2355AB9788F");

            entity.ToTable("tbl_AdvancePayment");

            entity.Property(e => e.AdvancePaymentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("advancePaymentId");
            entity.Property(e => e.Amount)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.Chequenumber)
                .IsUnicode(false)
                .HasColumnName("chequenumber");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SalaryMonth)
                .HasColumnType("datetime")
                .HasColumnName("salaryMonth");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblArea>(entity =>
        {
            entity.HasKey(e => e.AreaId);

            entity.ToTable("tbl_Area");

            entity.Property(e => e.AreaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("areaId");
            entity.Property(e => e.AreaName)
                .IsUnicode(false)
                .HasColumnName("areaName");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblAttachment>(entity =>
        {
            entity.HasKey(e => e.AttachmentId);

            entity.ToTable("tbl_Attachment");

            entity.Property(e => e.AttachmentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("attachmentId");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.AttachmentContentBase64).HasColumnName("attachmentContentBase64");
            entity.Property(e => e.AttachmentName)
                .HasMaxLength(250)
                .HasColumnName("attachmentName");
            entity.Property(e => e.AttachmentSize)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("attachmentSize");
            entity.Property(e => e.AttachmentSourceId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("attachmentSourceId");
            entity.Property(e => e.AttachmentSourceType)
                .HasMaxLength(50)
                .HasColumnName("attachmentSourceType");
            entity.Property(e => e.AttachmentType)
                .HasMaxLength(50)
                .HasColumnName("attachmentType");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
        });

        modelBuilder.Entity<TblAttendance>(entity =>
        {
            entity.HasKey(e => e.AttendanceId).HasName("PK_Attendance");

            entity.ToTable("tbl_Attendance");

            entity.Property(e => e.AttendanceId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AttendanceID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("EmployeeID");
            entity.Property(e => e.Extra1)
                .HasMaxLength(100)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .HasMaxLength(100)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .HasMaxLength(500)
                .HasColumnName("narration");

            entity.HasOne(d => d.Employee).WithMany(p => p.TblAttendances)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attendance_Employee");
        });

        modelBuilder.Entity<TblBankReconciliation>(entity =>
        {
            entity.HasKey(e => e.ReconcileId).HasName("PK__tbl_Bank__66CCE65D0CC64B43");

            entity.ToTable("tbl_BankReconciliation");

            entity.Property(e => e.ReconcileId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("reconcileId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.LedgerPostingId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerPostingId");
            entity.Property(e => e.StatementDate)
                .HasColumnType("datetime")
                .HasColumnName("statementDate");
        });

        modelBuilder.Entity<TblBankTransaction>(entity =>
        {
            entity.HasKey(e => e.BankTransactionId).HasName("PK__tbl_BankTransaction");

            entity.ToTable("tbl_BankTransaction");

            entity.Property(e => e.BankTransactionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bankTransactionId");
            entity.Property(e => e.BalanceLedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("balanceLedgerId");
            entity.Property(e => e.BankLedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bankLedgerId");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.Type)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblBankTransfer>(entity =>
        {
            entity.HasKey(e => e.BankTransferId).HasName("PK__tbl_BankTransfer");

            entity.ToTable("tbl_BankTransfer");

            entity.Property(e => e.BankTransferId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bankTransferId");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.FromLedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("fromLedgerId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.ToLedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("toLedgerId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.Type)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblBarcodeSetting>(entity =>
        {
            entity.HasKey(e => e.BarcodeSettingsId).HasName("PK__tbl_Barc__1F1D76191C5DEA11");

            entity.ToTable("tbl_BarcodeSettings");

            entity.Property(e => e.BarcodeSettingsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("barcodeSettingsId");
            entity.Property(e => e.CompanyName)
                .IsUnicode(false)
                .HasColumnName("companyName");
            entity.Property(e => e.Eight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("eight");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Five)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("five");
            entity.Property(e => e.Four)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("four");
            entity.Property(e => e.Nine)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nine");
            entity.Property(e => e.One)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("one");
            entity.Property(e => e.Point)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("point");
            entity.Property(e => e.Seven)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("seven");
            entity.Property(e => e.ShowCompanyName).HasColumnName("showCompanyName");
            entity.Property(e => e.ShowMrp).HasColumnName("showMRP");
            entity.Property(e => e.ShowProductCode).HasColumnName("showProductCode");
            entity.Property(e => e.ShowPurchaseRate).HasColumnName("showPurchaseRate");
            entity.Property(e => e.Six)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("six");
            entity.Property(e => e.Three)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("three");
            entity.Property(e => e.Two)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("two");
            entity.Property(e => e.Zero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("zero");
        });

        modelBuilder.Entity<TblBatch>(entity =>
        {
            entity.HasKey(e => e.BatchId).HasName("PK__tbl_Batc__78CCD773147C05D0");

            entity.ToTable("tbl_Batch");

            entity.Property(e => e.BatchId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Barcode)
                .IsUnicode(false)
                .HasColumnName("barcode");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ManufacturingDate)
                .HasColumnType("datetime")
                .HasColumnName("manufacturingDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PartNo)
                .IsUnicode(false)
                .HasColumnName("partNo");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Rate)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.RateMain)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("rateMain");
        });

        modelBuilder.Entity<TblBatchBak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_Batch_BAK");

            entity.Property(e => e.Barcode)
                .IsUnicode(false)
                .HasColumnName("barcode");
            entity.Property(e => e.BatchId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ManufacturingDate)
                .HasColumnType("datetime")
                .HasColumnName("manufacturingDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PartNo)
                .IsUnicode(false)
                .HasColumnName("partNo");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Rate)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.RateMain)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("rateMain");
        });

        modelBuilder.Entity<TblBom>(entity =>
        {
            entity.HasKey(e => e.BomId).HasName("PK__tbl_Bom__B6B08848184C96B4");

            entity.ToTable("tbl_Bom");

            entity.Property(e => e.BomId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bomId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Quantity)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("quantity");
            entity.Property(e => e.RowmaterialId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rowmaterialId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblBonusDeduction>(entity =>
        {
            entity.HasKey(e => e.BonusDeductionId);

            entity.ToTable("tbl_BonusDeduction");

            entity.Property(e => e.BonusDeductionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bonusDeductionId");
            entity.Property(e => e.BonusAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("bonusAmount");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DeductionAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("deductionAmount");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Month)
                .HasColumnType("datetime")
                .HasColumnName("month");
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblBrand>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("PK__tbl_Bran__06B7729946136164");

            entity.ToTable("tbl_Brand");

            entity.Property(e => e.BrandId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("brandId");
            entity.Property(e => e.BrandName)
                .IsUnicode(false)
                .HasColumnName("brandName");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Manufacturer)
                .IsUnicode(false)
                .HasColumnName("manufacturer");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblBudgetDetail>(entity =>
        {
            entity.HasKey(e => e.BudgetDetailsId).HasName("PK__tbl_Budg__C2BA2365004BBB48");

            entity.ToTable("tbl_BudgetDetails");

            entity.Property(e => e.BudgetDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("budgetDetailsId");
            entity.Property(e => e.BudgetMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("budgetMasterId");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Particular)
                .IsUnicode(false)
                .HasColumnName("particular");
        });

        modelBuilder.Entity<TblBudgetMaster>(entity =>
        {
            entity.HasKey(e => e.BudgetMasterId).HasName("PK__tbl_Budg__060415BC7C7B2A64");

            entity.ToTable("tbl_BudgetMaster");

            entity.Property(e => e.BudgetMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("budgetMasterId");
            entity.Property(e => e.BudgetName)
                .IsUnicode(false)
                .HasColumnName("budgetName");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("fromDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("toDate");
            entity.Property(e => e.TotalCr)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalCr");
            entity.Property(e => e.TotalDr)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalDr");
            entity.Property(e => e.Type)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<TblCompany>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__tbl_Comp__AD5459903E723F9C");

            entity.ToTable("tbl_Company");

            entity.Property(e => e.CompanyId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("companyId");
            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.BooksBeginingFrom)
                .HasColumnType("datetime")
                .HasColumnName("booksBeginingFrom");
            entity.Property(e => e.CompanyName)
                .IsUnicode(false)
                .HasColumnName("companyName");
            entity.Property(e => e.Country)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Cst)
                .IsUnicode(false)
                .HasColumnName("cst");
            entity.Property(e => e.CurrencyId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("currencyId");
            entity.Property(e => e.CurrentDate)
                .HasColumnType("datetime")
                .HasColumnName("currentDate");
            entity.Property(e => e.EmailId)
                .IsUnicode(false)
                .HasColumnName("emailId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearFrom)
                .HasColumnType("datetime")
                .HasColumnName("financialYearFrom");
            entity.Property(e => e.Logo)
                .IsUnicode(false)
                .HasColumnName("logo");
            entity.Property(e => e.LogoImage)
                .HasColumnType("image")
                .HasColumnName("logoImage");
            entity.Property(e => e.MailingName)
                .IsUnicode(false)
                .HasColumnName("mailingName");
            entity.Property(e => e.Mobile)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Pan)
                .IsUnicode(false)
                .HasColumnName("pan");
            entity.Property(e => e.Phone)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Pin)
                .IsUnicode(false)
                .HasColumnName("pin");
            entity.Property(e => e.State)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Tin)
                .IsUnicode(false)
                .HasColumnName("tin");
            entity.Property(e => e.Web)
                .IsUnicode(false)
                .HasColumnName("web");
        });

        modelBuilder.Entity<TblCompany1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_Company1");

            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.BooksBeginingFrom)
                .HasColumnType("datetime")
                .HasColumnName("booksBeginingFrom");
            entity.Property(e => e.CompanyId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("companyId");
            entity.Property(e => e.CompanyName)
                .IsUnicode(false)
                .HasColumnName("companyName");
            entity.Property(e => e.Country)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Cst)
                .IsUnicode(false)
                .HasColumnName("cst");
            entity.Property(e => e.CurrencyId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("currencyId");
            entity.Property(e => e.CurrentDate)
                .HasColumnType("datetime")
                .HasColumnName("currentDate");
            entity.Property(e => e.EmailId)
                .IsUnicode(false)
                .HasColumnName("emailId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearFrom)
                .HasColumnType("datetime")
                .HasColumnName("financialYearFrom");
            entity.Property(e => e.Logo)
                .IsUnicode(false)
                .HasColumnName("logo");
            entity.Property(e => e.LogoImage)
                .HasColumnType("image")
                .HasColumnName("logoImage");
            entity.Property(e => e.MailingName)
                .IsUnicode(false)
                .HasColumnName("mailingName");
            entity.Property(e => e.Mobile)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Pan)
                .IsUnicode(false)
                .HasColumnName("pan");
            entity.Property(e => e.Phone)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Pin)
                .IsUnicode(false)
                .HasColumnName("pin");
            entity.Property(e => e.State)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Tin)
                .IsUnicode(false)
                .HasColumnName("tin");
            entity.Property(e => e.Web)
                .IsUnicode(false)
                .HasColumnName("web");
        });

        modelBuilder.Entity<TblCompanyPath>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__tbl_Comp__AD5459903B36AB95");

            entity.ToTable("tbl_CompanyPath");

            entity.Property(e => e.CompanyId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("companyId");
            entity.Property(e => e.CompanyName)
                .IsUnicode(false)
                .HasColumnName("companyName");
            entity.Property(e => e.CompanyPath)
                .IsUnicode(false)
                .HasColumnName("companyPath");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
        });

        modelBuilder.Entity<TblContraDetail>(entity =>
        {
            entity.HasKey(e => e.ContraDetailsId).HasName("PK__tbl_Cont__4D096E75632F8E56");

            entity.ToTable("tbl_ContraDetails");

            entity.Property(e => e.ContraDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("contraDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.ContraMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("contraMasterId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
        });

        modelBuilder.Entity<TblContraMaster>(entity =>
        {
            entity.HasKey(e => e.ContraMasterId).HasName("PK__tbl_Cont__0B964F325F5EFD72");

            entity.ToTable("tbl_ContraMaster");

            entity.Property(e => e.ContraMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("contraMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.Type)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblCostCenter>(entity =>
        {
            entity.HasKey(e => e.CostCenterId).HasName("PK__tbl_CostCenter__08A9D0236497E884");

            entity.ToTable("tbl_CostCenter");

            entity.Property(e => e.CostCenterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("costCenterId");
            entity.Property(e => e.CostCenterName)
                .IsUnicode(false)
                .HasColumnName("costCenterName");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblCounter>(entity =>
        {
            entity.HasKey(e => e.CounterId).HasName("PK__tbl_Coun__08A9D0236497E884");

            entity.ToTable("tbl_Counter");

            entity.Property(e => e.CounterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("counterId");
            entity.Property(e => e.CounterName)
                .IsUnicode(false)
                .HasColumnName("counterName");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblCreditNoteDetail>(entity =>
        {
            entity.HasKey(e => e.CreditNoteDetailsId).HasName("PK__tbl_Cred__3A8A913E10F65906");

            entity.ToTable("tbl_CreditNoteDetails");

            entity.Property(e => e.CreditNoteDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("creditNoteDetailsId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.CreditNoteMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("creditNoteMasterId");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.ReferenceDate)
                .HasColumnType("datetime")
                .HasColumnName("referenceDate");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
        });

        modelBuilder.Entity<TblCreditNoteMaster>(entity =>
        {
            entity.HasKey(e => e.CreditNoteMasterId).HasName("PK__tbl_Cred__DDC597880D25C822");

            entity.ToTable("tbl_CreditNoteMaster");

            entity.Property(e => e.CreditNoteMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("creditNoteMasterId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CreditNoteType)
                .IsUnicode(false)
                .HasColumnName("creditNoteType");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerBalanceId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerBalanceId");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.ReferenceDate)
                .HasColumnType("datetime")
                .HasColumnName("referenceDate");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblCurrency>(entity =>
        {
            entity.HasKey(e => e.CurrencyId).HasName("PK__tbl_Curr__DAF0B20A592635D8");

            entity.ToTable("tbl_Currency");

            entity.Property(e => e.CurrencyId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("currencyId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CurrencyName)
                .IsUnicode(false)
                .HasColumnName("currencyName");
            entity.Property(e => e.CurrencySymbol)
                .IsUnicode(false)
                .HasColumnName("currencySymbol");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.NoOfDecimalPlaces).HasColumnName("noOfDecimalPlaces");
            entity.Property(e => e.SubunitName)
                .IsUnicode(false)
                .HasColumnName("subunitName");
        });

        modelBuilder.Entity<TblCurrencyToCopy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_CurrencyToCopy");

            entity.Property(e => e.CurrencyId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("currencyId");
            entity.Property(e => e.CurrencyName)
                .IsUnicode(false)
                .HasColumnName("currencyName");
            entity.Property(e => e.CurrencySymbol)
                .IsUnicode(false)
                .HasColumnName("currencySymbol");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.NoOfDecimalPlaces).HasColumnName("noOfDecimalPlaces");
            entity.Property(e => e.SubunitName)
                .IsUnicode(false)
                .HasColumnName("subunitName");
        });

        modelBuilder.Entity<TblDailyAttendanceDetail>(entity =>
        {
            entity.HasKey(e => e.DailyAttendanceDetailsId).HasName("PK__tbl_Dail__990F6D9656E8E7AB");

            entity.ToTable("tbl_DailyAttendanceDetails");

            entity.Property(e => e.DailyAttendanceDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("dailyAttendanceDetailsId");
            entity.Property(e => e.DailyAttendanceMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("dailyAttendanceMasterId");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<TblDailyAttendanceMaster>(entity =>
        {
            entity.HasKey(e => e.DailyAttendanceMasterId).HasName("PK__tbl_Dail__6FC4FA94531856C7");

            entity.ToTable("tbl_DailyAttendanceMaster");

            entity.Property(e => e.DailyAttendanceMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("dailyAttendanceMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblDailySalaryVoucherDetail>(entity =>
        {
            entity.HasKey(e => e.DailySalaryVoucherDetailsId).HasName("PK__tbl_Dail__031176C94F47C5E3");

            entity.ToTable("tbl_DailySalaryVoucherDetails");

            entity.Property(e => e.DailySalaryVoucherDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("dailySalaryVoucherDetailsId");
            entity.Property(e => e.DailySalaryVoucherMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("dailySalaryVoucherMasterId");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Wage)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("wage");
        });

        modelBuilder.Entity<TblDailySalaryVoucherMaster>(entity =>
        {
            entity.HasKey(e => e.DailySalaryVoucherMasterId);

            entity.ToTable("tbl_DailySalaryVoucherMaster");

            entity.Property(e => e.DailySalaryVoucherMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("dailySalaryVoucherMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SalaryDate)
                .HasColumnType("datetime")
                .HasColumnName("salaryDate");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblDebitNoteDetail>(entity =>
        {
            entity.HasKey(e => e.DebitNoteDetailsId).HasName("PK__tbl_Debi__42220582469E3CA0");

            entity.ToTable("tbl_DebitNoteDetails");

            entity.Property(e => e.DebitNoteDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("debitNoteDetailsId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.DebitNoteMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("debitNoteMasterId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.ReferenceDate)
                .HasColumnType("datetime")
                .HasColumnName("referenceDate");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
        });

        modelBuilder.Entity<TblDebitNoteMaster>(entity =>
        {
            entity.HasKey(e => e.DebitNoteMasterId).HasName("PK__tbl_Debi__1229ABA914C6E9EA");

            entity.ToTable("tbl_DebitNoteMaster");

            entity.Property(e => e.DebitNoteMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("debitNoteMasterId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DebitNoteType)
                .IsUnicode(false)
                .HasColumnName("debitNoteType");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerBalanceId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerBalanceId");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.ReferenceDate)
                .HasColumnType("datetime")
                .HasColumnName("referenceDate");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblDeliveryNoteDetail>(entity =>
        {
            entity.HasKey(e => e.DeliveryNoteDetailsId).HasName("PK__tbl_Deli__A9A4649E51CFF82A");

            entity.ToTable("tbl_DeliveryNoteDetails");

            entity.Property(e => e.DeliveryNoteDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deliveryNoteDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CostRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("costRate");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DeliveryNoteMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deliveryNoteMasterId");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.DiscountAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discountAmount");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.IsDiscountPercentage).HasColumnName("isDiscountPercentage");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("netAmount");
            entity.Property(e => e.OrderDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("orderDetailsId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.QuotationDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationDetailsId");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.RateExcTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateExcTax");
            entity.Property(e => e.RateIncTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateIncTax");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblDeliveryNoteMaster>(entity =>
        {
            entity.HasKey(e => e.DeliveryNoteMasterId).HasName("PK__tbl_Deli__72FF880F4DFF6746");

            entity.ToTable("tbl_DeliveryNoteMaster");

            entity.Property(e => e.DeliveryNoteMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deliveryNoteMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.CounterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("counterId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");
            entity.Property(e => e.CustomerName)
                .IsUnicode(false)
                .HasColumnName("customerName");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.OrderMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("orderMasterId");
            entity.Property(e => e.PaymentAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("paymentAmount");
            entity.Property(e => e.PaymentTermId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentTermId");
            entity.Property(e => e.PaymentType)
                .IsUnicode(false)
                .HasColumnName("paymentType");
            entity.Property(e => e.Pos).HasColumnName("POS");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.QuotationMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationMasterId");
            entity.Property(e => e.SalesAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesAccount");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.WorkPeriodId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("workPeriodId");
        });

        modelBuilder.Entity<TblDepartment>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__tbl_Depa__F9B8346DFD9D5378");

            entity.ToTable("tbl_Department");

            entity.Property(e => e.DepartmentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("departmentId");
            entity.Property(e => e.DepartmentCode)
                .HasMaxLength(20)
                .HasColumnName("departmentCode");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .HasColumnName("departmentName");
            entity.Property(e => e.Extra1)
                .HasMaxLength(100)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .HasMaxLength(100)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .HasMaxLength(100)
                .HasColumnName("narration");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
        });

        modelBuilder.Entity<TblDesignation>(entity =>
        {
            entity.HasKey(e => e.DesignationId).HasName("PK__tbl_Desi__197CE32A30C33EC3");

            entity.ToTable("tbl_Designation");

            entity.Property(e => e.DesignationId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("designationId");
            entity.Property(e => e.AdvanceAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("advanceAmount");
            entity.Property(e => e.DesignationName)
                .IsUnicode(false)
                .HasColumnName("designationName");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.LeaveDays)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("leaveDays");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblDetail>(entity =>
        {
            entity.HasKey(e => e.DetailsId);

            entity.ToTable("tbl_Details");

            entity.Property(e => e.DetailsId).HasColumnName("detailsId");
            entity.Property(e => e.Align)
                .IsUnicode(false)
                .HasColumnName("align");
            entity.Property(e => e.Columns).HasColumnName("columns");
            entity.Property(e => e.Dbf)
                .IsUnicode(false)
                .HasColumnName("dbf");
            entity.Property(e => e.DorH).IsUnicode(false);
            entity.Property(e => e.ExtraFieldName)
                .IsUnicode(false)
                .HasColumnName("extraFieldName");
            entity.Property(e => e.FieldsForExtra)
                .IsUnicode(false)
                .HasColumnName("fieldsForExtra");
            entity.Property(e => e.FooterRepeatAll)
                .IsUnicode(false)
                .HasColumnName("footerRepeatAll");
            entity.Property(e => e.MasterId).HasColumnName("masterId");
            entity.Property(e => e.Name)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Repeat)
                .IsUnicode(false)
                .HasColumnName("repeat");
            entity.Property(e => e.RepeatAll)
                .IsUnicode(false)
                .HasColumnName("repeatAll");
            entity.Property(e => e.Row).HasColumnName("row");
            entity.Property(e => e.Text)
                .IsUnicode(false)
                .HasColumnName("text");
            entity.Property(e => e.TextWrap)
                .IsUnicode(false)
                .HasColumnName("textWrap");
            entity.Property(e => e.Width).HasColumnName("width");
            entity.Property(e => e.WrapLineCount).HasColumnName("wrapLineCount");
        });

        modelBuilder.Entity<TblDetailsCopy>(entity =>
        {
            entity.HasKey(e => e.DetailsId);

            entity.ToTable("tbl_DetailsCopy");

            entity.Property(e => e.DetailsId).HasColumnName("detailsId");
            entity.Property(e => e.Align)
                .IsUnicode(false)
                .HasColumnName("align");
            entity.Property(e => e.Columns).HasColumnName("columns");
            entity.Property(e => e.Dbf)
                .IsUnicode(false)
                .HasColumnName("dbf");
            entity.Property(e => e.DorH).IsUnicode(false);
            entity.Property(e => e.ExtraFieldName)
                .IsUnicode(false)
                .HasColumnName("extraFieldName");
            entity.Property(e => e.FieldsForExtra)
                .IsUnicode(false)
                .HasColumnName("fieldsForExtra");
            entity.Property(e => e.FooterRepeatAll)
                .IsUnicode(false)
                .HasColumnName("footerRepeatAll");
            entity.Property(e => e.MasterId).HasColumnName("masterId");
            entity.Property(e => e.Name)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Repeat)
                .IsUnicode(false)
                .HasColumnName("repeat");
            entity.Property(e => e.RepeatAll)
                .IsUnicode(false)
                .HasColumnName("repeatAll");
            entity.Property(e => e.Row).HasColumnName("row");
            entity.Property(e => e.Text)
                .IsUnicode(false)
                .HasColumnName("text");
            entity.Property(e => e.TextWrap)
                .IsUnicode(false)
                .HasColumnName("textWrap");
            entity.Property(e => e.Width).HasColumnName("width");
            entity.Property(e => e.WrapLineCount).HasColumnName("wrapLineCount");
        });

        modelBuilder.Entity<TblEmployee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__tbl_Empl__C134C9C125518C17");

            entity.ToTable("tbl_Employee");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.BankAccountNumber)
                .IsUnicode(false)
                .HasColumnName("bankAccountNumber");
            entity.Property(e => e.BankName)
                .IsUnicode(false)
                .HasColumnName("bankName");
            entity.Property(e => e.BloodGroup)
                .IsUnicode(false)
                .HasColumnName("bloodGroup");
            entity.Property(e => e.BranchCode)
                .IsUnicode(false)
                .HasColumnName("branchCode");
            entity.Property(e => e.BranchName)
                .IsUnicode(false)
                .HasColumnName("branchName");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DailyWage)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("dailyWage");
            entity.Property(e => e.DefaultPackageId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("defaultPackageId");
            entity.Property(e => e.DesignationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("designationId");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("dob");
            entity.Property(e => e.Email)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EmployeeCode)
                .IsUnicode(false)
                .HasColumnName("employeeCode");
            entity.Property(e => e.EmployeeName)
                .IsUnicode(false)
                .HasColumnName("employeeName");
            entity.Property(e => e.EsiNumber)
                .IsUnicode(false)
                .HasColumnName("esiNumber");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Gender)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.JoiningDate)
                .HasColumnType("datetime")
                .HasColumnName("joiningDate");
            entity.Property(e => e.LabourCardExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("labourCardExpiryDate");
            entity.Property(e => e.LabourCardNumber)
                .IsUnicode(false)
                .HasColumnName("labourCardNumber");
            entity.Property(e => e.ManagerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("managerId");
            entity.Property(e => e.MaritalStatus)
                .IsUnicode(false)
                .HasColumnName("maritalStatus");
            entity.Property(e => e.MobileNumber)
                .IsUnicode(false)
                .HasColumnName("mobileNumber");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.MonthlyWage)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("monthlyWage");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PanNumber)
                .IsUnicode(false)
                .HasColumnName("panNumber");
            entity.Property(e => e.PassportExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("passportExpiryDate");
            entity.Property(e => e.PassportNo)
                .IsUnicode(false)
                .HasColumnName("passportNo");
            entity.Property(e => e.PfNumber)
                .IsUnicode(false)
                .HasColumnName("pfNumber");
            entity.Property(e => e.PhoneNumber)
                .IsUnicode(false)
                .HasColumnName("phoneNumber");
            entity.Property(e => e.Qualification)
                .IsUnicode(false)
                .HasColumnName("qualification");
            entity.Property(e => e.SalaryType)
                .IsUnicode(false)
                .HasColumnName("salaryType");
            entity.Property(e => e.SocialSecurityId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("socialSecurityId");
            entity.Property(e => e.TerminationDate)
                .HasColumnType("datetime")
                .HasColumnName("terminationDate");
            entity.Property(e => e.VisaExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("visaExpiryDate");
            entity.Property(e => e.VisaNumber)
                .IsUnicode(false)
                .HasColumnName("visaNumber");
        });

        modelBuilder.Entity<TblEmployeeFingerprint>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK_EmployeeFingerprint");

            entity.ToTable("tbl_EmployeeFingerprint");

            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("EmployeeID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Extra1)
                .HasMaxLength(100)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .HasMaxLength(100)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .HasMaxLength(500)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblEmployeeSocialSecurity>(entity =>
        {
            entity.HasKey(e => e.EmployeeSocialSecurityId).HasName("PK__tbl_Empl__A770E73A559D595A");

            entity.ToTable("tbl_EmployeeSocialSecurity");

            entity.Property(e => e.EmployeeSocialSecurityId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Extra1).HasMaxLength(100);
            entity.Property(e => e.Extra2).HasMaxLength(100);
            entity.Property(e => e.ExtraDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SocialSecurityId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<TblExchangeRate>(entity =>
        {
            entity.HasKey(e => e.ExchangeRateId).HasName("PK__tbl_Exch__DE88B8415CF6C6BC");

            entity.ToTable("tbl_ExchangeRate");

            entity.Property(e => e.ExchangeRateId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CurrencyId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("currencyId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
        });

        modelBuilder.Entity<TblExpense>(entity =>
        {
            entity.HasKey(e => e.ExpensesId).HasName("PK__tbl_Exp__455070DF70099B30");

            entity.ToTable("tbl_Expenses");

            entity.Property(e => e.ExpensesId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("expensesId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.ExpensesCategoryId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("expensesCategoryId");
            entity.Property(e => e.ExpensesName)
                .IsUnicode(false)
                .HasColumnName("expensesName");
            entity.Property(e => e.ExpensesTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("expensesTypeId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
        });

        modelBuilder.Entity<TblExpensesCategory>(entity =>
        {
            entity.HasKey(e => e.ExpensesCategoryId).HasName("PK__tbl_Exp__77EC43563AA1AEB8");

            entity.ToTable("tbl_ExpensesCategory");

            entity.Property(e => e.ExpensesCategoryId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("expensesCategoryId");
            entity.Property(e => e.CategoryName)
                .IsUnicode(false)
                .HasColumnName("categoryName");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblExpensesDetail>(entity =>
        {
            entity.HasKey(e => e.ExpensesDetailsId).HasName("PK__tbl_ExpDetails__67AF05292BAA4F42");

            entity.ToTable("tbl_ExpensesDetails");

            entity.Property(e => e.ExpensesDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("expensesDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.CostRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("costRate");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.DiscountAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discountAmount");
            entity.Property(e => e.ExpensesId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("expensesId");
            entity.Property(e => e.ExpensesMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("expensesMasterId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.IsDiscountPercentage).HasColumnName("isDiscountPercentage");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("netAmount");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.Unit)
                .IsUnicode(false)
                .HasColumnName("unit");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblExpensesMaster>(entity =>
        {
            entity.HasKey(e => e.ExpensesMasterId).HasName("PK__tbl_ExpMaster__9D353EFC20389C96");

            entity.ToTable("tbl_ExpensesMaster");

            entity.Property(e => e.ExpensesMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("expensesMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CreditPeriod)
                .IsUnicode(false)
                .HasColumnName("creditPeriod");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.ExpensesAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("expensesAccount");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PaymentAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("paymentAmount");
            entity.Property(e => e.PaymentTermId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentTermId");
            entity.Property(e => e.PaymentType)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentType");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VendorInvoiceDate)
                .HasColumnType("datetime")
                .HasColumnName("vendorInvoiceDate");
            entity.Property(e => e.VendorInvoiceNo)
                .IsUnicode(false)
                .HasColumnName("vendorInvoiceNo");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblField>(entity =>
        {
            entity.HasKey(e => e.FieldId);

            entity.ToTable("tbl_Fields");

            entity.Property(e => e.FieldId).HasColumnName("fieldId");
            entity.Property(e => e.FieldName)
                .IsUnicode(false)
                .HasColumnName("fieldName");
            entity.Property(e => e.FormId).HasColumnName("formId");
        });

        modelBuilder.Entity<TblFieldsCopy>(entity =>
        {
            entity.HasKey(e => e.FieldId);

            entity.ToTable("tbl_FieldsCopy");

            entity.Property(e => e.FieldId).HasColumnName("fieldId");
            entity.Property(e => e.FieldName)
                .IsUnicode(false)
                .HasColumnName("fieldName");
            entity.Property(e => e.FormId).HasColumnName("formId");
        });

        modelBuilder.Entity<TblFinancialYear>(entity =>
        {
            entity.HasKey(e => e.FinancialYearId).HasName("PK__tbl_Fina__FE30A41137661AB1");

            entity.ToTable("tbl_FinancialYear");

            entity.Property(e => e.FinancialYearId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("fromDate");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("toDate");
        });

        modelBuilder.Entity<TblForm>(entity =>
        {
            entity.HasKey(e => e.FormId);

            entity.ToTable("tbl_Form");

            entity.Property(e => e.FormId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("formId");
            entity.Property(e => e.ActionType)
                .IsUnicode(false)
                .HasColumnName("actionType");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FormLink)
                .IsUnicode(false)
                .HasColumnName("formLink");
            entity.Property(e => e.FormModule)
                .IsUnicode(false)
                .HasColumnName("formModule");
            entity.Property(e => e.FormModuleAr)
                .IsUnicode(false)
                .HasColumnName("formModule_ar");
            entity.Property(e => e.FormName)
                .IsUnicode(false)
                .HasColumnName("formName");
            entity.Property(e => e.FormNameAr)
                .IsUnicode(false)
                .HasColumnName("formName_ar");
            entity.Property(e => e.FormOrder).HasColumnName("formOrder");
            entity.Property(e => e.FormType)
                .IsUnicode(false)
                .HasColumnName("formType");
            entity.Property(e => e.FormTypeAr)
                .IsUnicode(false)
                .HasColumnName("formType_ar");
            entity.Property(e => e.Licence)
                .IsUnicode(false)
                .HasColumnName("licence");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.ParentFormId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("parentFormId");
        });

        modelBuilder.Entity<TblFormActionType>(entity =>
        {
            entity.HasKey(e => e.ActionId);

            entity.ToTable("tbl_FormActionType");

            entity.Property(e => e.ActionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("actionId");
            entity.Property(e => e.Action)
                .IsUnicode(false)
                .HasColumnName("action");
            entity.Property(e => e.ActionName)
                .IsUnicode(false)
                .HasColumnName("actionName");
            entity.Property(e => e.ActionNameAr)
                .IsUnicode(false)
                .HasColumnName("actionName_ar");
            entity.Property(e => e.ActionType)
                .IsUnicode(false)
                .HasColumnName("actionType");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
        });

        modelBuilder.Entity<TblFormCopy>(entity =>
        {
            entity.HasKey(e => e.FormId);

            entity.ToTable("tbl_FormCopy");

            entity.Property(e => e.FormId).HasColumnName("formId");
            entity.Property(e => e.FormName)
                .IsUnicode(false)
                .HasColumnName("formName");
        });

        modelBuilder.Entity<TblGodown>(entity =>
        {
            entity.HasKey(e => e.GodownId).HasName("PK__tbl_Godo__14F1AFAB51851410");

            entity.ToTable("tbl_Godown");

            entity.Property(e => e.GodownId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownName)
                .IsUnicode(false)
                .HasColumnName("godownName");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblHoliday>(entity =>
        {
            entity.HasKey(e => e.HolidayId).HasName("PK__tbl_Holi__EB855CEF29221CFB");

            entity.ToTable("tbl_Holiday");

            entity.Property(e => e.HolidayId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("holidayId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.HolidayName)
                .IsUnicode(false)
                .HasColumnName("holidayName");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblJournalDetail>(entity =>
        {
            entity.HasKey(e => e.JournalDetailsId).HasName("PK__tbl_Jour__3C76D92F764262CA");

            entity.ToTable("tbl_JournalDetails");

            entity.Property(e => e.JournalDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("journalDetailsId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.JournalMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("journalMasterId");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.ReferenceDate)
                .HasColumnType("datetime")
                .HasColumnName("referenceDate");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
        });

        modelBuilder.Entity<TblJournalDetailsBak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_JournalDetails_BAK");

            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.JournalDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("journalDetailsId");
            entity.Property(e => e.JournalMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("journalMasterId");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.ReferenceDate)
                .HasColumnType("datetime")
                .HasColumnName("referenceDate");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
        });

        modelBuilder.Entity<TblJournalMaster>(entity =>
        {
            entity.HasKey(e => e.JournalMasterId).HasName("PK__tbl_Jour__90D22FBE7271D1E6");

            entity.ToTable("tbl_JournalMaster");

            entity.Property(e => e.JournalMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("journalMasterId");
            entity.Property(e => e.AgainstVoucherId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstVoucherId");
            entity.Property(e => e.AgainstVoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstVoucherTypeId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblJournalMasterBak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_JournalMaster_BAK");

            entity.Property(e => e.AgainstVoucherId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstVoucherId");
            entity.Property(e => e.AgainstVoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstVoucherTypeId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.JournalMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("journalMasterId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblLedgerPosting>(entity =>
        {
            entity.HasKey(e => e.LedgerPostingId).HasName("PK__tbl_Ledg__730FE2D769FBBC1F");

            entity.ToTable("tbl_LedgerPosting");

            entity.Property(e => e.LedgerPostingId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerPostingId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.DetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("detailsId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.ReferenceDate)
                .HasColumnType("datetime")
                .HasColumnName("referenceDate");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblLedgerPostingBak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_LedgerPosting_BAK");

            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.DetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("detailsId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LedgerPostingId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerPostingId");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.ReferenceDate)
                .HasColumnType("datetime")
                .HasColumnName("referenceDate");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblLicenseKey>(entity =>
        {
            entity.HasKey(e => e.LicenseId);

            entity.ToTable("tbl_LicenseKey");

            entity.Property(e => e.LicenseId).HasColumnName("licenseId");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creationDate");
            entity.Property(e => e.ExpireDate)
                .HasColumnType("datetime")
                .HasColumnName("expireDate");
            entity.Property(e => e.LicenseKey).HasColumnName("licenseKey");
            entity.Property(e => e.SecretCode).HasColumnName("secretCode");
        });

        modelBuilder.Entity<TblMaster>(entity =>
        {
            entity.HasKey(e => e.MasterId);

            entity.ToTable("tbl_Master");

            entity.Property(e => e.MasterId).HasColumnName("masterId");
            entity.Property(e => e.BlankLneForFooter).HasColumnName("blankLneForFooter");
            entity.Property(e => e.Condensed)
                .IsUnicode(false)
                .HasColumnName("condensed");
            entity.Property(e => e.FooterLocation)
                .IsUnicode(false)
                .HasColumnName("footerLocation");
            entity.Property(e => e.FormName).HasColumnName("formName");
            entity.Property(e => e.IsTwoLineForDetails).HasColumnName("isTwoLineForDetails");
            entity.Property(e => e.IsTwoLineForHedder).HasColumnName("isTwoLineForHedder");
            entity.Property(e => e.LineCountAfterPrint).HasColumnName("lineCountAfterPrint");
            entity.Property(e => e.LineCountBetweenTwo).HasColumnName("lineCountBetweenTwo");
            entity.Property(e => e.PageSize1).HasColumnName("pageSize1");
            entity.Property(e => e.PageSizeOther).HasColumnName("pageSizeOther");
            entity.Property(e => e.Pitch)
                .IsUnicode(false)
                .HasColumnName("pitch");
        });

        modelBuilder.Entity<TblMasterCopy>(entity =>
        {
            entity.HasKey(e => e.MasterId);

            entity.ToTable("tbl_MasterCopy");

            entity.Property(e => e.MasterId)
                .ValueGeneratedNever()
                .HasColumnName("masterId");
            entity.Property(e => e.BlankLneForFooter).HasColumnName("blankLneForFooter");
            entity.Property(e => e.Condensed)
                .IsUnicode(false)
                .HasColumnName("condensed");
            entity.Property(e => e.FooterLocation)
                .IsUnicode(false)
                .HasColumnName("footerLocation");
            entity.Property(e => e.FormName).HasColumnName("formName");
            entity.Property(e => e.IsTwoLineForDetails).HasColumnName("isTwoLineForDetails");
            entity.Property(e => e.IsTwoLineForHedder).HasColumnName("isTwoLineForHedder");
            entity.Property(e => e.LineCountAfterPrint).HasColumnName("lineCountAfterPrint");
            entity.Property(e => e.LineCountBetweenTwo).HasColumnName("lineCountBetweenTwo");
            entity.Property(e => e.PageSize1).HasColumnName("pageSize1");
            entity.Property(e => e.PageSizeOther).HasColumnName("pageSizeOther");
            entity.Property(e => e.Pitch)
                .IsUnicode(false)
                .HasColumnName("pitch");
        });

        modelBuilder.Entity<TblMasterDataPrivilege>(entity =>
        {
            entity.HasKey(e => e.PrivilegeId);

            entity.ToTable("tbl_MasterDataPrivilege");

            entity.Property(e => e.PrivilegeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("privilegeId");
            entity.Property(e => e.Action)
                .IsUnicode(false)
                .HasColumnName("action");
            entity.Property(e => e.Exatra1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("exatra1");
            entity.Property(e => e.Extra2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.MasterDataId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterDataId");
            entity.Property(e => e.MasterDataType)
                .IsUnicode(false)
                .HasColumnName("masterDataType");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
        });

        modelBuilder.Entity<TblMaterialReceiptDetail>(entity =>
        {
            entity.HasKey(e => e.MaterialReceiptDetailsId).HasName("PK__tbl_Mate__320D49ED77F5A112");

            entity.ToTable("tbl_MaterialReceiptDetails");

            entity.Property(e => e.MaterialReceiptDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("materialReceiptDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CostRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("costRate");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.DiscountAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discountAmount");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.IsDiscountPercentage).HasColumnName("isDiscountPercentage");
            entity.Property(e => e.MaterialReceiptMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("materialReceiptMasterId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("netAmount");
            entity.Property(e => e.OrderDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("orderDetailsId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.PurchaseRequisitionDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseRequisitionDetailsId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.RateExcTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateExcTax");
            entity.Property(e => e.RateIncTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateIncTax");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblMaterialReceiptMaster>(entity =>
        {
            entity.HasKey(e => e.MaterialReceiptMasterId).HasName("PK__tbl_Mate__47E4E4697425102E");

            entity.ToTable("tbl_MaterialReceiptMaster");

            entity.Property(e => e.MaterialReceiptMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("materialReceiptMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CreditPeriod)
                .IsUnicode(false)
                .HasColumnName("creditPeriod");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PaymentAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("paymentAmount");
            entity.Property(e => e.PaymentTermId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentTermId");
            entity.Property(e => e.PaymentType)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentType");
            entity.Property(e => e.PurchaseAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseAccount");
            entity.Property(e => e.PurchaseOrderMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseOrderMasterId");
            entity.Property(e => e.PurchaseRequisitionMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseRequisitionMasterId");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VendorInvoiceDate)
                .HasColumnType("datetime")
                .HasColumnName("vendorInvoiceDate");
            entity.Property(e => e.VendorInvoiceNo)
                .IsUnicode(false)
                .HasColumnName("vendorInvoiceNo");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblModelNo>(entity =>
        {
            entity.HasKey(e => e.ModelNoId).HasName("PK__tbl_Mode__8458D8C94DB4832C");

            entity.ToTable("tbl_ModelNo");

            entity.Property(e => e.ModelNoId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modelNoId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModelNo)
                .IsUnicode(false)
                .HasColumnName("modelNo");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblMonthlySalary>(entity =>
        {
            entity.HasKey(e => e.MonthlySalaryId).HasName("PK__tbl_Mont__DD79B8643C34F16F");

            entity.ToTable("tbl_MonthlySalary");

            entity.Property(e => e.MonthlySalaryId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("monthlySalaryId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SalaryMonth)
                .HasColumnType("datetime")
                .HasColumnName("salaryMonth");
        });

        modelBuilder.Entity<TblMonthlySalaryDetail>(entity =>
        {
            entity.HasKey(e => e.MonthlySalaryDetailsId).HasName("PK__tbl_Mont__04252B5040058253");

            entity.ToTable("tbl_MonthlySalaryDetails");

            entity.Property(e => e.MonthlySalaryDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("monthlySalaryDetailsId");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.MonthlySalaryId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("monthlySalaryId");
            entity.Property(e => e.SalaryPackageId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salaryPackageId");
        });

        modelBuilder.Entity<TblPartyBalance>(entity =>
        {
            entity.HasKey(e => e.PartyBalanceId).HasName("PK__tbl_Part__69824BB71C680BB2");

            entity.ToTable("tbl_PartyBalance");

            entity.Property(e => e.PartyBalanceId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("partyBalanceId");
            entity.Property(e => e.AgainstInvoiceNo)
                .IsUnicode(false)
                .HasColumnName("againstInvoiceNo");
            entity.Property(e => e.AgainstVoucherMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstVoucherMasterId");
            entity.Property(e => e.AgainstVoucherNo)
                .IsUnicode(false)
                .HasColumnName("againstVoucherNo");
            entity.Property(e => e.AgainstVoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstVoucherTypeId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.ReferenceType)
                .IsUnicode(false)
                .HasColumnName("referenceType");
            entity.Property(e => e.VoucherMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherMasterId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPayHead>(entity =>
        {
            entity.HasKey(e => e.PayHeadId).HasName("PK__tbl_PayH__1BAC6FBD2CF2ADDF");

            entity.ToTable("tbl_PayHead");

            entity.Property(e => e.PayHeadId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("payHeadId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PayHeadName)
                .IsUnicode(false)
                .HasColumnName("payHeadName");
            entity.Property(e => e.Type)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<TblPaymentDetail>(entity =>
        {
            entity.HasKey(e => e.PaymentDetailsId).HasName("PK__tbl_Paym__2549CB8A6AD0B01E");

            entity.ToTable("tbl_PaymentDetails");

            entity.Property(e => e.PaymentDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.PaymentMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentMasterId");
        });

        modelBuilder.Entity<TblPaymentMaster>(entity =>
        {
            entity.HasKey(e => e.PaymentMasterId).HasName("PK__tbl_Paym__F6D0847167001F3A");

            entity.ToTable("tbl_PaymentMaster");

            entity.Property(e => e.PaymentMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentMasterId");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerBankId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerBankId");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PaymentMethod)
                .IsUnicode(false)
                .HasColumnName("paymentMethod");
            entity.Property(e => e.ReferenceDate)
                .HasColumnType("datetime")
                .HasColumnName("referenceDate");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPaymentTerm>(entity =>
        {
            entity.HasKey(e => e.PaymentTermId);

            entity.ToTable("tbl_PaymentTerms");

            entity.Property(e => e.PaymentTermId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentTermId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DueDaysCalculation)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("dueDaysCalculation");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PaymentTermName)
                .IsUnicode(false)
                .HasColumnName("paymentTermName");
        });

        modelBuilder.Entity<TblPdcclearanceMaster>(entity =>
        {
            entity.HasKey(e => e.PdcclearanceMasterId).HasName("PK__tbl_PDCC__D88D38E00955373E");

            entity.ToTable("tbl_PDCClearanceMaster");

            entity.Property(e => e.PdcclearanceMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PDCClearanceMasterId");
            entity.Property(e => e.AgainstVoucherId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstVoucherId");
            entity.Property(e => e.AgainstVoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstVoucherTypeId");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerBankId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerBankId");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PaymentMethod)
                .IsUnicode(false)
                .HasColumnName("paymentMethod");
            entity.Property(e => e.PdcclearanceStatus)
                .IsUnicode(false)
                .HasColumnName("PDCClearanceStatus");
            entity.Property(e => e.ReferenceDate)
                .HasColumnType("datetime")
                .HasColumnName("referenceDate");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPdcpayableMaster>(entity =>
        {
            entity.HasKey(e => e.PdcPayableMasterId).HasName("PK__tbl_PDCP__D5E696DE01B41576");

            entity.ToTable("tbl_PDCPayableMaster");

            entity.Property(e => e.PdcPayableMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pdcPayableMasterId");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerBankId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerBankId");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PaymentMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentMasterId");
            entity.Property(e => e.PaymentMethod)
                .IsUnicode(false)
                .HasColumnName("paymentMethod");
            entity.Property(e => e.PdcPayableStatus)
                .IsUnicode(false)
                .HasColumnName("pdcPayableStatus");
            entity.Property(e => e.ReferenceDate)
                .HasColumnType("datetime")
                .HasColumnName("referenceDate");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPdcreceivableMaster>(entity =>
        {
            entity.HasKey(e => e.PdcReceivableMasterId).HasName("PK__tbl_PDCR__A14C5E250584A65A");

            entity.ToTable("tbl_PDCReceivableMaster");

            entity.Property(e => e.PdcReceivableMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pdcReceivableMasterId");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerBankId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerBankId");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PaymentMethod)
                .IsUnicode(false)
                .HasColumnName("paymentMethod");
            entity.Property(e => e.PdcReceivableStatus)
                .IsUnicode(false)
                .HasColumnName("pdcReceivableStatus");
            entity.Property(e => e.ReceiptMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("receiptMasterId");
            entity.Property(e => e.ReferenceDate)
                .HasColumnType("datetime")
                .HasColumnName("referenceDate");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPhysicalStockDetail>(entity =>
        {
            entity.HasKey(e => e.PhysicalStockDetailsId).HasName("PK__tbl_Phys__A94165330ED9066A");

            entity.ToTable("tbl_PhysicalStockDetails");

            entity.Property(e => e.PhysicalStockDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("physicalStockDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.PhysicalStockMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("physicalStockMasterId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.Slno).HasColumnName("slno");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblPhysicalStockInDetail>(entity =>
        {
            entity.HasKey(e => e.PhysicalStockDetailsId).HasName("PK__tbl_PhysIn__A94165330ED9066A");

            entity.ToTable("tbl_PhysicalStockInDetails");

            entity.Property(e => e.PhysicalStockDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("physicalStockDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.PhysicalStockMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("physicalStockMasterId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.Slno).HasColumnName("slno");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblPhysicalStockInMaster>(entity =>
        {
            entity.HasKey(e => e.PhysicalStockMasterId).HasName("PK__tbl_PhysIn__7367DF7A0B087586");

            entity.ToTable("tbl_PhysicalStockInMaster");

            entity.Property(e => e.PhysicalStockMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("physicalStockMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPhysicalStockMaster>(entity =>
        {
            entity.HasKey(e => e.PhysicalStockMasterId).HasName("PK__tbl_Phys__7367DF7A0B087586");

            entity.ToTable("tbl_PhysicalStockMaster");

            entity.Property(e => e.PhysicalStockMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("physicalStockMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPhysicalStockOutDetail>(entity =>
        {
            entity.HasKey(e => e.PhysicalStockDetailsId).HasName("PK__tbl_PhysOut__A94165330ED9066A");

            entity.ToTable("tbl_PhysicalStockOutDetails");

            entity.Property(e => e.PhysicalStockDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("physicalStockDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.PhysicalStockMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("physicalStockMasterId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.Slno).HasColumnName("slno");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblPhysicalStockOutMaster>(entity =>
        {
            entity.HasKey(e => e.PhysicalStockMasterId).HasName("PK__tbl_PhysOut__7367DF7A0B087586");

            entity.ToTable("tbl_PhysicalStockOutMaster");

            entity.Property(e => e.PhysicalStockMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("physicalStockMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPostingSetup>(entity =>
        {
            entity.HasKey(e => e.PostingSetupId);

            entity.ToTable("tbl_PostingSetup");

            entity.Property(e => e.PostingSetupId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("postingSetupId");
            entity.Property(e => e.AdditionalCostId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("additionalCostId");
            entity.Property(e => e.BankId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bankId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CustomerGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("customerGroupId");
            entity.Property(e => e.CustomerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("customerId");
            entity.Property(e => e.ExpensesCategoryId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("expensesCategoryId");
            entity.Property(e => e.ExpensesId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("expensesId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.PostineLedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("postineLedgerId");
            entity.Property(e => e.PostingType).HasColumnName("postingType");
            entity.Property(e => e.ProductGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productGroupId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.ServiceCategoryId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceCategoryId");
            entity.Property(e => e.ServiceId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceId");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.VendorGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("vendorGroupId");
            entity.Property(e => e.VendorId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("vendorId");
        });

        modelBuilder.Entity<TblPriceList>(entity =>
        {
            entity.HasKey(e => e.PricelistId).HasName("PK__tbl_Pric__81BD4B85278EDA44");

            entity.ToTable("tbl_PriceList");

            entity.Property(e => e.PricelistId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricelistId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsIncrease).HasColumnName("isIncrease");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Percentage)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("percentage");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblPricingLevel>(entity =>
        {
            entity.HasKey(e => e.PricinglevelId).HasName("PK__tbl_Pric__84E896EA23BE4960");

            entity.ToTable("tbl_PricingLevel");

            entity.Property(e => e.PricinglevelId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FixedPercentage)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("fixedPercentage");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PricinglevelName)
                .IsUnicode(false)
                .HasColumnName("pricinglevelName");
        });

        modelBuilder.Entity<TblPrivilege>(entity =>
        {
            entity.HasKey(e => e.PrivilegeId);

            entity.ToTable("tbl_Privilege");

            entity.Property(e => e.PrivilegeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("privilegeId");
            entity.Property(e => e.Action)
                .IsUnicode(false)
                .HasColumnName("action");
            entity.Property(e => e.Exatra1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("exatra1");
            entity.Property(e => e.Extra2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FormName)
                .IsUnicode(false)
                .HasColumnName("formName");
            entity.Property(e => e.RoleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("roleId");
        });

        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__tbl_Prod__2D10D16A1FEDB87C");

            entity.ToTable("tbl_Product");

            entity.Property(e => e.ProductId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.BrandId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("brandId");
            entity.Property(e => e.Consumable).HasColumnName("consumable");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupId");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsBom).HasColumnName("isBom");
            entity.Property(e => e.IsallowBatch).HasColumnName("isallowBatch");
            entity.Property(e => e.Ismultipleunit).HasColumnName("ismultipleunit");
            entity.Property(e => e.Isopeningstock).HasColumnName("isopeningstock");
            entity.Property(e => e.IsshowRemember).HasColumnName("isshowRemember");
            entity.Property(e => e.MaximumStock)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("maximumStock");
            entity.Property(e => e.MinimumStock)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("minimumStock");
            entity.Property(e => e.ModelNoId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modelNoId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Mrp)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("mrp");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PartNo)
                .IsUnicode(false)
                .HasColumnName("partNo");
            entity.Property(e => e.ProductCode)
                .IsUnicode(false)
                .HasColumnName("productCode");
            entity.Property(e => e.ProductImage)
                .HasColumnType("image")
                .HasColumnName("productImage");
            entity.Property(e => e.ProductImageString)
                .IsUnicode(false)
                .HasColumnName("productImageString");
            entity.Property(e => e.ProductName)
                .IsUnicode(false)
                .HasColumnName("productName");
            entity.Property(e => e.ProductTrackingType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("productTrackingType");
            entity.Property(e => e.ProductType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("productType");
            entity.Property(e => e.Purchasable).HasColumnName("purchasable");
            entity.Property(e => e.PurchaseRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("purchaseRate");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.ReorderLevel)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("reorderLevel");
            entity.Property(e => e.Saleable).HasColumnName("saleable");
            entity.Property(e => e.SalesRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("salesRate");
            entity.Property(e => e.SizeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("sizeId");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.TaxapplicableOn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("taxapplicableOn");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblProductGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__tbl_Prod__88C1034D10AB74EC");

            entity.ToTable("tbl_ProductGroup");

            entity.Property(e => e.GroupId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupId");
            entity.Property(e => e.BackColor)
                .IsUnicode(false)
                .HasColumnName("backColor");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FontColor)
                .IsUnicode(false)
                .HasColumnName("fontColor");
            entity.Property(e => e.GroupName)
                .IsUnicode(false)
                .HasColumnName("groupName");
            entity.Property(e => e.GroupUnder)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupUnder");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SortOrder)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("sortOrder");
        });

        modelBuilder.Entity<TblProductPrinterSetup>(entity =>
        {
            entity.HasKey(e => e.SetupId).HasName("tbl_PrinterSetup");

            entity.ToTable("tbl_ProductPrinterSetup");

            entity.Property(e => e.SetupId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("setupId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PrinterName)
                .IsUnicode(false)
                .HasColumnName("printerName");
            entity.Property(e => e.ProductGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productGroupId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.ReportrName)
                .IsUnicode(false)
                .HasColumnName("reportrName");
        });

        modelBuilder.Entity<TblPurchaseBillTax>(entity =>
        {
            entity.HasKey(e => e.PurchaseBillTaxId).HasName("PK__tbl_Purc__1B87331A27D9BE5E");

            entity.ToTable("tbl_PurchaseBillTax");

            entity.Property(e => e.PurchaseBillTaxId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseBillTaxId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.PurchaseMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseMasterId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
        });

        modelBuilder.Entity<TblPurchaseDetail>(entity =>
        {
            entity.HasKey(e => e.PurchaseDetailsId).HasName("PK__tbl_Purc__67AF05292BAA4F42");

            entity.ToTable("tbl_PurchaseDetails");

            entity.Property(e => e.PurchaseDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CostRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("costRate");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.DiscountAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discountAmount");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.IsDiscountPercentage).HasColumnName("isDiscountPercentage");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("netAmount");
            entity.Property(e => e.OrderDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("orderDetailsId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.PurchaseMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseMasterId");
            entity.Property(e => e.PurchaseRequisitionDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseRequisitionDetailsId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.RateExcTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateExcTax");
            entity.Property(e => e.RateIncTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateIncTax");
            entity.Property(e => e.ReceiptDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("receiptDetailsId");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblPurchaseMaster>(entity =>
        {
            entity.HasKey(e => e.PurchaseMasterId).HasName("PK__tbl_Purc__9D353EFC20389C96");

            entity.ToTable("tbl_PurchaseMaster");

            entity.Property(e => e.PurchaseMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CreditPeriod)
                .IsUnicode(false)
                .HasColumnName("creditPeriod");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.MaterialReceiptMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("materialReceiptMasterId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PaymentAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("paymentAmount");
            entity.Property(e => e.PaymentTermId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentTermId");
            entity.Property(e => e.PaymentType)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentType");
            entity.Property(e => e.PurchaseAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseAccount");
            entity.Property(e => e.PurchaseOrderMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseOrderMasterId");
            entity.Property(e => e.PurchaseRequisitionMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseRequisitionMasterId");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VendorInvoiceDate)
                .HasColumnType("datetime")
                .HasColumnName("vendorInvoiceDate");
            entity.Property(e => e.VendorInvoiceNo)
                .IsUnicode(false)
                .HasColumnName("vendorInvoiceNo");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPurchaseOrderDetail>(entity =>
        {
            entity.HasKey(e => e.PurchaseOrderDetailsId).HasName("PK__tbl_Purc__BDE1867C70547F4A");

            entity.ToTable("tbl_PurchaseOrderDetails");

            entity.Property(e => e.PurchaseOrderDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseOrderDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ProductId)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("productId");
            entity.Property(e => e.ProductName).IsUnicode(false);
            entity.Property(e => e.PurchaseOrderMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseOrderMasterId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblPurchaseOrderMaster>(entity =>
        {
            entity.HasKey(e => e.PurchaseOrderMasterId).HasName("PK__tbl_Purc__DAD68F806C83EE66");

            entity.ToTable("tbl_PurchaseOrderMaster");

            entity.Property(e => e.PurchaseOrderMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseOrderMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.State)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPurchaseRequisitionDetail>(entity =>
        {
            entity.HasKey(e => e.PurchaseRequisitionDetailsId).HasName("PK__tbl_PurcReq__BDE1867C70547F4A");

            entity.ToTable("tbl_PurchaseRequisitionDetails");

            entity.Property(e => e.PurchaseRequisitionDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseRequisitionDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ProductId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.ProductName).IsUnicode(false);
            entity.Property(e => e.PurchaseRequisitionMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseRequisitionMasterId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.Unit)
                .IsUnicode(false)
                .HasColumnName("unit");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblPurchaseRequisitionMaster>(entity =>
        {
            entity.HasKey(e => e.PurchaseRequisitionMasterId).HasName("PK__tbl_PurcReq__DAD68F806C83EE66");

            entity.ToTable("tbl_PurchaseRequisitionMaster");

            entity.Property(e => e.PurchaseRequisitionMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseRequisitionMasterId");
            entity.Property(e => e.CostCenterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("costCenterId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PocategoryId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("POCategoryId");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.State)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPurchaseReturnBilltax>(entity =>
        {
            entity.HasKey(e => e.PurchaseReturnMasterId).HasName("PK__tbl_Purc__88C11EFA0DDAC090");

            entity.ToTable("tbl_PurchaseReturnBilltax");

            entity.Property(e => e.PurchaseReturnMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseReturnMasterId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.PurchaseReturnBillTaxId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseReturnBillTaxId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
        });

        modelBuilder.Entity<TblPurchaseReturnDetail>(entity =>
        {
            entity.HasKey(e => e.PurchaseReturnDetailsId).HasName("PK__tbl_Purc__BD84172168B35D82");

            entity.ToTable("tbl_PurchaseReturnDetails");

            entity.Property(e => e.PurchaseReturnDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseReturnDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CostRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("costRate");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.DiscountAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discountAmount");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.IsDiscountPercentage).HasColumnName("isDiscountPercentage");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("netAmount");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.PurchaseDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseDetailsId");
            entity.Property(e => e.PurchaseReturnMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseReturnMasterId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.RateExcTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateExcTax");
            entity.Property(e => e.RateIncTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateIncTax");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblPurchaseReturnMaster>(entity =>
        {
            entity.HasKey(e => e.PurchaseReturnMasterId).HasName("PK__tbl_Purc__B4D7A61F64E2CC9E");

            entity.ToTable("tbl_PurchaseReturnMaster");

            entity.Property(e => e.PurchaseReturnMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseReturnMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CreditPeriod)
                .IsUnicode(false)
                .HasColumnName("creditPeriod");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PaymentAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("paymentAmount");
            entity.Property(e => e.PaymentTermId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentTermId");
            entity.Property(e => e.PaymentType)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentType");
            entity.Property(e => e.PurchaseAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseAccount");
            entity.Property(e => e.PurchaseMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseMasterId");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VendorInvoiceDate)
                .HasColumnType("datetime")
                .HasColumnName("vendorInvoiceDate");
            entity.Property(e => e.VendorInvoiceNo)
                .IsUnicode(false)
                .HasColumnName("vendorInvoiceNo");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblQuickLaunchItem>(entity =>
        {
            entity.HasKey(e => e.QuickLaunchItemsId);

            entity.ToTable("tbl_QuickLaunchItems");

            entity.Property(e => e.QuickLaunchItemsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quickLaunchItemsId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ItemsName)
                .IsUnicode(false)
                .HasColumnName("itemsName");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<TblQuickLaunchItemsToCopy>(entity =>
        {
            entity.HasKey(e => e.QuickLaunchItemsId);

            entity.ToTable("tbl_QuickLaunchItemsToCopy");

            entity.Property(e => e.QuickLaunchItemsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quickLaunchItemsId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ItemsName)
                .IsUnicode(false)
                .HasColumnName("itemsName");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<TblRack>(entity =>
        {
            entity.HasKey(e => e.RackId).HasName("PK__tbl_Rack__B34912495555A4F4");

            entity.ToTable("tbl_Rack");

            entity.Property(e => e.RackId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.RackName)
                .IsUnicode(false)
                .HasColumnName("rackName");
        });

        modelBuilder.Entity<TblReceiptDetail>(entity =>
        {
            entity.HasKey(e => e.ReceiptDetailsId).HasName("PK__tbl_Rece__C0FF33FB6EA14102");

            entity.ToTable("tbl_ReceiptDetails");

            entity.Property(e => e.ReceiptDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("receiptDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ReceiptMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("receiptMasterId");
        });

        modelBuilder.Entity<TblReceiptMaster>(entity =>
        {
            entity.HasKey(e => e.ReceiptMasterId).HasName("PK__tbl_Rece__B974C2984925A390");

            entity.ToTable("tbl_ReceiptMaster");

            entity.Property(e => e.ReceiptMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("receiptMasterId");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerBankId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerBankId");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PaymentMethod)
                .IsUnicode(false)
                .HasColumnName("paymentMethod");
            entity.Property(e => e.ReferenceDate)
                .HasColumnType("datetime")
                .HasColumnName("referenceDate");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblRejectionInDetail>(entity =>
        {
            entity.HasKey(e => e.RejectionInDetailsId).HasName("PK__tbl_Reje__1B0C62F44A2ED662");

            entity.ToTable("tbl_RejectionInDetails");

            entity.Property(e => e.RejectionInDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rejectionInDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CostRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("costRate");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DeliveryNoteDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deliveryNoteDetailsId");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.DiscountAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discountAmount");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.IsDiscountPercentage).HasColumnName("isDiscountPercentage");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("netAmount");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.RateExcTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateExcTax");
            entity.Property(e => e.RateIncTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateIncTax");
            entity.Property(e => e.RejectionInMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rejectionInMasterId");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblRejectionInMaster>(entity =>
        {
            entity.HasKey(e => e.RejectionInMasterId).HasName("PK__tbl_Reje__9C0B04FD465E457E");

            entity.ToTable("tbl_RejectionInMaster");

            entity.Property(e => e.RejectionInMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rejectionInMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CreditPeriod)
                .IsUnicode(false)
                .HasColumnName("creditPeriod");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DeliveryNoteMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deliveryNoteMasterId");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PaymentAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("paymentAmount");
            entity.Property(e => e.PaymentTermId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentTermId");
            entity.Property(e => e.PaymentType)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentType");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.SalesAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesAccount");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblRejectionOutDetail>(entity =>
        {
            entity.HasKey(e => e.RejectionOutDetailsId).HasName("PK__tbl_RejectionOut__BD84172168B35D82");

            entity.ToTable("tbl_RejectionOutDetails");

            entity.Property(e => e.RejectionOutDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rejectionOutDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CostRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("costRate");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.DiscountAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discountAmount");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.IsDiscountPercentage).HasColumnName("isDiscountPercentage");
            entity.Property(e => e.MaterialReceiptDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("materialReceiptDetailsId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("netAmount");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.RateExcTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateExcTax");
            entity.Property(e => e.RateIncTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateIncTax");
            entity.Property(e => e.RejectionOutMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rejectionOutMasterId");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblRejectionOutMaster>(entity =>
        {
            entity.HasKey(e => e.RejectionOutMasterId).HasName("PK__tbl_RejectionOut__B4D7A61F64E2CC9E");

            entity.ToTable("tbl_RejectionOutMaster");

            entity.Property(e => e.RejectionOutMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rejectionOutMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CreditPeriod)
                .IsUnicode(false)
                .HasColumnName("creditPeriod");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.MaterialReceiptMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("materialReceiptMasterId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PaymentAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("paymentAmount");
            entity.Property(e => e.PaymentTermId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentTermId");
            entity.Property(e => e.PaymentType)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentType");
            entity.Property(e => e.PurchaseAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseAccount");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VendorInvoiceDate)
                .HasColumnType("datetime")
                .HasColumnName("vendorInvoiceDate");
            entity.Property(e => e.VendorInvoiceNo)
                .IsUnicode(false)
                .HasColumnName("vendorInvoiceNo");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblReminder>(entity =>
        {
            entity.HasKey(e => e.ReminderId);

            entity.ToTable("tbl_Reminder");

            entity.Property(e => e.ReminderId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("reminderId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("fromDate");
            entity.Property(e => e.RemindAbout)
                .IsUnicode(false)
                .HasColumnName("remindAbout");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("toDate");
        });

        modelBuilder.Entity<TblRole>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("tbl_Role");

            entity.Property(e => e.RoleId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("roleId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Role)
                .IsUnicode(false)
                .HasColumnName("role");
        });

        modelBuilder.Entity<TblRoute>(entity =>
        {
            entity.HasKey(e => e.RouteId);

            entity.ToTable("tbl_Route");

            entity.Property(e => e.RouteId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("routeId");
            entity.Property(e => e.AreaId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("areaId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.RouteName)
                .IsUnicode(false)
                .HasColumnName("routeName");
        });

        modelBuilder.Entity<TblSalaryPackage>(entity =>
        {
            entity.HasKey(e => e.SalaryPackageId).HasName("PK__tbl_Sala__B78BCF693493CFA7");

            entity.ToTable("tbl_SalaryPackage");

            entity.Property(e => e.SalaryPackageId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salaryPackageId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SalaryPackageName)
                .IsUnicode(false)
                .HasColumnName("salaryPackageName");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
        });

        modelBuilder.Entity<TblSalaryPackageDetail>(entity =>
        {
            entity.HasKey(e => e.SalaryPackageDetailsId).HasName("PK__tbl_Sala__993415083864608B");

            entity.ToTable("tbl_SalaryPackageDetails");

            entity.Property(e => e.SalaryPackageDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salaryPackageDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BonusDeductionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bonusDeductionId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SalaryPackageId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salaryPackageId");
        });

        modelBuilder.Entity<TblSalaryVoucherDetail>(entity =>
        {
            entity.HasKey(e => e.SalaryVoucherDetailsId).HasName("PK__tbl_Sala__054D02EE47A6A41B");

            entity.ToTable("tbl_SalaryVoucherDetails");

            entity.Property(e => e.SalaryVoucherDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salaryVoucherDetailsId");
            entity.Property(e => e.Advance)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("advance");
            entity.Property(e => e.Bonus)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("bonus");
            entity.Property(e => e.Deduction)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("deduction");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Lop)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("lop");
            entity.Property(e => e.Salary)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("salary");
            entity.Property(e => e.SalaryVoucherMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salaryVoucherMasterId");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<TblSalaryVoucherMaster>(entity =>
        {
            entity.HasKey(e => e.SalaryVoucherMasterId).HasName("PK__tbl_Sala__B363606243D61337");

            entity.ToTable("tbl_SalaryVoucherMaster");

            entity.Property(e => e.SalaryVoucherMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salaryVoucherMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Month)
                .HasColumnType("datetime")
                .HasColumnName("month");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblSalesBillPayment>(entity =>
        {
            entity.HasKey(e => e.SalesBillPaymentId).HasName("PK__tbl_Sale__Payment__3E4B1B27334B710A");

            entity.ToTable("tbl_SalesBillPayment");

            entity.Property(e => e.SalesBillPaymentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesBillPaymentId");
            entity.Property(e => e.BankLedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bankLedgerId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.PayedAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("payedAmount");
            entity.Property(e => e.PaymentAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("paymentAmount");
            entity.Property(e => e.PaymentName)
                .IsUnicode(false)
                .HasColumnName("paymentName");
            entity.Property(e => e.PaymentType)
                .IsUnicode(false)
                .HasColumnName("paymentType");
            entity.Property(e => e.SalesMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesMasterId");
        });

        modelBuilder.Entity<TblSalesBillTax>(entity =>
        {
            entity.HasKey(e => e.SalesBillTaxId).HasName("PK__tbl_Sale__3E4B1B27334B710A");

            entity.ToTable("tbl_SalesBillTax");

            entity.Property(e => e.SalesBillTaxId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesBillTaxId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.SalesMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesMasterId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
        });

        modelBuilder.Entity<TblSalesDetail>(entity =>
        {
            entity.HasKey(e => e.SalesDetailsId).HasName("PK__tbl_Sale__541370DA371C01EE");

            entity.ToTable("tbl_SalesDetails");

            entity.HasIndex(e => e.SalesMasterId, "NCI_tbl_SalesDetails_productId");

            entity.Property(e => e.SalesDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CostRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("costRate");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DeliveryNoteDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deliveryNoteDetailsId");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.DiscountAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discountAmount");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.IsDiscountPercentage).HasColumnName("isDiscountPercentage");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("netAmount");
            entity.Property(e => e.OrderDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("orderDetailsId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.QuotationDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationDetailsId");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.RateExcTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateExcTax");
            entity.Property(e => e.RateIncTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateIncTax");
            entity.Property(e => e.SalesMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesMasterId");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblSalesMaster>(entity =>
        {
            entity.HasKey(e => e.SalesMasterId).HasName("PK__tbl_Sale__036BDC222F7AE026");

            entity.ToTable("tbl_SalesMaster");

            entity.Property(e => e.SalesMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.CounterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("counterId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");
            entity.Property(e => e.CustomerName)
                .IsUnicode(false)
                .HasColumnName("customerName");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DeliveryNoteMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deliveryNoteMasterId");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.OrderMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("orderMasterId");
            entity.Property(e => e.PaymentAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("paymentAmount");
            entity.Property(e => e.PaymentTermId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentTermId");
            entity.Property(e => e.PaymentType)
                .IsUnicode(false)
                .HasColumnName("paymentType");
            entity.Property(e => e.Pos).HasColumnName("POS");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.QuotationMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationMasterId");
            entity.Property(e => e.SalesAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesAccount");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.WorkPeriodId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("workPeriodId");
        });

        modelBuilder.Entity<TblSalesOrderDetail>(entity =>
        {
            entity.HasKey(e => e.SalesOrderDetailsId).HasName("PK__tbl_Sale__45789749597119F2");

            entity.ToTable("tbl_SalesOrderDetails");

            entity.Property(e => e.SalesOrderDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesOrderDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CostRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("costRate");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.DiscountAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discountAmount");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.IsDiscountPercentage).HasColumnName("isDiscountPercentage");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("netAmount");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.QuotationDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationDetailsId");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.RateExcTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateExcTax");
            entity.Property(e => e.RateIncTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateIncTax");
            entity.Property(e => e.SalesOrderMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesOrderMasterId");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblSalesOrderMaster>(entity =>
        {
            entity.HasKey(e => e.SalesOrderMasterId).HasName("PK__tbl_Sale__9D8A0C5455A0890E");

            entity.ToTable("tbl_SalesOrderMaster");

            entity.Property(e => e.SalesOrderMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesOrderMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.CounterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("counterId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");
            entity.Property(e => e.CustomerName)
                .IsUnicode(false)
                .HasColumnName("customerName");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PaymentAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("paymentAmount");
            entity.Property(e => e.PaymentTermId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentTermId");
            entity.Property(e => e.PaymentType)
                .IsUnicode(false)
                .HasColumnName("paymentType");
            entity.Property(e => e.Pos).HasColumnName("POS");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.QuotationMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationMasterId");
            entity.Property(e => e.SalesAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesAccount");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.WorkPeriodId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("workPeriodId");
        });

        modelBuilder.Entity<TblSalesQuotationDetail>(entity =>
        {
            entity.HasKey(e => e.QuotationDetailsId).HasName("PK__tbl_Sale__5875C12861123BBA");

            entity.ToTable("tbl_SalesQuotationDetails");

            entity.Property(e => e.QuotationDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CostRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("costRate");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.DiscountAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discountAmount");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.IsDiscountPercentage).HasColumnName("isDiscountPercentage");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("netAmount");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.QuotationMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationMasterId");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.RateExcTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateExcTax");
            entity.Property(e => e.RateIncTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateIncTax");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblSalesQuotationMaster>(entity =>
        {
            entity.HasKey(e => e.QuotationMasterId).HasName("PK__tbl_Sale__8D6FDEBD5D41AAD6");

            entity.ToTable("tbl_SalesQuotationMaster");

            entity.Property(e => e.QuotationMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.CounterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("counterId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");
            entity.Property(e => e.CustomerName)
                .IsUnicode(false)
                .HasColumnName("customerName");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PaymentAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("paymentAmount");
            entity.Property(e => e.PaymentTermId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentTermId");
            entity.Property(e => e.PaymentType)
                .IsUnicode(false)
                .HasColumnName("paymentType");
            entity.Property(e => e.Pos).HasColumnName("POS");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.SalesAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesAccount");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.WorkPeriodId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("workPeriodId");
        });

        modelBuilder.Entity<TblSalesReturnBillTax>(entity =>
        {
            entity.HasKey(e => e.SalesReturnBillTaxId).HasName("PK__tbl_Sale__5BD749863EBD23B6");

            entity.ToTable("tbl_SalesReturnBillTax");

            entity.Property(e => e.SalesReturnBillTaxId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesReturnBillTaxId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.SalesReturnMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesReturnMasterId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
        });

        modelBuilder.Entity<TblSalesReturnDetail>(entity =>
        {
            entity.HasKey(e => e.SalesReturnDetailsId).HasName("PK__tbl_Sale__0C252C0D428DB49A");

            entity.ToTable("tbl_SalesReturnDetails");

            entity.Property(e => e.SalesReturnDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesReturnDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CostRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("costRate");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.DiscountAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discountAmount");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.IsDiscountPercentage).HasColumnName("isDiscountPercentage");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("netAmount");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.RateExcTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateExcTax");
            entity.Property(e => e.RateIncTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rateIncTax");
            entity.Property(e => e.SalesDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesDetailsId");
            entity.Property(e => e.SalesReturnMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesReturnMasterId");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblSalesReturnMaster>(entity =>
        {
            entity.HasKey(e => e.SalesReturnMasterId).HasName("PK__tbl_Sale__DB499E433AEC92D2");

            entity.ToTable("tbl_SalesReturnMaster");

            entity.Property(e => e.SalesReturnMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesReturnMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CreditPeriod)
                .IsUnicode(false)
                .HasColumnName("creditPeriod");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PaymentAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("paymentAmount");
            entity.Property(e => e.PaymentTermId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentTermId");
            entity.Property(e => e.PaymentType)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentType");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.SalesAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesAccount");
            entity.Property(e => e.SalesMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesMasterId");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblSection>(entity =>
        {
            entity.HasKey(e => e.SectionId).HasName("PK__tbl_Sect__3F58FD52B4CFBECA");

            entity.ToTable("tbl_Section");

            entity.Property(e => e.SectionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("sectionId");
            entity.Property(e => e.DepartmentId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("departmentId");
            entity.Property(e => e.Extra1)
                .HasMaxLength(100)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .HasMaxLength(100)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .HasMaxLength(100)
                .HasColumnName("narration");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.SectionCode)
                .HasMaxLength(20)
                .HasColumnName("sectionCode");
            entity.Property(e => e.SectionName)
                .HasMaxLength(100)
                .HasColumnName("sectionName");
        });

        modelBuilder.Entity<TblService>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK__tbl_Serv__455070DF70099B30");

            entity.ToTable("tbl_Service");

            entity.Property(e => e.ServiceId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.ServiceCategoryId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceCategoryId");
            entity.Property(e => e.ServiceName)
                .IsUnicode(false)
                .HasColumnName("serviceName");
            entity.Property(e => e.ServiceTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceTypeId");
        });

        modelBuilder.Entity<TblServiceCategory>(entity =>
        {
            entity.HasKey(e => e.ServiceCategoryId).HasName("PK__tbl_Serv__77EC43563AA1AEB8");

            entity.ToTable("tbl_ServiceCategory");

            entity.Property(e => e.ServiceCategoryId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceCategoryId");
            entity.Property(e => e.CategoryName)
                .IsUnicode(false)
                .HasColumnName("categoryName");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblServiceDetail>(entity =>
        {
            entity.HasKey(e => e.ServiceDetailsId).HasName("PK__tbl_Serv__E8F292C47DE38492");

            entity.ToTable("tbl_ServiceDetails");

            entity.Property(e => e.ServiceDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Measure)
                .IsUnicode(false)
                .HasColumnName("measure");
            entity.Property(e => e.ServiceId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceId");
            entity.Property(e => e.ServiceMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceMasterId");
        });

        modelBuilder.Entity<TblServiceMaster>(entity =>
        {
            entity.HasKey(e => e.ServiceMasterId).HasName("PK__tbl_Serv__BF261C547A12F3AE");

            entity.ToTable("tbl_ServiceMaster");

            entity.Property(e => e.ServiceMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceMasterId");
            entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");
            entity.Property(e => e.Customer)
                .IsUnicode(false)
                .HasColumnName("customer");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.ServiceAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceAccount");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblSetting>(entity =>
        {
            entity.HasKey(e => e.SettingsId);

            entity.ToTable("tbl_Settings");

            entity.Property(e => e.SettingsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("settingsId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.SettingsName)
                .IsUnicode(false)
                .HasColumnName("settingsName");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<TblSettingsToCopy>(entity =>
        {
            entity.HasKey(e => e.SettingsId);

            entity.ToTable("tbl_SettingsToCopy");

            entity.Property(e => e.SettingsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("settingsId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.SettingsName)
                .IsUnicode(false)
                .HasColumnName("settingsName");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<TblSize>(entity =>
        {
            entity.HasKey(e => e.SizeId).HasName("PK__tbl_Size__55B1E55749E3F248");

            entity.ToTable("tbl_Size");

            entity.Property(e => e.SizeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("sizeId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Size)
                .IsUnicode(false)
                .HasColumnName("size");
        });

        modelBuilder.Entity<TblSmartList>(entity =>
        {
            entity.HasKey(e => e.ViewId);

            entity.ToTable("tbl_SmartList");

            entity.Property(e => e.ViewId).HasColumnName("ViewID");
            entity.Property(e => e.ReportFile).HasColumnType("image");
            entity.Property(e => e.StrSelect).HasColumnName("strSELECT");
        });

        modelBuilder.Entity<TblSmtpsetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_SMTPSetting");

            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.EnableSsl).HasColumnName("enableSSL");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Host)
                .HasMaxLength(50)
                .HasColumnName("host");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Port).HasColumnName("port");
            entity.Property(e => e.Security)
                .HasMaxLength(50)
                .HasColumnName("security");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<TblSocialSecurityType>(entity =>
        {
            entity.HasKey(e => e.SocialSecurityId).HasName("PK__tbl_Soci__54810412187BEF2F");

            entity.ToTable("tbl_SocialSecurityTypes");

            entity.Property(e => e.SocialSecurityId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("socialSecurityId");
            entity.Property(e => e.CompanyDeductionRate).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EmployeeDeductionRate).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Extra1).HasMaxLength(100);
            entity.Property(e => e.Extra2).HasMaxLength(100);
            entity.Property(e => e.ExtraDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.NameAr)
                .IsUnicode(false)
                .HasColumnName("NameAR");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<TblStandardRate>(entity =>
        {
            entity.HasKey(e => e.StandardRateId).HasName("PK__tbl_Stan__F75A1E8460C757A0");

            entity.ToTable("tbl_StandardRate");

            entity.Property(e => e.StandardRateId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("standardRateId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("fromDate");
            entity.Property(e => e.FromTime)
                .HasColumnType("datetime")
                .HasColumnName("fromTime");
            entity.Property(e => e.IsIncrease).HasColumnName("isIncrease");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Percentage)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("percentage");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("toDate");
            entity.Property(e => e.ToTime)
                .HasColumnType("datetime")
                .HasColumnName("toTime");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblStockInDetail>(entity =>
        {
            entity.HasKey(e => e.StockInDetailsId).HasName("PK__tbl_StockIn__67AF05292BAA4F42");

            entity.ToTable("tbl_StockInDetails");

            entity.Property(e => e.StockInDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stockInDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CostRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("costRate");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.StockInMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stockInMasterId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblStockInMaster>(entity =>
        {
            entity.HasKey(e => e.StockInMasterId).HasName("PK__tbl_StockIn__9D353EFC20389C96");

            entity.ToTable("tbl_StockInMaster");

            entity.Property(e => e.StockInMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stockInMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblStockJournalDetail>(entity =>
        {
            entity.HasKey(e => e.StockJournalDetailsId).HasName("PK__tbl_Stoc__3224B9A70737E4A2");

            entity.ToTable("tbl_StockJournalDetails");

            entity.Property(e => e.StockJournalDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stockJournalDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.ConsumptionOrProduction)
                .IsUnicode(false)
                .HasColumnName("consumptionOrProduction");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.Slno).HasColumnName("slno");
            entity.Property(e => e.StockJournalMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stockJournalMasterId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblStockJournalMaster>(entity =>
        {
            entity.HasKey(e => e.StockJournalMasterId).HasName("PK__tbl_Stoc__8B1D7000036753BE");

            entity.ToTable("tbl_StockJournalMaster");

            entity.Property(e => e.StockJournalMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stockJournalMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblStockPosting>(entity =>
        {
            entity.HasKey(e => e.StockPostingId).HasName("PK__tbl_Stoc__CAEC17F7158603F9");

            entity.ToTable("tbl_StockPosting");

            entity.Property(e => e.StockPostingId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stockPostingId");
            entity.Property(e => e.AgainstInvoiceNo)
                .IsUnicode(false)
                .HasColumnName("againstInvoiceNo");
            entity.Property(e => e.AgainstVoucherNo)
                .IsUnicode(false)
                .HasColumnName("againstVoucherNo");
            entity.Property(e => e.AgainstVoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstVoucherTypeId");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("detailsId");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.InwardAllocatedQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("inwardAllocatedQty");
            entity.Property(e => e.InwardQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("inwardQty");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.OutwardAllocatedQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("outwardAllocatedQty");
            entity.Property(e => e.OutwardQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("outwardQty");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblStockPosting1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_StockPosting1");

            entity.Property(e => e.AgainstInvoiceNo)
                .IsUnicode(false)
                .HasColumnName("againstInvoiceNo");
            entity.Property(e => e.AgainstVoucherNo)
                .IsUnicode(false)
                .HasColumnName("againstVoucherNo");
            entity.Property(e => e.AgainstVoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstVoucherTypeId");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("detailsId");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.InwardAllocatedQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("inwardAllocatedQty");
            entity.Property(e => e.InwardQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("inwardQty");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.OutwardAllocatedQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("outwardAllocatedQty");
            entity.Property(e => e.OutwardQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("outwardQty");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.StockPostingId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stockPostingId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblStockPostingBak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_StockPosting_BAK");

            entity.Property(e => e.AgainstInvoiceNo)
                .IsUnicode(false)
                .HasColumnName("againstInvoiceNo");
            entity.Property(e => e.AgainstVoucherNo)
                .IsUnicode(false)
                .HasColumnName("againstVoucherNo");
            entity.Property(e => e.AgainstVoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstVoucherTypeId");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("detailsId");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.InwardAllocatedQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("inwardAllocatedQty");
            entity.Property(e => e.InwardQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("inwardQty");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.OutwardAllocatedQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("outwardAllocatedQty");
            entity.Property(e => e.OutwardQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("outwardQty");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.StockPostingId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stockPostingId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblStockStaging>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_StockStaging");

            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
        });

        modelBuilder.Entity<TblStockTransferDetail>(entity =>
        {
            entity.HasKey(e => e.StockTransferDetailsId).HasName("PK__tbl_StockTransfer__67AF05292BAA4F42");

            entity.ToTable("tbl_StockTransferDetails");

            entity.Property(e => e.StockTransferDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stockTransferDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.CostRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("costRate");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FromGodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("fromGodownId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.StockTransferMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stockTransferMasterId");
            entity.Property(e => e.ToGodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("toGodownId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblStockTransferMaster>(entity =>
        {
            entity.HasKey(e => e.StockTransferMasterId).HasName("PK__tbl_StockTransfer__9D353EFC20389C96");

            entity.ToTable("tbl_StockTransferMaster");

            entity.Property(e => e.StockTransferMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stockTransferMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.FromGodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("fromGodownId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.ToGodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("toGodownId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblStocktakingDetail>(entity =>
        {
            entity.HasKey(e => e.StocktakingDetailsId).HasName("PK__tbl_Stocktaking__67AF05292BAA4F42");

            entity.ToTable("tbl_StocktakingDetails");

            entity.Property(e => e.StocktakingDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stocktakingDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.BlanaceQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("blanaceQty");
            entity.Property(e => e.CostRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("costRate");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DifferanceQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("differanceQty");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FromGodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("fromGodownId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.StocktakingMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stocktakingMasterId");
            entity.Property(e => e.ToGodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("toGodownId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblStocktakingMaster>(entity =>
        {
            entity.HasKey(e => e.StocktakingMasterId).HasName("PK__tbl_Stocktaking__9D353EFC20389C96");

            entity.ToTable("tbl_StocktakingMaster");

            entity.Property(e => e.StocktakingMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stocktakingMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.FromGodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("fromGodownId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblSuffixPrefix>(entity =>
        {
            entity.HasKey(e => e.SuffixprefixId).HasName("PK__tbl_Suff__5876721373DA2C14");

            entity.ToTable("tbl_SuffixPrefix");

            entity.Property(e => e.SuffixprefixId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixprefixId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("fromDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PrefillWithZero).HasColumnName("prefillWithZero");
            entity.Property(e => e.Prefix)
                .IsUnicode(false)
                .HasColumnName("prefix");
            entity.Property(e => e.StartIndex)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("startIndex");
            entity.Property(e => e.Suffix)
                .IsUnicode(false)
                .HasColumnName("suffix");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("toDate");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.WidthOfNumericalPart).HasColumnName("widthOfNumericalPart");
        });

        modelBuilder.Entity<TblSystemLog>(entity =>
        {
            entity.ToTable("tbl_SystemLog");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Form)
                .IsUnicode(false)
                .HasColumnName("form");
            entity.Property(e => e.Name)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Source)
                .IsUnicode(false)
                .HasColumnName("source");
            entity.Property(e => e.Type)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("userId");
        });

        modelBuilder.Entity<TblTax>(entity =>
        {
            entity.HasKey(e => e.TaxId).HasName("PK__tbl_Tax__24D2883933008CF0");

            entity.ToTable("tbl_Tax");

            entity.Property(e => e.TaxId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.ApplicableOn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("applicableOn");
            entity.Property(e => e.CalculatingMode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("calculatingMode");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.TaxName)
                .IsUnicode(false)
                .HasColumnName("taxName");
            entity.Property(e => e.TaxType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("taxType");
        });

        modelBuilder.Entity<TblTaxDetail>(entity =>
        {
            entity.HasKey(e => e.TaxdetailsId).HasName("PK__tbl_TaxD__B3B4F7A536D11DD4");

            entity.ToTable("tbl_TaxDetails");

            entity.Property(e => e.TaxdetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxdetailsId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.SelectedtaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("selectedtaxId");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
        });

        modelBuilder.Entity<TblTaxIntegrationDetail>(entity =>
        {
            entity.HasKey(e => e.TaxIntegrationDetailsId).HasName("PK__tbl_TaxIntegrationDetails__036BDC222F7AE026");

            entity.ToTable("tbl_TaxIntegrationDetails");

            entity.Property(e => e.TaxIntegrationDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxIntegrationDetailsId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CurrencyCode)
                .IsUnicode(false)
                .HasColumnName("currencyCode");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Index)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("index");
            entity.Property(e => e.LineDiscount)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("lineDiscount");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.NetPrice)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("netPrice");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.ProductName)
                .IsUnicode(false)
                .HasColumnName("productName");
            entity.Property(e => e.Quantity)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("quantity");
            entity.Property(e => e.Tax)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("tax");
            entity.Property(e => e.TaxCategory)
                .IsUnicode(false)
                .HasColumnName("taxCategory");
            entity.Property(e => e.TaxIntegrationMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxIntegrationMasterId");
        });

        modelBuilder.Entity<TblTaxIntegrationMaster>(entity =>
        {
            entity.HasKey(e => e.TaxIntegrationMasterId).HasName("PK__tbl_TaxIntegrationMaster__036BDC222F7AE026");

            entity.ToTable("tbl_TaxIntegrationMaster");

            entity.Property(e => e.TaxIntegrationMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxIntegrationMasterId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CurrencyCode)
                .IsUnicode(false)
                .HasColumnName("currencyCode");
            entity.Property(e => e.CustomerCityCode)
                .IsUnicode(false)
                .HasColumnName("customer_CityCode");
            entity.Property(e => e.CustomerCountryCode)
                .IsUnicode(false)
                .HasColumnName("customer_CountryCode");
            entity.Property(e => e.CustomerCustomerName)
                .IsUnicode(false)
                .HasColumnName("customer_CustomerName");
            entity.Property(e => e.CustomerIdentityNumber)
                .IsUnicode(false)
                .HasColumnName("customer_IdentityNumber");
            entity.Property(e => e.CustomerIdentityType)
                .IsUnicode(false)
                .HasColumnName("customer_IdentityType");
            entity.Property(e => e.CustomerTelephone)
                .IsUnicode(false)
                .HasColumnName("customer_Telephone");
            entity.Property(e => e.CustomerZipCode)
                .IsUnicode(false)
                .HasColumnName("customer_ZipCode");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InvoiceNumber)
                .IsUnicode(false)
                .HasColumnName("invoiceNumber");
            entity.Property(e => e.InvoiceType)
                .IsUnicode(false)
                .HasColumnName("invoiceType");
            entity.Property(e => e.InvoiceTypeCode)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("invoiceTypeCode");
            entity.Property(e => e.IssueDate)
                .HasColumnType("datetime")
                .HasColumnName("issueDate");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Notes)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Order)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("order");
            entity.Property(e => e.PaymentMethod)
                .IsUnicode(false)
                .HasColumnName("paymentMethod");
            entity.Property(e => e.ReferenceId)
                .IsUnicode(false)
                .HasColumnName("referenceId");
            entity.Property(e => e.ReferenceUuid)
                .IsUnicode(false)
                .HasColumnName("referenceUUID");
            entity.Property(e => e.SupplierActivityNumber)
                .IsUnicode(false)
                .HasColumnName("supplier_ActivityNumber");
            entity.Property(e => e.SupplierCountryCode)
                .IsUnicode(false)
                .HasColumnName("supplier_CountryCode");
            entity.Property(e => e.SupplierSellerName)
                .IsUnicode(false)
                .HasColumnName("supplier_SellerName");
            entity.Property(e => e.SupplierSellerTin)
                .IsUnicode(false)
                .HasColumnName("supplier_SellerTIN");
            entity.Property(e => e.TaxPayerType)
                .IsUnicode(false)
                .HasColumnName("taxPayerType");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblTaxIntegrationProfile>(entity =>
        {
            entity.HasKey(e => e.TaxIntegrationProfileId).HasName("PK__tbl_TaxIntegrationProfile__036BDC222F7AE026");

            entity.ToTable("tbl_TaxIntegrationProfile");

            entity.Property(e => e.TaxIntegrationProfileId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxIntegrationProfileId");
            entity.Property(e => e.ActivityNumber)
                .IsUnicode(false)
                .HasColumnName("activityNumber");
            entity.Property(e => e.Apiurl)
                .IsUnicode(false)
                .HasColumnName("APIUrl");
            entity.Property(e => e.ClientId)
                .IsUnicode(false)
                .HasColumnName("clientId");
            entity.Property(e => e.ClientSecret)
                .IsUnicode(false)
                .HasColumnName("clientSecret");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Password)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Tin)
                .IsUnicode(false)
                .HasColumnName("TIN");
            entity.Property(e => e.UserName)
                .IsUnicode(false)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<TblTaxIntegrationResult>(entity =>
        {
            entity.HasKey(e => e.TaxIntegrationResultId).HasName("PK__tbl_TaxIntegrationResult__036BDC222F7AE026");

            entity.ToTable("tbl_TaxIntegrationResult");

            entity.Property(e => e.TaxIntegrationResultId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxIntegrationResultId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.InvoiceErrors)
                .IsUnicode(false)
                .HasColumnName("invoiceErrors");
            entity.Property(e => e.InvoiceNumber)
                .IsUnicode(false)
                .HasColumnName("invoiceNumber");
            entity.Property(e => e.InvoiceQr)
                .IsUnicode(false)
                .HasColumnName("invoiceQR");
            entity.Property(e => e.InvoiceQrbase64String)
                .IsUnicode(false)
                .HasColumnName("invoiceQRBase64String");
            entity.Property(e => e.InvoiceUuid)
                .IsUnicode(false)
                .HasColumnName("invoiceUUID");
            entity.Property(e => e.InvoiceWarnings)
                .IsUnicode(false)
                .HasColumnName("invoiceWarnings");
            entity.Property(e => e.InvoiceXml)
                .IsUnicode(false)
                .HasColumnName("invoiceXML");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.SingedInvoice)
                .IsUnicode(false)
                .HasColumnName("singedInvoice");
            entity.Property(e => e.SingedInvoiceXml)
                .IsUnicode(false)
                .HasColumnName("singedInvoiceXML");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TaxIntegrationMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxIntegrationMasterId");
        });

        modelBuilder.Entity<TblUnit>(entity =>
        {
            entity.HasKey(e => e.UnitId).HasName("PK__tbl_Unit__55D792354242D080");

            entity.ToTable("tbl_Unit");

            entity.Property(e => e.UnitId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FormalName)
                .IsUnicode(false)
                .HasColumnName("formalName");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.NoOfDecimalplaces).HasColumnName("noOfDecimalplaces");
            entity.Property(e => e.UnitName)
                .IsUnicode(false)
                .HasColumnName("unitName");
        });

        modelBuilder.Entity<TblUnitConvertion>(entity =>
        {
            entity.HasKey(e => e.UnitconversionId).HasName("PK__tbl_Unit__07076F271C1D2798");

            entity.ToTable("tbl_UnitConvertion");

            entity.Property(e => e.UnitconversionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitconversionId");
            entity.Property(e => e.ConversionRate)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("conversionRate");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.MainUnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("mainUnitId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Quantities)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("quantities");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("tbl_User");

            entity.Property(e => e.UserId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.BankId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bankId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Extra1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.ManagerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("managerId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.RoleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("roleId");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<TblVoucherType>(entity =>
        {
            entity.HasKey(e => e.VoucherTypeId).HasName("PK__tbl_Vouc__96246DEA68687968");

            entity.ToTable("tbl_VoucherType");

            entity.Property(e => e.VoucherTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.Declaration)
                .IsUnicode(false)
                .HasColumnName("declaration");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Heading1)
                .IsUnicode(false)
                .HasColumnName("heading1");
            entity.Property(e => e.Heading2)
                .IsUnicode(false)
                .HasColumnName("heading2");
            entity.Property(e => e.Heading3)
                .IsUnicode(false)
                .HasColumnName("heading3");
            entity.Property(e => e.Heading4)
                .IsUnicode(false)
                .HasColumnName("heading4");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.IsPostingLedger).HasColumnName("isPostingLedger");
            entity.Property(e => e.IsPostingStock).HasColumnName("isPostingStock");
            entity.Property(e => e.IsTaxApplicable).HasColumnName("isTaxApplicable");
            entity.Property(e => e.MasterId).HasColumnName("masterId");
            entity.Property(e => e.MethodOfVoucherNumbering)
                .IsUnicode(false)
                .HasColumnName("methodOfVoucherNumbering");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.TypeOfVoucher)
                .IsUnicode(false)
                .HasColumnName("typeOfVoucher");
            entity.Property(e => e.VoucherModule)
                .IsUnicode(false)
                .HasColumnName("voucherModule");
            entity.Property(e => e.VoucherTypeName)
                .IsUnicode(false)
                .HasColumnName("voucherTypeName");
            entity.Property(e => e.VoucherTypeNameAr)
                .IsUnicode(false)
                .HasColumnName("voucherTypeNameAr");
        });

        modelBuilder.Entity<TblVoucherTypeTax>(entity =>
        {
            entity.HasKey(e => e.VoucherTypeTaxId).HasName("PK__tbl_Vouc__BD57380E6C390A4C");

            entity.ToTable("tbl_VoucherTypeTax");

            entity.Property(e => e.VoucherTypeTaxId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeTaxId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblVoucherTypeToCopy>(entity =>
        {
            entity.HasKey(e => e.VoucherTypeId);

            entity.ToTable("tbl_VoucherTypeToCopy");

            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.Declaration)
                .IsUnicode(false)
                .HasColumnName("declaration");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Heading1)
                .IsUnicode(false)
                .HasColumnName("heading1");
            entity.Property(e => e.Heading2)
                .IsUnicode(false)
                .HasColumnName("heading2");
            entity.Property(e => e.Heading3)
                .IsUnicode(false)
                .HasColumnName("heading3");
            entity.Property(e => e.Heading4)
                .IsUnicode(false)
                .HasColumnName("heading4");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.IsTaxApplicable).HasColumnName("isTaxApplicable");
            entity.Property(e => e.MasterId).HasColumnName("masterId");
            entity.Property(e => e.MethodOfVoucherNumbering)
                .IsUnicode(false)
                .HasColumnName("methodOfVoucherNumbering");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.TypeOfVoucher)
                .IsUnicode(false)
                .HasColumnName("typeOfVoucher");
            entity.Property(e => e.VoucherTypeName)
                .IsUnicode(false)
                .HasColumnName("voucherTypeName");
        });

        modelBuilder.Entity<TblWorkPeriod>(entity =>
        {
            entity.HasKey(e => e.WorkPeriodId).HasName("PK__tbl_WorkPeriod__5876721373DA2C14");

            entity.ToTable("tbl_WorkPeriod");

            entity.Property(e => e.WorkPeriodId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("workPeriodId");
            entity.Property(e => e.CashDeclaration)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("cashDeclaration");
            entity.Property(e => e.Closed).HasColumnName("closed");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("fromDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Register)
                .IsUnicode(false)
                .HasColumnName("register");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("toDate");
            entity.Property(e => e.UserDefined1)
                .IsUnicode(false)
                .HasColumnName("userDefined1");
            entity.Property(e => e.UserDefined2).HasColumnName("userDefined2");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
        });

        modelBuilder.Entity<TblWorkPeriodDetail>(entity =>
        {
            entity.HasKey(e => e.WorkPeriodDetailsId).HasName("PK__tbl_WorkPeriodDetails__5876721373DA2C14");

            entity.ToTable("tbl_WorkPeriodDetails");

            entity.Property(e => e.WorkPeriodDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("workPeriodDetailsId");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.WorkPeriodId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("workPeriodId");
        });

        modelBuilder.Entity<TblWorkPeriodMaster>(entity =>
        {
            entity.HasKey(e => e.WorkPeriodId).HasName("PK__tbl_WorkPeriodMaster__5876721373DA2C14");

            entity.ToTable("tbl_WorkPeriodMaster");

            entity.Property(e => e.WorkPeriodId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("workPeriodId");
            entity.Property(e => e.CashClosure)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("cashClosure");
            entity.Property(e => e.CashDeclaration)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("cashDeclaration");
            entity.Property(e => e.Closed).HasColumnName("closed");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("fromDate");
            entity.Property(e => e.ModifiedBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modifiedBy");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Register)
                .IsUnicode(false)
                .HasColumnName("register");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("toDate");
            entity.Property(e => e.UserDefined1)
                .IsUnicode(false)
                .HasColumnName("userDefined1");
            entity.Property(e => e.UserDefined2)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("userDefined2");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
        });

        modelBuilder.Entity<TblWorkflow>(entity =>
        {
            entity.ToTable("tbl_Workflows");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.ApprovalType)
                .IsUnicode(false)
                .HasColumnName("approvalType");
            entity.Property(e => e.DelegateToUserId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("delegateToUserId");
            entity.Property(e => e.EmailId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("emailId");
            entity.Property(e => e.EmailStatus)
                .IsUnicode(false)
                .HasColumnName("emailStatus");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsCurrent).HasColumnName("isCurrent");
            entity.Property(e => e.UserId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("voucherId");
            entity.Property(e => e.VoucherType)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("voucherType");
            entity.Property(e => e.WorkflowComment)
                .IsUnicode(false)
                .HasColumnName("workflowComment");
            entity.Property(e => e.WorkflowId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("workflowId");
            entity.Property(e => e.WorkflowSequence)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("workflowSequence");
            entity.Property(e => e.WorkflowStatus)
                .IsUnicode(false)
                .HasColumnName("workflowStatus");
        });

        modelBuilder.Entity<TblWorkflowSetup>(entity =>
        {
            entity.HasKey(e => e.WorkflowId);

            entity.ToTable("tbl_WorkflowSetup");

            entity.Property(e => e.WorkflowId)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("workflowId");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.VoucherType)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("voucherType");
            entity.Property(e => e.WorkflowName)
                .IsUnicode(false)
                .HasColumnName("workflowName");
        });

        modelBuilder.Entity<TblWorkflowStep>(entity =>
        {
            entity.HasKey(e => e.WorkflowStepId);

            entity.ToTable("tbl_WorkflowStep");

            entity.Property(e => e.WorkflowStepId)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("workflowStepId");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ParentStepId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("parentStepId");
            entity.Property(e => e.StepName)
                .IsUnicode(false)
                .HasColumnName("stepName");
            entity.Property(e => e.StepType)
                .IsUnicode(false)
                .HasColumnName("stepType");
            entity.Property(e => e.WorkflowId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("workflowId");
        });

        modelBuilder.Entity<TblWorkflowStepAssignment>(entity =>
        {
            entity.HasKey(e => e.StepAssignmentId);

            entity.ToTable("tbl_WorkflowStepAssignment");

            entity.Property(e => e.StepAssignmentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("stepAssignmentId");
            entity.Property(e => e.ActionType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("actionType");
            entity.Property(e => e.AssignmentId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("assignmentId");
            entity.Property(e => e.AssignmentOrder)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("assignmentOrder");
            entity.Property(e => e.AssignmentType)
                .IsUnicode(false)
                .HasColumnName("assignmentType");
            entity.Property(e => e.EmailId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("emailId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.WorkflowStepId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("workflowStepId");
        });

        modelBuilder.Entity<TblWorkflowStepCondition>(entity =>
        {
            entity.HasKey(e => e.StepConditionId);

            entity.ToTable("tbl_WorkflowStepCondition");

            entity.Property(e => e.StepConditionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("stepConditionId");
            entity.Property(e => e.Condition)
                .IsUnicode(false)
                .HasColumnName("condition");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FieldName)
                .IsUnicode(false)
                .HasColumnName("fieldName");
            entity.Property(e => e.FieldType)
                .IsUnicode(false)
                .HasColumnName("fieldType");
            entity.Property(e => e.Operation)
                .IsUnicode(false)
                .HasColumnName("operation");
            entity.Property(e => e.Value)
                .IsUnicode(false)
                .HasColumnName("value");
            entity.Property(e => e.WorkflowStepId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("workflowStepId");
        });

        modelBuilder.Entity<Temp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP");

            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.AccountGroupName)
                .IsUnicode(false)
                .HasColumnName("accountGroupName");
            entity.Property(e => e.GroupUnder)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupUnder");
        });

        modelBuilder.Entity<Temp1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP1");

            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.AccountGroupName)
                .IsUnicode(false)
                .HasColumnName("accountGroupName");
            entity.Property(e => e.GroupUnder)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupUnder");
        });

        modelBuilder.Entity<Temp81>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP81");

            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.AccountGroupName)
                .IsUnicode(false)
                .HasColumnName("accountGroupName");
            entity.Property(e => e.GroupUnder)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupUnder");
        });

        modelBuilder.Entity<View1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View1");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Expr1).IsUnicode(false);
            entity.Property(e => e.GroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupId");
            entity.Property(e => e.InwardQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("inwardQty");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.OutwardQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("outwardQty");
            entity.Property(e => e.ProductName)
                .IsUnicode(false)
                .HasColumnName("productName");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeName)
                .IsUnicode(false)
                .HasColumnName("voucherTypeName");
        });

        modelBuilder.Entity<ViewCashBank>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewCashBank");

            entity.Property(e => e.AccountGroupId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
        });

        modelBuilder.Entity<VwAllMasterTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_AllMasterTransaction");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<VwAllTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_AllTransactions");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<VwAptransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_APTransactions");

            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.AccountGroupName)
                .IsUnicode(false)
                .HasColumnName("accountGroupName");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.AreaName)
                .IsUnicode(false)
                .HasColumnName("areaName");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.CreditFun)
                .HasColumnType("decimal(38, 10)")
                .HasColumnName("credit_fun");
            entity.Property(e => e.CurrencyIdFun)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("currencyId_fun");
            entity.Property(e => e.CurrencyName)
                .IsUnicode(false)
                .HasColumnName("currencyName");
            entity.Property(e => e.CurrencyNameFun)
                .IsUnicode(false)
                .HasColumnName("currencyName_fun");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.DebitFun)
                .HasColumnType("decimal(38, 10)")
                .HasColumnName("debit_fun");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.DueDay).HasColumnName("dueDay");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LedgerName)
                .IsUnicode(false)
                .HasColumnName("ledgerName");
            entity.Property(e => e.LedgerNumber)
                .IsUnicode(false)
                .HasColumnName("ledgerNumber");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.NetAmount).HasColumnType("decimal(19, 5)");
            entity.Property(e => e.NetAmountFun)
                .HasColumnType("decimal(38, 10)")
                .HasColumnName("NetAmount_fun");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.RouteName)
                .IsUnicode(false)
                .HasColumnName("routeName");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.VoucherTypeName)
                .IsUnicode(false)
                .HasColumnName("voucherTypeName");
        });

        modelBuilder.Entity<VwAptransactions1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_APTransactions1");

            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.AccountGroupName)
                .IsUnicode(false)
                .HasColumnName("accountGroupName");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.AreaName)
                .IsUnicode(false)
                .HasColumnName("areaName");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.CreditFun)
                .HasColumnType("decimal(38, 10)")
                .HasColumnName("credit_fun");
            entity.Property(e => e.CurrencyIdFun)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("currencyId_fun");
            entity.Property(e => e.CurrencyName)
                .IsUnicode(false)
                .HasColumnName("currencyName");
            entity.Property(e => e.CurrencyNameFun)
                .IsUnicode(false)
                .HasColumnName("currencyName_fun");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.DebitFun)
                .HasColumnType("decimal(38, 10)")
                .HasColumnName("debit_fun");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.DueDay).HasColumnName("dueDay");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LedgerName)
                .IsUnicode(false)
                .HasColumnName("ledgerName");
            entity.Property(e => e.LedgerNumber)
                .IsUnicode(false)
                .HasColumnName("ledgerNumber");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.NetAmount).HasColumnType("decimal(19, 5)");
            entity.Property(e => e.NetAmountFun)
                .HasColumnType("decimal(38, 10)")
                .HasColumnName("NetAmount_fun");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.RouteName)
                .IsUnicode(false)
                .HasColumnName("routeName");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.VoucherTypeName)
                .IsUnicode(false)
                .HasColumnName("voucherTypeName");
        });

        modelBuilder.Entity<VwArtransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ARTransactions");

            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.AccountGroupName)
                .IsUnicode(false)
                .HasColumnName("accountGroupName");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.AreaName)
                .IsUnicode(false)
                .HasColumnName("areaName");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.CreditFun)
                .HasColumnType("decimal(38, 10)")
                .HasColumnName("credit_fun");
            entity.Property(e => e.CurrencyIdFun)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("currencyId_fun");
            entity.Property(e => e.CurrencyName)
                .IsUnicode(false)
                .HasColumnName("currencyName");
            entity.Property(e => e.CurrencyNameFun)
                .IsUnicode(false)
                .HasColumnName("currencyName_fun");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.DebitFun)
                .HasColumnType("decimal(38, 10)")
                .HasColumnName("debit_fun");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.DueDay).HasColumnName("dueDay");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LedgerName)
                .IsUnicode(false)
                .HasColumnName("ledgerName");
            entity.Property(e => e.LedgerNumber)
                .IsUnicode(false)
                .HasColumnName("ledgerNumber");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.NetAmount).HasColumnType("decimal(19, 5)");
            entity.Property(e => e.NetAmountFun)
                .HasColumnType("decimal(38, 10)")
                .HasColumnName("NetAmount_fun");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.RouteName)
                .IsUnicode(false)
                .HasColumnName("routeName");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.VoucherTypeName)
                .IsUnicode(false)
                .HasColumnName("voucherTypeName");
        });

        modelBuilder.Entity<VwBanktransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_BANKTransactions");

            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.AccountGroupName)
                .IsUnicode(false)
                .HasColumnName("accountGroupName");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.BalanceLedger)
                .IsUnicode(false)
                .HasColumnName("balanceLedger");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.CreditFun)
                .HasColumnType("decimal(37, 10)")
                .HasColumnName("credit_fun");
            entity.Property(e => e.CurrencyIdFun)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("currencyId_fun");
            entity.Property(e => e.CurrencyName)
                .IsUnicode(false)
                .HasColumnName("currencyName");
            entity.Property(e => e.CurrencyNameFun)
                .IsUnicode(false)
                .HasColumnName("currencyName_fun");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.DebitFun)
                .HasColumnType("decimal(37, 10)")
                .HasColumnName("debit_fun");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.DueDay).HasColumnName("dueDay");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LedgerName)
                .IsUnicode(false)
                .HasColumnName("ledgerName");
            entity.Property(e => e.LedgerNumber)
                .IsUnicode(false)
                .HasColumnName("ledgerNumber");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.NetAmount).HasColumnType("decimal(19, 5)");
            entity.Property(e => e.NetAmountFun)
                .HasColumnType("decimal(38, 10)")
                .HasColumnName("NetAmount_fun");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.VoucherTypeName)
                .IsUnicode(false)
                .HasColumnName("voucherTypeName");
        });

        modelBuilder.Entity<VwMaxRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMaxRate");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Max)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("max");
        });

        modelBuilder.Entity<VwMinRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMinRate");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Min)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("min");
        });

        modelBuilder.Entity<VwStock>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Stock");

            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.ConversionRate)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("conversionRate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("detailsId");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GodownName)
                .IsUnicode(false)
                .HasColumnName("godownName");
            entity.Property(e => e.GroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupId");
            entity.Property(e => e.GroupName)
                .IsUnicode(false)
                .HasColumnName("groupName");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.InwardAllocatedQty)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("inwardAllocatedQty");
            entity.Property(e => e.InwardAllocatedQtyMain)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("inwardAllocatedQty_main");
            entity.Property(e => e.InwardQty)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("inwardQty");
            entity.Property(e => e.InwardQtyMain)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("inwardQty_main");
            entity.Property(e => e.LedgerName)
                .IsUnicode(false)
                .HasColumnName("ledgerName");
            entity.Property(e => e.MainUom)
                .IsUnicode(false)
                .HasColumnName("MainUOM");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.OutwardAllocatedQty)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("outwardAllocatedQty");
            entity.Property(e => e.OutwardAllocatedQtyMain)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("outwardAllocatedQty_main");
            entity.Property(e => e.OutwardQty)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("outwardQty");
            entity.Property(e => e.OutwardQtyMain)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("outwardQty_main");
            entity.Property(e => e.ProductCode)
                .IsUnicode(false)
                .HasColumnName("productCode");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.ProductName)
                .IsUnicode(false)
                .HasColumnName("productName");
            entity.Property(e => e.Rate)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("rate");
            entity.Property(e => e.RateMainUom)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("rateMainUOM");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.UnitName)
                .IsUnicode(false)
                .HasColumnName("unitName");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.VoucherTypeName)
                .IsUnicode(false)
                .HasColumnName("voucherTypeName");
        });

        modelBuilder.Entity<VwStockQuery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwStockQuery");

            entity.Property(e => e.AgainstInvoiceNo)
                .IsUnicode(false)
                .HasColumnName("againstInvoiceNo");
            entity.Property(e => e.AgainstVoucherNo)
                .IsUnicode(false)
                .HasColumnName("againstVoucherNo");
            entity.Property(e => e.AgainstVoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstVoucherTypeId");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.GroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupId");
            entity.Property(e => e.InwardQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("inwardQty");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.OutwardQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("outwardQty");
            entity.Property(e => e.ProductCode)
                .IsUnicode(false)
                .HasColumnName("productCode");
            entity.Property(e => e.ProductName)
                .IsUnicode(false)
                .HasColumnName("productName");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.TypeOfVoucher)
                .IsUnicode(false)
                .HasColumnName("typeOfVoucher");
            entity.Property(e => e.VoucherNo).IsUnicode(false);
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.VoucherTypeName)
                .IsUnicode(false)
                .HasColumnName("voucherTypeName");
        });

        modelBuilder.Entity<VwTax>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Tax");

            entity.Property(e => e.AccountGroupName)
                .IsUnicode(false)
                .HasColumnName("accountGroupName");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("detailsId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerName)
                .IsUnicode(false)
                .HasColumnName("ledgerName");
            entity.Property(e => e.LedgerNumber)
                .IsUnicode(false)
                .HasColumnName("ledgerNumber");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(38, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.TaxName)
                .IsUnicode(false)
                .HasColumnName("taxName");
            entity.Property(e => e.TaxableAmount)
                .HasColumnType("decimal(20, 5)")
                .HasColumnName("taxableAmount");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.VoucherTypeName)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("voucherTypeName");
        });

        modelBuilder.Entity<VwTrialBalance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_TrialBalance");

            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.AccountGroupName)
                .IsUnicode(false)
                .HasColumnName("accountGroupName");
            entity.Property(e => e.AgainstVoucherNo)
                .IsUnicode(false)
                .HasColumnName("againstVoucherNo");
            entity.Property(e => e.AgainstVoucherTypeName)
                .IsUnicode(false)
                .HasColumnName("againstVoucherTypeName");
            entity.Property(e => e.AgainstvoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstvoucherTypeId");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.CreditFun)
                .HasColumnType("decimal(37, 10)")
                .HasColumnName("credit_fun");
            entity.Property(e => e.CurrencyId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("currencyId");
            entity.Property(e => e.CurrencyIdFun)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("currencyId_fun");
            entity.Property(e => e.CurrencyName)
                .IsUnicode(false)
                .HasColumnName("currencyName");
            entity.Property(e => e.CurrencyNameFun)
                .IsUnicode(false)
                .HasColumnName("currencyName_fun");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.DebitFun)
                .HasColumnType("decimal(37, 10)")
                .HasColumnName("debit_fun");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.JournalDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("journalDetailsId");
            entity.Property(e => e.JournalMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("journalMasterId");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LedgerName)
                .IsUnicode(false)
                .HasColumnName("ledgerName");
            entity.Property(e => e.LedgerNumber)
                .IsUnicode(false)
                .HasColumnName("ledgerNumber");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Nature)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nature");
            entity.Property(e => e.ReferenceNo)
                .IsUnicode(false)
                .HasColumnName("referenceNo");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<VwTrialBalanceSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_TrialBalanceSummary");

            entity.Property(e => e.AccountGroup)
                .IsUnicode(false)
                .HasColumnName("Account Group");
            entity.Property(e => e.AccountName)
                .IsUnicode(false)
                .HasColumnName("Account Name");
            entity.Property(e => e.AccountNumber)
                .IsUnicode(false)
                .HasColumnName("Account Number");
            entity.Property(e => e.Balance).HasColumnType("decimal(38, 5)");
            entity.Property(e => e.Credit).HasColumnType("decimal(38, 5)");
            entity.Property(e => e.Debit).HasColumnType("decimal(38, 5)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
