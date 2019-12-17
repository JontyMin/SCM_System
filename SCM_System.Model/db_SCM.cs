namespace SCM_System.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class db_SCM : DbContext
    {
        public db_SCM()
            : base("name=db_SCM")
        {
        }

        public virtual DbSet<CheckDepot> CheckDepot { get; set; }
        public virtual DbSet<CheckDepotDetail> CheckDepotDetail { get; set; }
        public virtual DbSet<Compose> Compose { get; set; }
        public virtual DbSet<ComposeDetail> ComposeDetail { get; set; }
        public virtual DbSet<CustomerLevel> CustomerLevel { get; set; }
        public virtual DbSet<CustomerOrder> CustomerOrder { get; set; }
        public virtual DbSet<CustomerOrderDetail> CustomerOrderDetail { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Depots> Depots { get; set; }
        public virtual DbSet<DepotStock> DepotStock { get; set; }
        public virtual DbSet<DevolveDetail> DevolveDetail { get; set; }
        public virtual DbSet<Devolves> Devolves { get; set; }
        public virtual DbSet<InOutDepot> InOutDepot { get; set; }
        public virtual DbSet<InOutDepotDetail> InOutDepotDetail { get; set; }
        public virtual DbSet<LostDetail> LostDetail { get; set; }
        public virtual DbSet<Losts> Losts { get; set; }
        public virtual DbSet<OtherInDepot> OtherInDepot { get; set; }
        public virtual DbSet<OtherInDepotDetail> OtherInDepotDetail { get; set; }
        public virtual DbSet<OtherOutDepot> OtherOutDepot { get; set; }
        public virtual DbSet<OtherOutDepotDetail> OtherOutDepotDetail { get; set; }
        public virtual DbSet<PayOffDetail> PayOffDetail { get; set; }
        public virtual DbSet<PayOffs> PayOffs { get; set; }
        public virtual DbSet<PopedomRole> PopedomRole { get; set; }
        public virtual DbSet<Popedoms> Popedoms { get; set; }
        public virtual DbSet<ProduceInDepot> ProduceInDepot { get; set; }
        public virtual DbSet<ProduceInDepotDeteil> ProduceInDepotDeteil { get; set; }
        public virtual DbSet<ProduceOutDepot> ProduceOutDepot { get; set; }
        public virtual DbSet<ProduceOutDepotDetail> ProduceOutDepotDetail { get; set; }
        public virtual DbSet<ProductColor> ProductColor { get; set; }
        public virtual DbSet<ProductLend> ProductLend { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductSpec> ProductSpec { get; set; }
        public virtual DbSet<ProductTypes> ProductTypes { get; set; }
        public virtual DbSet<ProductUnit> ProductUnit { get; set; }
        public virtual DbSet<QuotePrice> QuotePrice { get; set; }
        public virtual DbSet<QuotePriceDetail> QuotePriceDetail { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<SaleDepot> SaleDepot { get; set; }
        public virtual DbSet<SaleDepotDetail> SaleDepotDetail { get; set; }
        public virtual DbSet<SaleReturn> SaleReturn { get; set; }
        public virtual DbSet<SaleReturnDetail> SaleReturnDetail { get; set; }
        public virtual DbSet<SplitDetail> SplitDetail { get; set; }
        public virtual DbSet<Splits> Splits { get; set; }
        public virtual DbSet<StockDetail> StockDetail { get; set; }
        public virtual DbSet<StockInDepot> StockInDepot { get; set; }
        public virtual DbSet<StockInDepotDetail> StockInDepotDetail { get; set; }
        public virtual DbSet<StockOutDepot> StockOutDepot { get; set; }
        public virtual DbSet<StockOutDepotDetail> StockOutDepotDetail { get; set; }
        public virtual DbSet<Stocks> Stocks { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersRole> UsersRole { get; set; }
        public virtual DbSet<V_InDepot> V_InDepot { get; set; }
        public virtual DbSet<V_InOutDepotDetail> V_InOutDepotDetail { get; set; }
        public virtual DbSet<V_OutDepot> V_OutDepot { get; set; }
        public virtual DbSet<V_Products> V_Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CheckDepot>()
                .Property(e => e.CDID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CheckDepot>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CheckDepotDetail>()
                .Property(e => e.CDID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CheckDepotDetail>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<Compose>()
                .Property(e => e.ComposeID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Compose>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Compose>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<Compose>()
                .Property(e => e.ComposePrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ComposeDetail>()
                .Property(e => e.ComposeID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ComposeDetail>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<ComposeDetail>()
                .Property(e => e.CDPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CustomerOrder>()
                .Property(e => e.COID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CustomerOrder>()
                .Property(e => e.CusID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CustomerOrderDetail>()
                .Property(e => e.COID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CustomerOrderDetail>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerOrderDetail>()
                .Property(e => e.CODPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CustomerOrderDetail>()
                .Property(e => e.CODDisPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Customers>()
                .Property(e => e.CusID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Depots>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DepotStock>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DepotStock>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<DepotStock>()
                .Property(e => e.DSPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<DevolveDetail>()
                .Property(e => e.DevID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DevolveDetail>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<Devolves>()
                .Property(e => e.DevID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Devolves>()
                .Property(e => e.DevOutID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Devolves>()
                .Property(e => e.DevInID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InOutDepot>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InOutDepot>()
                .Property(e => e.IODNum)
                .IsUnicode(false);

            modelBuilder.Entity<InOutDepot>()
                .Property(e => e.IODLend)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InOutDepot>()
                .Property(e => e.IODCus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InOutDepotDetail>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<InOutDepotDetail>()
                .Property(e => e.IODDPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<InOutDepotDetail>()
                .Property(e => e.IODDOutPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<LostDetail>()
                .Property(e => e.LostID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LostDetail>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<LostDetail>()
                .Property(e => e.LDPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Losts>()
                .Property(e => e.LostID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Losts>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherInDepot>()
                .Property(e => e.OIDID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherInDepot>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherInDepotDetail>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<OtherInDepotDetail>()
                .Property(e => e.OIDID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherInDepotDetail>()
                .Property(e => e.OIDDPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OtherOutDepot>()
                .Property(e => e.OODID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherOutDepot>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherOutDepotDetail>()
                .Property(e => e.OODID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherOutDepotDetail>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<OtherOutDepotDetail>()
                .Property(e => e.OODDPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PayOffDetail>()
                .Property(e => e.POID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PayOffDetail>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<PayOffDetail>()
                .Property(e => e.PODPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PayOffs>()
                .Property(e => e.POID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PayOffs>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Popedoms>()
                .Property(e => e.PopValue)
                .IsUnicode(false);

            modelBuilder.Entity<ProduceInDepot>()
                .Property(e => e.PIDID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProduceInDepot>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProduceInDepotDeteil>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<ProduceInDepotDeteil>()
                .Property(e => e.PIDID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProduceInDepotDeteil>()
                .Property(e => e.PIDDPrice)
                .HasPrecision(14, 0);

            modelBuilder.Entity<ProduceOutDepot>()
                .Property(e => e.PODID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProduceOutDepot>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProduceOutDepotDetail>()
                .Property(e => e.PODID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProduceOutDepotDetail>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<ProduceOutDepotDetail>()
                .Property(e => e.PODDPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ProductLend>()
                .Property(e => e.PPID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProductLend>()
                .Property(e => e.PPEmail)
                .IsUnicode(false);

            modelBuilder.Entity<ProductLend>()
                .Property(e => e.PPUrl)
                .IsUnicode(false);

            modelBuilder.Entity<ProductLend>()
                .Property(e => e.PPGoods)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProJP)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProTM)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProWorkShop)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProInPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Products>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QuotePrice>()
                .Property(e => e.QPID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QuotePrice>()
                .Property(e => e.CusID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QuotePriceDetail>()
                .Property(e => e.QPID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QuotePriceDetail>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<QuotePriceDetail>()
                .Property(e => e.QPDPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<QuotePriceDetail>()
                .Property(e => e.QPDDisPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SaleDepot>()
                .Property(e => e.SDID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SaleDepot>()
                .Property(e => e.CusID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SaleDepot>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SaleDepotDetail>()
                .Property(e => e.SDID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SaleDepotDetail>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<SaleDepotDetail>()
                .Property(e => e.SDDPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SaleDepotDetail>()
                .Property(e => e.SDDDisPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SaleReturn>()
                .Property(e => e.SRID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SaleReturn>()
                .Property(e => e.CusID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SaleReturn>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SaleReturnDetail>()
                .Property(e => e.SRID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SaleReturnDetail>()
                .Property(e => e.SRDPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SplitDetail>()
                .Property(e => e.SplitID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SplitDetail>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<SplitDetail>()
                .Property(e => e.SDPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Splits>()
                .Property(e => e.SplitID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Splits>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Splits>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<Splits>()
                .Property(e => e.SplitPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<StockDetail>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<StockDetail>()
                .Property(e => e.StockID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<StockDetail>()
                .Property(e => e.SDetailPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<StockInDepot>()
                .Property(e => e.SIDID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<StockInDepot>()
                .Property(e => e.PPID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<StockInDepot>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<StockInDepot>()
                .Property(e => e.StockID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<StockInDepot>()
                .Property(e => e.SIDDeliver)
                .IsUnicode(false);

            modelBuilder.Entity<StockInDepot>()
                .Property(e => e.SIDFreight)
                .HasPrecision(10, 2);

            modelBuilder.Entity<StockInDepotDetail>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<StockInDepotDetail>()
                .Property(e => e.SIDID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<StockInDepotDetail>()
                .Property(e => e.SIDDPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<StockOutDepot>()
                .Property(e => e.SRDID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<StockOutDepot>()
                .Property(e => e.PPID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<StockOutDepot>()
                .Property(e => e.StockID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<StockOutDepot>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<StockOutDepotDetail>()
                .Property(e => e.SRDID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<StockOutDepotDetail>()
                .Property(e => e.SIDDPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Stocks>()
                .Property(e => e.StockID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Stocks>()
                .Property(e => e.PPID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserLoginName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserLoginPwd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_InDepot>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_InDepot>()
                .Property(e => e.IODNum)
                .IsUnicode(false);

            modelBuilder.Entity<V_InDepot>()
                .Property(e => e.IODLend)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_InDepot>()
                .Property(e => e.IODCus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_InDepot>()
                .Property(e => e.SumMoney)
                .HasPrecision(38, 2);

            modelBuilder.Entity<V_InOutDepotDetail>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<V_InOutDepotDetail>()
                .Property(e => e.IODDPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<V_InOutDepotDetail>()
                .Property(e => e.IODDOutPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<V_InOutDepotDetail>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_InOutDepotDetail>()
                .Property(e => e.IODDMoney)
                .HasPrecision(21, 2);

            modelBuilder.Entity<V_OutDepot>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_OutDepot>()
                .Property(e => e.IODNum)
                .IsUnicode(false);

            modelBuilder.Entity<V_OutDepot>()
                .Property(e => e.IODLend)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_OutDepot>()
                .Property(e => e.IODCus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_OutDepot>()
                .Property(e => e.SumMoney)
                .HasPrecision(38, 2);

            modelBuilder.Entity<V_Products>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<V_Products>()
                .Property(e => e.ProJP)
                .IsUnicode(false);

            modelBuilder.Entity<V_Products>()
                .Property(e => e.ProTM)
                .IsUnicode(false);

            modelBuilder.Entity<V_Products>()
                .Property(e => e.ProWorkShop)
                .IsUnicode(false);

            modelBuilder.Entity<V_Products>()
                .Property(e => e.ProInPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<V_Products>()
                .Property(e => e.ProPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<V_Products>()
                .Property(e => e.DepotID)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
