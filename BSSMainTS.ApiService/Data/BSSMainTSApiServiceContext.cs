using System;
using System.Collections.Generic;
using BSSMainTS.ApiService.Models;
using Microsoft.EntityFrameworkCore;

namespace BSSMainTS.ApiService.Data;

public partial class BSSMainTSApiServiceContext : DbContext
{
    public BSSMainTSApiServiceContext()
    {
    }

    public BSSMainTSApiServiceContext(DbContextOptions<BSSMainTSApiServiceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Changelog> Changelogs { get; set; }

    public virtual DbSet<DbVersion> DbVersions { get; set; }

    public virtual DbSet<DwInsertViewKnzienjaM> DwInsertViewKnzienjaMs { get; set; }

    public virtual DbSet<DwKnizenja> DwKnizenjas { get; set; }

    public virtual DbSet<Etobrazec> Etobrazecs { get; set; }

    public virtual DbSet<GeneralDataMesec> GeneralDataMesecs { get; set; }

    public virtual DbSet<GenerateMissingIndex> GenerateMissingIndexes { get; set; }

    public virtual DbSet<ImportStanari> ImportStanaris { get; set; }

    public virtual DbSet<IzmenetiSmetki> IzmenetiSmetkis { get; set; }

    public virtual DbSet<KoliciniNaArtikli> KoliciniNaArtiklis { get; set; }

    public virtual DbSet<KontrolaNaSmetka> KontrolaNaSmetkas { get; set; }

    public virtual DbSet<ListaNaDolznici> ListaNaDolznicis { get; set; }

    public virtual DbSet<Mat> Mats { get; set; }

    public virtual DbSet<MatKujna> MatKujnas { get; set; }

    public virtual DbSet<NaloziPregled> NaloziPregleds { get; set; }

    public virtual DbSet<Pltobrazec> Pltobrazecs { get; set; }

    public virtual DbSet<PltobrazecDoc> PltobrazecDocs { get; set; }

    public virtual DbSet<RabatPoDatum> RabatPoData { get; set; }

    public virtual DbSet<SaldoNaPartneriSoAnalitka> SaldoNaPartneriSoAnalitkas { get; set; }

    public virtual DbSet<TblAkcijaNaArtikal> TblAkcijaNaArtikals { get; set; }

    public virtual DbSet<TblArtikal> TblArtikals { get; set; }

    public virtual DbSet<TblArtikalNotUsed> TblArtikalNotUseds { get; set; }

    public virtual DbSet<TblBanki> TblBankis { get; set; }

    public virtual DbSet<TblClientConfiguracija> TblClientConfiguracijas { get; set; }

    public virtual DbSet<TblConfig> TblConfigs { get; set; }

    public virtual DbSet<TblDdvstavka> TblDdvstavkas { get; set; }

    public virtual DbSet<TblDokumentStavki> TblDokumentStavkis { get; set; }

    public virtual DbSet<TblDokumentStavkiDetailsInfo> TblDokumentStavkiDetailsInfos { get; set; }

    public virtual DbSet<TblDokumenti> TblDokumentis { get; set; }

    public virtual DbSet<TblDokumentiDetailsInfo> TblDokumentiDetailsInfos { get; set; }

    public virtual DbSet<TblDokumentiDetailsInfoHvac> TblDokumentiDetailsInfoHvacs { get; set; }

    public virtual DbSet<TblDokumentiTemplate> TblDokumentiTemplates { get; set; }

    public virtual DbSet<TblEdinecniMerki> TblEdinecniMerkis { get; set; }

    public virtual DbSet<TblElektronskoPracanje> TblElektronskoPracanjes { get; set; }

    public virtual DbSet<TblFaktura> TblFakturas { get; set; }

    public virtual DbSet<TblFakturaStavki> TblFakturaStavkis { get; set; }

    public virtual DbSet<TblFirma> TblFirmas { get; set; }

    public virtual DbSet<TblFiskalniSmetki> TblFiskalniSmetkis { get; set; }

    public virtual DbSet<TblGrupaNaArtikli> TblGrupaNaArtiklis { get; set; }

    public virtual DbSet<TblIzvodi> TblIzvodis { get; set; }

    public virtual DbSet<TblIzvodiStavki> TblIzvodiStavkis { get; set; }

    public virtual DbSet<TblKnizenjeM> TblKnizenjeMs { get; set; }

    public virtual DbSet<TblKursnaListum> TblKursnaLista { get; set; }

    public virtual DbSet<TblLog> TblLogs { get; set; }

    public virtual DbSet<TblNalog> TblNalogs { get; set; }

    public virtual DbSet<TblNalogIzmenetum> TblNalogIzmeneta { get; set; }

    public virtual DbSet<TblNalogStavki> TblNalogStavkis { get; set; }

    public virtual DbSet<TblNalogStavkiIzmenetum> TblNalogStavkiIzmeneta { get; set; }

    public virtual DbSet<TblNaracki> TblNarackis { get; set; }

    public virtual DbSet<TblNetworkPc> TblNetworkPcs { get; set; }

    public virtual DbSet<TblNetworkPclog> TblNetworkPclogs { get; set; }

    public virtual DbSet<TblNormativ> TblNormativs { get; set; }

    public virtual DbSet<TblNormativStavki> TblNormativStavkis { get; set; }

    public virtual DbSet<TblObjekti> TblObjektis { get; set; }

    public virtual DbSet<TblPartneri> TblPartneris { get; set; }

    public virtual DbSet<TblPodgrupaId> TblPodgrupaIds { get; set; }

    public virtual DbSet<TblPresmetkovniEdinici> TblPresmetkovniEdinicis { get; set; }

    public virtual DbSet<TblPrevodi> TblPrevodis { get; set; }

    public virtual DbSet<TblPriem> TblPriems { get; set; }

    public virtual DbSet<TblPriemStavki> TblPriemStavkis { get; set; }

    public virtual DbSet<TblSesija> TblSesijas { get; set; }

    public virtual DbSet<TblSmetka> TblSmetkas { get; set; }

    public virtual DbSet<TblSmetkaIzmenetum> TblSmetkaIzmeneta { get; set; }

    public virtual DbSet<TblSmetkaStavki> TblSmetkaStavkis { get; set; }

    public virtual DbSet<TblSmetkaStavkiIzmenetum> TblSmetkaStavkiIzmeneta { get; set; }

    public virtual DbSet<TblTipNaDokument> TblTipNaDokuments { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TblUserConfig> TblUserConfigs { get; set; }

    public virtual DbSet<TblValuti> TblValutis { get; set; }

    public virtual DbSet<TblZabeleshki> TblZabeleshkis { get; set; }

    public virtual DbSet<TblZalihaNaArtikli> TblZalihaNaArtiklis { get; set; }

    public virtual DbSet<TblZiroSmetki> TblZiroSmetkis { get; set; }

    public virtual DbSet<ViewArtikalInfo> ViewArtikalInfos { get; set; }

    public virtual DbSet<ViewArtikaliNormativi> ViewArtikaliNormativis { get; set; }

    public virtual DbSet<ViewArtikli> ViewArtiklis { get; set; }

    public virtual DbSet<ViewArtikliVoSmetka> ViewArtikliVoSmetkas { get; set; }

    public virtual DbSet<ViewArtikliVoSmetkaIzmenetum> ViewArtikliVoSmetkaIzmeneta { get; set; }

    public virtual DbSet<ViewArtikliVoSmetkaKasa> ViewArtikliVoSmetkaKasas { get; set; }

    public virtual DbSet<ViewArtikliVoSmetkaKasabezZaokruzuenje> ViewArtikliVoSmetkaKasabezZaokruzuenjes { get; set; }

    public virtual DbSet<ViewDokumenti> ViewDokumentis { get; set; }

    public virtual DbSet<ViewDokumentiStavki> ViewDokumentiStavkis { get; set; }

    public virtual DbSet<ViewDokumentiZaPlakjanaOdPartnerPoDokument> ViewDokumentiZaPlakjanaOdPartnerPoDokuments { get; set; }

    public virtual DbSet<ViewDokumentiZaPlakjanje> ViewDokumentiZaPlakjanjes { get; set; }

    public virtual DbSet<ViewDospeaniFakturi> ViewDospeaniFakturis { get; set; }

    public virtual DbSet<ViewFakturi> ViewFakturis { get; set; }

    public virtual DbSet<ViewFakturiStavki> ViewFakturiStavkis { get; set; }

    public virtual DbSet<ViewIzvodi> ViewIzvodis { get; set; }

    public virtual DbSet<ViewIzvodiStavki> ViewIzvodiStavkis { get; set; }

    public virtual DbSet<ViewKnzienjaM> ViewKnzienjaMs { get; set; }

    public virtual DbSet<ViewPopi> ViewPopis { get; set; }

    public virtual DbSet<ViewPopisDetalenLagerListum> ViewPopisDetalenLagerLista { get; set; }

    public virtual DbSet<ViewPriemStavki> ViewPriemStavkis { get; set; }

    public virtual DbSet<ViewPriemi> ViewPriemis { get; set; }

    public virtual DbSet<ViewSmetki> ViewSmetkis { get; set; }

    public virtual DbSet<ViewSveUedno> ViewSveUednos { get; set; }

    public virtual DbSet<ViewSveUednoBeZalihaIsamoArtikli> ViewSveUednoBeZalihaIsamoArtiklis { get; set; }

    public virtual DbSet<ViewZaliha> ViewZalihas { get; set; }

    public virtual DbSet<ViewZalihaCelosna> ViewZalihaCelosnas { get; set; }

    public virtual DbSet<ViewZarabotkaPoArtikal> ViewZarabotkaPoArtikals { get; set; }

    public virtual DbSet<ViewZiroSmetke> ViewZiroSmetkes { get; set; }

    public virtual DbSet<VwIndexText> VwIndexTexts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=> optionsBuilder.UseSqlServer("Server=vlezi.com;Initial Catalog=BSHOME;Persist Security Info=True;User ID=spiro;Password=nirvana;Encrypt=False;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Changelog>(entity =>
        {
            entity.HasKey(e => e.ChangeNumber).HasName("Pkchangelog");

            entity.ToTable("changelog");

            entity.Property(e => e.ChangeNumber)
                .ValueGeneratedNever()
                .HasColumnName("change_number");
            entity.Property(e => e.AppliedBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("applied_by");
            entity.Property(e => e.CompleteDt)
                .HasColumnType("datetime")
                .HasColumnName("complete_dt");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
        });

        modelBuilder.Entity<DbVersion>(entity =>
        {
            entity.ToTable("DbVersion");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DbVersion1)
                .HasMaxLength(30)
                .HasColumnName("DbVersion");
            entity.Property(e => e.LastAlterScriptName).HasMaxLength(50);
        });

        modelBuilder.Entity<DwInsertViewKnzienjaM>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DW_Insert_viewKnzienjaM");

            entity.Property(e => e.AltSifraArtikal).HasMaxLength(50);
            entity.Property(e => e.DatumNaKnizenje).HasColumnType("datetime");
            entity.Property(e => e.DatumNaKraj).HasColumnType("datetime");
            entity.Property(e => e.DatumNaPocetok).HasColumnType("datetime");
            entity.Property(e => e.DoObjekt)
                .HasMaxLength(50)
                .HasColumnName("doObjekt");
            entity.Property(e => e.EdinecnaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FakturaBroj).HasColumnName("fakturaBroj");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IznosBezDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IznosBezDDV");
            entity.Property(e => e.IznosDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IznosDDV");
            entity.Property(e => e.IznosNaRabat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IznosSoDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IznosSoDDV");
            entity.Property(e => e.KodNaDokument).HasMaxLength(70);
            entity.Property(e => e.Kolicina).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.Kratenka).HasMaxLength(3);
            entity.Property(e => e.NabavnaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.OdObjekt)
                .HasMaxLength(50)
                .HasColumnName("odObjekt");
            entity.Property(e => e.Procent).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProdaznaCenaSoRabat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rabat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
            entity.Property(e => e.TblDdvid).HasColumnName("tblDDVID");
            entity.Property(e => e.TblDokumentId).HasColumnName("tblDokumentID");
            entity.Property(e => e.TblNormativId).HasColumnName("tblNormativID");
            entity.Property(e => e.TblObjektiIddo).HasColumnName("tblObjektiIDDO");
            entity.Property(e => e.TblObjektiIdod).HasColumnName("tblObjektiIDOD");
            entity.Property(e => e.TblPartnerId).HasColumnName("tblPartnerID");
            entity.Property(e => e.TblPriemId).HasColumnName("tblPriemID");
            entity.Property(e => e.TblSmetkaId).HasColumnName("tblSmetkaID");
            entity.Property(e => e.TipNaArtikal).HasColumnName("tipNaArtikal");
            entity.Property(e => e.TipNaKnizenje).HasColumnName("tipNaKnizenje");
            entity.Property(e => e.VrabotenKojJaIzdalSmetkata).HasMaxLength(50);
        });

        modelBuilder.Entity<DwKnizenja>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DW_Knizenja");

            entity.Property(e => e.AltSifraArtikal).HasMaxLength(50);
            entity.Property(e => e.DatumNaKnizenje).HasColumnType("datetime");
            entity.Property(e => e.DatumNaKraj).HasColumnType("datetime");
            entity.Property(e => e.DatumNaPocetok).HasColumnType("datetime");
            entity.Property(e => e.DoObjekt)
                .HasMaxLength(50)
                .HasColumnName("doObjekt");
            entity.Property(e => e.EdinecnaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FakturaBroj).HasColumnName("fakturaBroj");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IznosBezDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IznosBezDDV");
            entity.Property(e => e.IznosDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IznosDDV");
            entity.Property(e => e.IznosNaRabat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IznosSoDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IznosSoDDV");
            entity.Property(e => e.KodNaDokument).HasMaxLength(70);
            entity.Property(e => e.Kolicina).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.Kratenka).HasMaxLength(3);
            entity.Property(e => e.NabavnaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.OdObjekt)
                .HasMaxLength(50)
                .HasColumnName("odObjekt");
            entity.Property(e => e.Procent).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProdaznaCenaSoRabat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rabat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
            entity.Property(e => e.TblDdvid).HasColumnName("tblDDVID");
            entity.Property(e => e.TblDokumentId).HasColumnName("tblDokumentID");
            entity.Property(e => e.TblNormativId).HasColumnName("tblNormativID");
            entity.Property(e => e.TblObjektiIddo).HasColumnName("tblObjektiIDDO");
            entity.Property(e => e.TblObjektiIdod).HasColumnName("tblObjektiIDOD");
            entity.Property(e => e.TblPartnerId).HasColumnName("tblPartnerID");
            entity.Property(e => e.TblPriemId).HasColumnName("tblPriemID");
            entity.Property(e => e.TblSmetkaId).HasColumnName("tblSmetkaID");
            entity.Property(e => e.TipNaArtikal).HasColumnName("tipNaArtikal");
            entity.Property(e => e.TipNaKnizenje).HasColumnName("tipNaKnizenje");
            entity.Property(e => e.VrabotenKojJaIzdalSmetkata).HasMaxLength(50);
        });

        modelBuilder.Entity<Etobrazec>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ETobrazec");

            entity.Property(e => e.DatumNaDokument).HasColumnType("datetime");
            entity.Property(e => e.DatumNaKnizenje).HasColumnType("datetime");
            entity.Property(e => e.DnevenPromet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NabavnaVrednost).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.NazivIBrojNaDokument)
                .HasMaxLength(34)
                .HasColumnName("Naziv i brojNaDokument");
            entity.Property(e => e.ProdaznaVrednost).HasColumnType("decimal(38, 6)");
        });

        modelBuilder.Entity<GeneralDataMesec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("General_data_mesec");

            entity.Property(e => e.HidrokitHighTariffKwh)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("hidrokit_high_tariff_kwh");
            entity.Property(e => e.HidrokitLowTariffKwh)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("hidrokit_low_tariff_kwh");
            entity.Property(e => e.HidrokitUsers)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("hidrokit_users");
            entity.Property(e => e.IndoorsHighTariffMin)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("indoors_high_tariff_min");
            entity.Property(e => e.IndoorsHighTariffTotalMin)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("indoors_high_tariff_total_min");
            entity.Property(e => e.IndoorsLowTariffMin)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("indoors_low_tariff_min");
            entity.Property(e => e.IndoorsLowTariffTotalMin)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("indoors_low_tariff_total_min");
            entity.Property(e => e.IndoorsTotalPrice)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("indoors_total_price");
            entity.Property(e => e.LostElectricityHighTariff)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("lost_electricity_high_tariff");
            entity.Property(e => e.LostElectricityLowTariff)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("lost_electricity_low_tariff");
            entity.Property(e => e.Mesec).HasColumnName("mesec");
            entity.Property(e => e.SupplierHighTariffKwh)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("supplier_high_tariff_kwh");
            entity.Property(e => e.SupplierLowTariffKwh)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("supplier_low_tariff_kwh");
            entity.Property(e => e.SupplierTotalBill)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("supplier_total_bill");
            entity.Property(e => e.TotalWarmWaterConsumed)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("total_warm_water_consumed");
            entity.Property(e => e.WarmWaterHeatingTotalPrice)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("warm_water_heating_total_price");
            entity.Property(e => e.WarmWaterMaintainingFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("warm_water_maintaining_fee");
            entity.Property(e => e.WarmWaterPrice)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("warm_water_price");
            entity.Property(e => e.WarmWaterTotalCost)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("warm_water_total_cost");
        });

        modelBuilder.Entity<GenerateMissingIndex>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GenerateMissingIndexes");

            entity.Property(e => e.ConstraintName)
                .HasMaxLength(128)
                .HasColumnName("Constraint_Name");
            entity.Property(e => e.NonIndexedColColumnName)
                .HasMaxLength(128)
                .HasColumnName("NonIndexedCol_Column_Name");
            entity.Property(e => e.NonIndexedColTableName)
                .HasMaxLength(128)
                .HasColumnName("NonIndexedCol_Table_Name");
        });

        modelBuilder.Entity<ImportStanari>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ImportStanari");

            entity.Property(e => e.Адреса)
                .HasMaxLength(255)
                .HasColumnName("АДРЕСА");
            entity.Property(e => e.ИмотенЛист)
                .HasMaxLength(255)
                .HasColumnName("ИМОТЕН ЛИСТ");
            entity.Property(e => e.Кат)
                .HasMaxLength(255)
                .HasColumnName("КАТ");
            entity.Property(e => e.ПовршинаM2).HasColumnName("ПОВРШИНА (m2)");
            entity.Property(e => e.СопственикЦи)
                .HasMaxLength(255)
                .HasColumnName("СОПСТВЕНИК/ЦИ");
            entity.Property(e => e.Стан)
                .HasMaxLength(255)
                .HasColumnName("СТАН");
        });

        modelBuilder.Entity<IzmenetiSmetki>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("IzmenetiSmetki");

            entity.Property(e => e.DatumKraj).HasColumnType("datetime");
            entity.Property(e => e.DatumNaIzmena).HasColumnType("datetime");
            entity.Property(e => e.DatumPocetok).HasColumnType("datetime");
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ObjektId).HasColumnName("ObjektID");
            entity.Property(e => e.SmenaId).HasColumnName("Smena_ID");
            entity.Property(e => e.TblSmetkaIzmenetaId).HasColumnName("tblSmetkaIzmenetaID");
            entity.Property(e => e.TblUserId).HasColumnName("tblUserID");
        });

        modelBuilder.Entity<KoliciniNaArtikli>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KoliciniNaArtikli");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Izlez).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.Saldo).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.Vlez).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.ZalihaSoVrednost).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<KontrolaNaSmetka>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KontrolaNaSmetka");

            entity.Property(e => e.DatumKraj).HasColumnType("datetime");
            entity.Property(e => e.DatumPocetok).HasColumnType("datetime");
            entity.Property(e => e.Fiskalna).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.SmetkaId).HasColumnName("SmetkaID");
            entity.Property(e => e.TblUserId).HasColumnName("tblUserID");
            entity.Property(e => e.VkupenPromet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VkupnoFiskalna).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VkupnoNalozi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VkupnoNeFiskalenPromet).HasColumnType("decimal(19, 2)");
        });

        modelBuilder.Entity<ListaNaDolznici>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ListaNaDolznici");

            entity.Property(e => e.BrojNaDokument).HasMaxLength(50);
            entity.Property(e => e.IznosSoDdv)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("IznosSoDDV");
            entity.Property(e => e.Naziv).HasMaxLength(350);
            entity.Property(e => e.Plateno).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Saldo).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
        });

        modelBuilder.Entity<Mat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mat");

            entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.NalogId).HasColumnName("NalogID");
            entity.Property(e => e.Naziv).HasMaxLength(100);
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sifra).HasMaxLength(10);
        });

        modelBuilder.Entity<MatKujna>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("matKujna");

            entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Naziv).HasMaxLength(100);
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sifra).HasMaxLength(10);
        });

        modelBuilder.Entity<NaloziPregled>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NaloziPregled");

            entity.Property(e => e.DatumPocetok).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.SmetkaId).HasColumnName("SmetkaID");
            entity.Property(e => e.Suma).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Zabeleska).HasMaxLength(350);
        });

        modelBuilder.Entity<Pltobrazec>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PLTobrazec");

            entity.Property(e => e.Cena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CenaProdazba)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cena Prodazba");
            entity.Property(e => e.DatumNaPriem).HasColumnType("datetime");
            entity.Property(e => e.DdvPriNabavka)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DDV pri nabavka");
            entity.Property(e => e.DoObjekt)
                .HasMaxLength(50)
                .HasColumnName("doObjekt");
            entity.Property(e => e.EdM).HasMaxLength(3);
            entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IznosProdazba)
                .HasColumnType("decimal(31, 6)")
                .HasColumnName("Iznos Prodazba");
            entity.Property(e => e.Kolicina).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.NazivNaStokata)
                .HasMaxLength(150)
                .HasColumnName("Naziv na stokata");
            entity.Property(e => e.StapkaNaDdvPropis)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("Stapka na DDV propis");
            entity.Property(e => e.TblDokumentId).HasColumnName("tblDokumentID");
            entity.Property(e => e.TblPriemId).HasColumnName("tblPriemID");
            entity.Property(e => e.VkupnoDdvProdaznaVrednost)
                .HasColumnType("decimal(38, 7)")
                .HasColumnName("VkupnoDDV prodazna vrednost");
        });

        modelBuilder.Entity<PltobrazecDoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PLTobrazecDoc");

            entity.Property(e => e.Cena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CenaProdazba)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cena Prodazba");
            entity.Property(e => e.DatumNaPriem).HasColumnType("datetime");
            entity.Property(e => e.DdvPriNabavka)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DDV pri nabavka");
            entity.Property(e => e.EdM).HasMaxLength(3);
            entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IznosProdazba)
                .HasColumnType("decimal(31, 6)")
                .HasColumnName("Iznos Prodazba");
            entity.Property(e => e.Kolicina).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.NazivNaStokata)
                .HasMaxLength(150)
                .HasColumnName("Naziv na stokata");
            entity.Property(e => e.StapkaNaDdvPropis)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("Stapka na DDV propis");
            entity.Property(e => e.VkupnoDdvProdaznaVrednost)
                .HasColumnType("decimal(38, 7)")
                .HasColumnName("VkupnoDDV prodazna vrednost");
        });

        modelBuilder.Entity<RabatPoDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RabatPoDatum");

            entity.Property(e => e.Rabat).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TblDdvid).HasColumnName("tblDDVID");
        });

        modelBuilder.Entity<SaldoNaPartneriSoAnalitka>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SaldoNaPartneriSoAnalitka");

            entity.Property(e => e.BrojNaDokument).HasMaxLength(50);
            entity.Property(e => e.IznosSoDdv)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("IznosSoDDV");
            entity.Property(e => e.Naziv).HasMaxLength(350);
            entity.Property(e => e.Plateno).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Saldo).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.TipNaDostava).HasMaxLength(28);
            entity.Property(e => e.Zabeleski).HasMaxLength(400);
        });

        modelBuilder.Entity<TblAkcijaNaArtikal>(entity =>
        {
            entity.ToTable("tblAkcijaNaArtikal");

            entity.HasIndex(e => e.TblArtikalId, "FK_tblAkcijaNaArtikal_tblAkcijaNaArtikal");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AkciskaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Rabat).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");

            entity.HasOne(d => d.TblArtikal).WithMany(p => p.TblAkcijaNaArtikals)
                .HasForeignKey(d => d.TblArtikalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAkcijaNaArtikal_tblAkcijaNaArtikal");
        });

        modelBuilder.Entity<TblArtikal>(entity =>
        {
            entity.ToTable("tblArtikal");

            entity.HasIndex(e => e.TblDdvstavkaId, "FK_tblArtikal_tblDDVStavkaID");

            entity.HasIndex(e => e.TblEdinecniMerkiId, "FK_tblArtikal_tblEdinecniMerkiID");

            entity.HasIndex(e => e.FirmaId, "FK_tblArtikal_tblFirma");

            entity.HasIndex(e => e.PodgrupaId, "FK_tblArtikal_tblPodgrupaID");

            entity.HasIndex(e => e.FirmaId, "NonClusteredIndex-20230513-102338");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AltNaziv).HasMaxLength(150);
            entity.Property(e => e.AltNaziv2).HasMaxLength(150);
            entity.Property(e => e.AltSifra).HasMaxLength(50);
            entity.Property(e => e.Barkod1).HasMaxLength(50);
            entity.Property(e => e.Barkod2).HasMaxLength(50);
            entity.Property(e => e.CenaNaGolemo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Edmizlez).HasColumnName("EDMIzlez");
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Image).HasMaxLength(250);
            entity.Property(e => e.KlucniZborovi).HasMaxLength(300);
            entity.Property(e => e.KolicinaT).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.MinimalnaKolicinaNaZaliha).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.NabavnaCena)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.PodgrupaId).HasColumnName("PodgrupaID");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RedenBroj).HasDefaultValue(0);
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.TblDdvstavkaId).HasColumnName("tblDDVStavkaID");
            entity.Property(e => e.TblEdinecniMerkiId).HasColumnName("tblEdinecniMerkiID");

            entity.HasOne(d => d.Firma).WithMany(p => p.TblArtikals)
                .HasForeignKey(d => d.FirmaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblArtikal_tblFirma");

            entity.HasOne(d => d.Podgrupa).WithMany(p => p.TblArtikals)
                .HasForeignKey(d => d.PodgrupaId)
                .HasConstraintName("FK_tblArtikal_tblPodgrupaID");

            entity.HasOne(d => d.TblDdvstavka).WithMany(p => p.TblArtikals)
                .HasForeignKey(d => d.TblDdvstavkaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblArtikal_tblDDVStavka");

            entity.HasOne(d => d.TblEdinecniMerki).WithMany(p => p.TblArtikals)
                .HasForeignKey(d => d.TblEdinecniMerkiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblArtikal_tblEdinecniMerki");
        });

        modelBuilder.Entity<TblArtikalNotUsed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblArtikal_NotUsed");

            entity.Property(e => e.AltNaziv).HasMaxLength(150);
            entity.Property(e => e.AltNaziv2).HasMaxLength(150);
            entity.Property(e => e.AltSifra).HasMaxLength(50);
            entity.Property(e => e.Barkod1).HasMaxLength(50);
            entity.Property(e => e.Barkod2).HasMaxLength(50);
            entity.Property(e => e.CenaNaGolemo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Edmizlez).HasColumnName("EDMIzlez");
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(250);
            entity.Property(e => e.KlucniZborovi).HasMaxLength(300);
            entity.Property(e => e.KolicinaT).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.MinimalnaKolicinaNaZaliha).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.NabavnaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.PodgrupaId).HasColumnName("PodgrupaID");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.TblDdvstavkaId).HasColumnName("tblDDVStavkaID");
            entity.Property(e => e.TblEdinecniMerkiId).HasColumnName("tblEdinecniMerkiID");
        });

        modelBuilder.Entity<TblBanki>(entity =>
        {
            entity.ToTable("tblBanki");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Naziv).HasMaxLength(100);
            entity.Property(e => e.Sifra).HasMaxLength(20);
        });

        modelBuilder.Entity<TblClientConfiguracija>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblClien__3214EC27AA14FD0B");

            entity.ToTable("tblClientConfiguracija");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<TblConfig>(entity =>
        {
            entity.ToTable("tblConfig");

            entity.HasIndex(e => e.Ime, "IX_tblConfig").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Ime).HasMaxLength(50);
            entity.Property(e => e.ImeNaModul)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NivoNaAdministracija).HasDefaultValue(0);
            entity.Property(e => e.Opis).HasMaxLength(50);
            entity.Property(e => e.Range)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("0-1");
            entity.Property(e => e.Vrednost).HasDefaultValue(0);
        });

        modelBuilder.Entity<TblDdvstavka>(entity =>
        {
            entity.ToTable("tblDDVStavka");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Naziv).HasMaxLength(20);
            entity.Property(e => e.Procent).HasColumnType("decimal(4, 2)");
        });

        modelBuilder.Entity<TblDokumentStavki>(entity =>
        {
            entity.ToTable("tblDokumentStavki");

            entity.HasIndex(e => e.TblDokumentId, "FK_tblDokumentStavki_tblDokumenti");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cena).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rabat1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
            entity.Property(e => e.TblDokumentId).HasColumnName("tblDokumentID");
            entity.Property(e => e.TblNormativId).HasColumnName("tblNormativID");

            entity.HasOne(d => d.TblDokument).WithMany(p => p.TblDokumentStavkis)
                .HasForeignKey(d => d.TblDokumentId)
                .HasConstraintName("FK_tblDokumentStavki_tblDokumenti");
        });

        modelBuilder.Entity<TblDokumentStavkiDetailsInfo>(entity =>
        {
            entity.ToTable("tblDokumentStavkiDetailsInfo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.NotesBroj).HasMaxLength(150);
            entity.Property(e => e.NotesId).HasColumnName("NotesID");
            entity.Property(e => e.NotesRef).HasColumnName("NotesREF");
            entity.Property(e => e.NotesText).HasMaxLength(350);
            entity.Property(e => e.TblDokumentId).HasColumnName("tblDokumentId");
            entity.Property(e => e.TblDokumentStavkiId).HasColumnName("tblDokumentStavkiId");
        });

        modelBuilder.Entity<TblDokumenti>(entity =>
        {
            entity.ToTable("tblDokumenti");

            entity.HasIndex(e => e.TblPartnerId, "FK_tblArtikal_tblPartnerID");

            entity.HasIndex(e => e.TipNaDokument, "FK_tblDokumenti_tblTipNaDokument");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BrojNaDokument).HasMaxLength(50);
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.DateModified)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DatumNaValuta).HasColumnType("datetime");
            entity.Property(e => e.DatumPeriod).HasColumnType("datetime");
            entity.Property(e => e.DoObjektId).HasColumnName("DoObjektID");
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.KodNaDokument).HasMaxLength(70);
            entity.Property(e => e.Notes).HasMaxLength(400);
            entity.Property(e => e.OdObjektId).HasColumnName("OdObjektID");
            entity.Property(e => e.TblPartnerId).HasColumnName("tblPartnerID");
            entity.Property(e => e.TblUserId).HasColumnName("tblUserID");
            entity.Property(e => e.UniqueIdPlacanje).HasMaxLength(20);
        });

        modelBuilder.Entity<TblDokumentiDetailsInfo>(entity =>
        {
            entity.ToTable("tblDokumentiDetailsInfo");

            entity.HasIndex(e => e.TblDokumentId, "FK__tblDokume__tblDo__408F9238");

            entity.Property(e => e.DateTimeCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TblDokumentId).HasColumnName("tblDokumentId");
            entity.Property(e => e.WaterMeter).HasMaxLength(50);
            entity.Property(e => e.WaterMeterNew).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WaterMeterOld).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.TblDokument).WithMany(p => p.TblDokumentiDetailsInfos)
                .HasForeignKey(d => d.TblDokumentId)
                .HasConstraintName("FK__tblDokume__tblDo__408F9238");
        });

        modelBuilder.Entity<TblDokumentiDetailsInfoHvac>(entity =>
        {
            entity.ToTable("tblDokumentiDetailsInfoHvac");

            entity.HasIndex(e => e.TblDokumentId, "FK__tblDokume__tblDo__3F9B6DFF");

            entity.HasIndex(e => e.TblDokumentId, "FK__tblDokume__tblDo__408F9238");

            entity.Property(e => e.Capacity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DateTimeCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HighRun).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HighRunTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LowRun).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LowRunTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(50);
            entity.Property(e => e.TblDokumentId).HasColumnName("tblDokumentId");

            entity.HasOne(d => d.TblDokument).WithMany(p => p.TblDokumentiDetailsInfoHvacs)
                .HasForeignKey(d => d.TblDokumentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__tblDokume__tblDo__3F9B6DFF");
        });

        modelBuilder.Entity<TblDokumentiTemplate>(entity =>
        {
            entity.ToTable("tblDokumentiTemplate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rabat1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
            entity.Property(e => e.TblNormativId).HasColumnName("tblNormativID");
            entity.Property(e => e.TipNaDokumentId).HasColumnName("TipNaDokumentID");
        });

        modelBuilder.Entity<TblEdinecniMerki>(entity =>
        {
            entity.ToTable("tblEdinecniMerki");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Kratenka).HasMaxLength(3);
            entity.Property(e => e.Naziv).HasMaxLength(50);
        });

        modelBuilder.Entity<TblElektronskoPracanje>(entity =>
        {
            entity.ToTable("tblElektronskoPracanje");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.DatumNaKnizenje).HasColumnType("datetime");
            entity.Property(e => e.DatumNaPoslednaIzmenaNaStatus).HasColumnType("datetime");
            entity.Property(e => e.DatumNaPotvrda).HasColumnType("datetime");
            entity.Property(e => e.DatumNaPracanje).HasColumnType("datetime");
            entity.Property(e => e.DokumentId).HasColumnName("DokumentID");
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.Odobjekt).HasColumnName("ODObjekt");
            entity.Property(e => e.PratenDo)
                .HasMaxLength(150)
                .HasColumnName("PratenDO");
            entity.Property(e => e.PratenOd)
                .HasMaxLength(100)
                .HasColumnName("PratenOD");
            entity.Property(e => e.Zabeleska).HasMaxLength(150);
        });

        modelBuilder.Entity<TblFaktura>(entity =>
        {
            entity.ToTable("tblFaktura");

            entity.HasIndex(e => e.TblBankaId, "FK_tblFaktura_tblBanki");

            entity.HasIndex(e => e.TblPartnerId, "FK_tblFaktura_tblPartneri");

            entity.HasIndex(e => e.TblUserId, "FK_tblFaktura_tblUsers");

            entity.HasIndex(e => e.TblZiroSmetkaId, "FK_tblFaktura_tblZiroSmetki");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.KodNaDokument).HasMaxLength(70);
            entity.Property(e => e.ListaNaIspratnici).HasMaxLength(150);
            entity.Property(e => e.TblBankaId).HasColumnName("tblBankaID");
            entity.Property(e => e.TblPartnerId).HasColumnName("tblPartnerID");
            entity.Property(e => e.TblUserId).HasColumnName("tblUserID");
            entity.Property(e => e.TblZiroSmetkaId).HasColumnName("tblZiroSmetkaID");

            entity.HasOne(d => d.TblBanka).WithMany(p => p.TblFakturas)
                .HasForeignKey(d => d.TblBankaId)
                .HasConstraintName("FK_tblFaktura_tblBanki");

            entity.HasOne(d => d.TblPartner).WithMany(p => p.TblFakturas)
                .HasForeignKey(d => d.TblPartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFaktura_tblPartneri");

            entity.HasOne(d => d.TblUser).WithMany(p => p.TblFakturas)
                .HasForeignKey(d => d.TblUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFaktura_tblUsers");

            entity.HasOne(d => d.TblZiroSmetka).WithMany(p => p.TblFakturas)
                .HasForeignKey(d => d.TblZiroSmetkaId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tblFaktura_tblZiroSmetki");
        });

        modelBuilder.Entity<TblFakturaStavki>(entity =>
        {
            entity.ToTable("tblFakturaStavki");

            entity.HasIndex(e => e.TblFakturaId, "FK_tblFakturaStavki_tblFaktura");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rabat1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rabat2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rabat3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
            entity.Property(e => e.TblFakturaId).HasColumnName("tblFakturaID");

            entity.HasOne(d => d.TblFaktura).WithMany(p => p.TblFakturaStavkis)
                .HasForeignKey(d => d.TblFakturaId)
                .HasConstraintName("FK_tblFakturaStavki_tblFaktura");
        });

        modelBuilder.Entity<TblFirma>(entity =>
        {
            entity.ToTable("tblFirma");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adresa).HasMaxLength(50);
            entity.Property(e => e.BankaDeponent).HasMaxLength(50);
            entity.Property(e => e.DanocenBroj).HasMaxLength(50);
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("EMail");
            entity.Property(e => e.Faks).HasMaxLength(50);
            entity.Property(e => e.Grad).HasMaxLength(50);
            entity.Property(e => e.Image1).HasColumnType("image");
            entity.Property(e => e.Image2).HasColumnType("image");
            entity.Property(e => e.Image3).HasColumnType("image");
            entity.Property(e => e.ImeNaFirma).HasMaxLength(50);
            entity.Property(e => e.MaticenBroj).HasMaxLength(50);
            entity.Property(e => e.PostenskiBroj).HasMaxLength(50);
            entity.Property(e => e.Telefon).HasMaxLength(50);
            entity.Property(e => e.TxIdfirma)
                .HasMaxLength(40)
                .HasColumnName("txIDFirma");
            entity.Property(e => e.ZiroSmetka).HasMaxLength(20);
        });

        modelBuilder.Entity<TblFiskalniSmetki>(entity =>
        {
            entity.ToTable("tblFiskalniSmetki");

            entity.HasIndex(e => e.TblSmetkaId, "FK_tblFiskalniSmetki_tblSmetka");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Datum)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.KodNaDokument).HasMaxLength(70);
            entity.Property(e => e.TblSmetkaId).HasColumnName("tblSmetkaID");

            entity.HasOne(d => d.TblSmetka).WithMany(p => p.TblFiskalniSmetkis)
                .HasForeignKey(d => d.TblSmetkaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFiskalniSmetki_tblSmetka");
        });

        modelBuilder.Entity<TblGrupaNaArtikli>(entity =>
        {
            entity.ToTable("tblGrupaNaArtikli");

            entity.HasIndex(e => e.FirmaId, "FK_tblGrupaNaArtikli_tblFirma");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Image).HasMaxLength(250);
            entity.Property(e => e.Naziv).HasMaxLength(50);
            entity.Property(e => e.Sifra).HasMaxLength(20);

            entity.HasOne(d => d.Firma).WithMany(p => p.TblGrupaNaArtiklis)
                .HasForeignKey(d => d.FirmaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblGrupaNaArtikli_tblFirma");
        });

        modelBuilder.Entity<TblIzvodi>(entity =>
        {
            entity.ToTable("tblIzvodi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BrojNaIzvod).HasMaxLength(50);
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.DatumNaIzvod).HasColumnType("datetime");
            entity.Property(e => e.Smetka).HasMaxLength(50);
            entity.Property(e => e.Zabeleska).HasMaxLength(250);
        });

        modelBuilder.Entity<TblIzvodiStavki>(entity =>
        {
            entity.ToTable("tblIzvodiStavki");

            entity.HasIndex(e => e.TblIzvodiId, "FK_tblIzvodiStavki_tblIzvodi");

            entity.HasIndex(e => e.PartnerId, "FK_tblIzvodiStavki_tblPartneri");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BrojNaDokument).HasMaxLength(150);
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.DokumentId).HasColumnName("DokumentID");
            entity.Property(e => e.Dolzi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FakturaId).HasColumnName("FakturaID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Pobaruva).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriemId).HasColumnName("PriemID");
            entity.Property(e => e.TblIzvodiId).HasColumnName("tblIzvodiID");

            entity.HasOne(d => d.Partner).WithMany(p => p.TblIzvodiStavkis)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblIzvodiStavki_tblPartneri");

            entity.HasOne(d => d.TblIzvodi).WithMany(p => p.TblIzvodiStavkis)
                .HasForeignKey(d => d.TblIzvodiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblIzvodiStavki_tblIzvodi");
        });

        modelBuilder.Entity<TblKnizenjeM>(entity =>
        {
            entity.ToTable("tblKnizenjeM");

            entity.HasIndex(e => e.TblDokumentId, "FK_tblKnizenjeM_tblDokumenti");

            entity.HasIndex(e => e.TblFakturaId, "FK_tblKnizenjeM_tblFaktura");

            entity.HasIndex(e => e.TblPriemId, "FK_tblKnizenjeM_tblPriem");

            entity.HasIndex(e => e.TblSmetkaId, "FK_tblKnizenjeM_tblSmetka");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.DatumNaKnizenje).HasColumnType("datetime");
            entity.Property(e => e.DatumNaKraj).HasColumnType("datetime");
            entity.Property(e => e.DatumNaPocetok).HasColumnType("datetime");
            entity.Property(e => e.EdinecnaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IznosBezDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IznosBezDDV");
            entity.Property(e => e.IznosDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IznosDDV");
            entity.Property(e => e.IznosNaRabat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IznosSoDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IznosSoDDV");
            entity.Property(e => e.KodNaDokument).HasMaxLength(70);
            entity.Property(e => e.Kolicina).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.NabavnaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProdaznaCenaSoRabat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rabat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
            entity.Property(e => e.TblDdvid).HasColumnName("tblDDVID");
            entity.Property(e => e.TblDokumentId).HasColumnName("tblDokumentID");
            entity.Property(e => e.TblEdinecnaMerka).HasColumnName("tblEdinecnaMerka");
            entity.Property(e => e.TblFakturaId).HasColumnName("tblFakturaID");
            entity.Property(e => e.TblNormativId).HasColumnName("tblNormativID");
            entity.Property(e => e.TblObjektiId).HasColumnName("tblObjektiID");
            entity.Property(e => e.TblObjektiIddo).HasColumnName("tblObjektiIDDO");
            entity.Property(e => e.TblObjektiIdod).HasColumnName("tblObjektiIDOD");
            entity.Property(e => e.TblPriemId).HasColumnName("tblPriemID");
            entity.Property(e => e.TblSmetkaId).HasColumnName("tblSmetkaID");
            entity.Property(e => e.TblUserId).HasColumnName("tblUserID");
            entity.Property(e => e.TblValutaId).HasColumnName("tblValutaID");
            entity.Property(e => e.TipNaArtikal).HasColumnName("tipNaArtikal");
            entity.Property(e => e.TipNaKnizenje).HasColumnName("tipNaKnizenje");

            entity.HasOne(d => d.TblDokument).WithMany(p => p.TblKnizenjeMs)
                .HasForeignKey(d => d.TblDokumentId)
                .HasConstraintName("FK_tblKnizenjeM_tblDokumenti");

            entity.HasOne(d => d.TblFaktura).WithMany(p => p.TblKnizenjeMs)
                .HasForeignKey(d => d.TblFakturaId)
                .HasConstraintName("FK_tblKnizenjeM_tblFaktura");

            entity.HasOne(d => d.TblPriem).WithMany(p => p.TblKnizenjeMs)
                .HasForeignKey(d => d.TblPriemId)
                .HasConstraintName("FK_tblKnizenjeM_tblPriem");

            entity.HasOne(d => d.TblSmetka).WithMany(p => p.TblKnizenjeMs)
                .HasForeignKey(d => d.TblSmetkaId)
                .HasConstraintName("FK_tblKnizenjeM_tblSmetka");
        });

        modelBuilder.Entity<TblKursnaListum>(entity =>
        {
            entity.ToTable("tblKursnaLista");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Kurs).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.TblValutaId).HasColumnName("tblValutaID");
        });

        modelBuilder.Entity<TblLog>(entity =>
        {
            entity.ToTable("_tblLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DatumIvreme)
                .HasColumnType("datetime")
                .HasColumnName("DatumIVreme");

            entity.HasOne(d => d.SesijaNavigation).WithMany(p => p.TblLogs)
                .HasPrincipalKey(p => p.Sesija)
                .HasForeignKey(d => d.Sesija)
                .HasConstraintName("FK__tblLog__tblSesija");
        });

        modelBuilder.Entity<TblNalog>(entity =>
        {
            entity.ToTable("tblNalog");

            entity.HasIndex(e => e.FirmaId, "FK_tblNalog_tblFirma");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.DatumKraj).HasColumnType("datetime");
            entity.Property(e => e.DatumPocetok)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.SmenaId).HasColumnName("Smena_ID");
            entity.Property(e => e.SmetkaId).HasColumnName("SmetkaID");
            entity.Property(e => e.Zabeleska)
                .HasMaxLength(350)
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Firma).WithMany(p => p.TblNalogs)
                .HasForeignKey(d => d.FirmaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblNalog_tblFirma");
        });

        modelBuilder.Entity<TblNalogIzmenetum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblNalogIzmeneta");

            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.DatumKraj).HasColumnType("datetime");
            entity.Property(e => e.DatumNaIzmena).HasColumnType("datetime");
            entity.Property(e => e.DatumPocetok).HasColumnType("datetime");
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.SmenaId).HasColumnName("Smena_ID");
            entity.Property(e => e.SmetkaId).HasColumnName("SmetkaID");
            entity.Property(e => e.Zabeleska).HasMaxLength(350);
        });

        modelBuilder.Entity<TblNalogStavki>(entity =>
        {
            entity.ToTable("tblNalogStavki");

            entity.HasIndex(e => e.TblArtikalId, "FK_tblNalogStavki_tblArtikal");

            entity.HasIndex(e => e.TblNalogId, "FK_tblNalogStavki_tblNalog");

            entity.HasIndex(e => e.TblNomativId, "FK_tblNalogStavki_tblNormativ");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Kolicina).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Rabat1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
            entity.Property(e => e.TblNalogId).HasColumnName("tblNalogID");
            entity.Property(e => e.TblNomativId).HasColumnName("tblNomativID");

            entity.HasOne(d => d.TblArtikal).WithMany(p => p.TblNalogStavkis)
                .HasForeignKey(d => d.TblArtikalId)
                .HasConstraintName("FK_tblNalogStavki_tblArtikal");

            entity.HasOne(d => d.TblNalog).WithMany(p => p.TblNalogStavkis)
                .HasForeignKey(d => d.TblNalogId)
                .HasConstraintName("FK_tblNalogStavki_tblNalog");

            entity.HasOne(d => d.TblNomativ).WithMany(p => p.TblNalogStavkis)
                .HasForeignKey(d => d.TblNomativId)
                .HasConstraintName("FK_tblNalogStavki_tblNormativ");
        });

        modelBuilder.Entity<TblNalogStavkiIzmenetum>(entity =>
        {
            entity.ToTable("tblNalogStavkiIzmeneta");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Kolicina).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Rabat1).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
            entity.Property(e => e.TblNalogIzmenetaId).HasColumnName("tblNalogIzmenetaID");
            entity.Property(e => e.TblNomativId).HasColumnName("tblNomativID");
        });

        modelBuilder.Entity<TblNaracki>(entity =>
        {
            entity.ToTable("tblNaracki");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.DatumNaNaracka).HasColumnType("datetime");
            entity.Property(e => e.Ime).HasMaxLength(50);
            entity.Property(e => e.KodNaDokument).HasMaxLength(70);
            entity.Property(e => e.Kontakt).HasMaxLength(50);
            entity.Property(e => e.OdObjekt).HasMaxLength(50);
        });

        modelBuilder.Entity<TblNetworkPc>(entity =>
        {
            entity.ToTable("tblNetworkPC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientPassword).HasMaxLength(50);
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Grupa).HasMaxLength(50);
            entity.Property(e => e.HostName).HasMaxLength(50);
            entity.Property(e => e.Ipaddres)
                .HasMaxLength(25)
                .HasColumnName("IPAddres");
            entity.Property(e => e.Pcname)
                .HasMaxLength(50)
                .HasColumnName("PCName");
            entity.Property(e => e.RPassWord)
                .HasMaxLength(50)
                .HasColumnName("R_PassWord");
            entity.Property(e => e.RUserName)
                .HasMaxLength(50)
                .HasColumnName("R_UserName");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
        });

        modelBuilder.Entity<TblNetworkPclog>(entity =>
        {
            entity.ToTable("tblNetworkPCLOG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Akcija).HasMaxLength(50);
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Datum).HasColumnType("datetime");
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.TblNetworkPcid).HasColumnName("tblNetworkPCID");
        });

        modelBuilder.Entity<TblNormativ>(entity =>
        {
            entity.ToTable("tblNormativ");

            entity.HasIndex(e => e.FirmaId, "FK_tblNormativ_tblFirma");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AltNaziv).HasMaxLength(150);
            entity.Property(e => e.AltNaziv2).HasMaxLength(150);
            entity.Property(e => e.Cena).HasColumnType("decimal(9, 3)");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Image).HasMaxLength(250);
            entity.Property(e => e.KlucniZborovi).HasMaxLength(300);
            entity.Property(e => e.Naziv).HasMaxLength(50);
            entity.Property(e => e.PodgrupaId).HasColumnName("PodgrupaID");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.TblDdvstavkaId).HasColumnName("tblDDVStavkaID");

            entity.HasOne(d => d.Firma).WithMany(p => p.TblNormativs)
                .HasForeignKey(d => d.FirmaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblNormativ_tblFirma");
        });

        modelBuilder.Entity<TblNormativStavki>(entity =>
        {
            entity.ToTable("tblNormativStavki");

            entity.HasIndex(e => e.TblArtikalId, "FK_tblNormativStavki_tblArtikal");

            entity.HasIndex(e => e.TblNormativId, "FK_tblNormativStavki_tblNormativ");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Kolicina).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
            entity.Property(e => e.TblNormativId).HasColumnName("tblNormativID");

            entity.HasOne(d => d.TblArtikal).WithMany(p => p.TblNormativStavkis)
                .HasForeignKey(d => d.TblArtikalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblNormativStavki_tblArtikal");

            entity.HasOne(d => d.TblNormativ).WithMany(p => p.TblNormativStavkis)
                .HasForeignKey(d => d.TblNormativId)
                .HasConstraintName("FK_tblNormativStavki_tblNormativ");
        });

        modelBuilder.Entity<TblObjekti>(entity =>
        {
            entity.ToTable("tblObjekti");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Naziv).HasMaxLength(50);
            entity.Property(e => e.Sifra).HasMaxLength(20);
        });

        modelBuilder.Entity<TblPartneri>(entity =>
        {
            entity.ToTable("tblPartneri");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adresa).HasMaxLength(250);
            entity.Property(e => e.AltSifra).HasMaxLength(50);
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Edb)
                .HasMaxLength(18)
                .HasColumnName("EDB");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Mesto).HasMaxLength(150);
            entity.Property(e => e.Naziv).HasMaxLength(350);
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.TblPresmetkovnaEdinicaId).HasColumnName("tblPresmetkovnaEdinicaID");
            entity.Property(e => e.Telefoni).HasMaxLength(270);
        });

        modelBuilder.Entity<TblPodgrupaId>(entity =>
        {
            entity.ToTable("tblPodgrupaID");

            entity.HasIndex(e => e.GrupaId, "FK_tblPodgrupaID_tblGrupaNaArtikli");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.GrupaId).HasColumnName("GrupaID");
            entity.Property(e => e.Image).HasMaxLength(250);
            entity.Property(e => e.Naziv).HasMaxLength(50);

            entity.HasOne(d => d.Grupa).WithMany(p => p.TblPodgrupaIds)
                .HasForeignKey(d => d.GrupaId)
                .HasConstraintName("FK_tblPodgrupaID_tblGrupaNaArtikli");
        });

        modelBuilder.Entity<TblPresmetkovniEdinici>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblPresmetkovniEdinici_1");

            entity.ToTable("tblPresmetkovniEdinici");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Naziv).HasMaxLength(50);
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.Zabeleska).HasMaxLength(100);
        });

        modelBuilder.Entity<TblPrevodi>(entity =>
        {
            entity.ToTable("tblPrevodi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Al)
                .HasMaxLength(250)
                .HasColumnName("AL");
            entity.Property(e => e.En)
                .HasMaxLength(250)
                .HasColumnName("EN");
            entity.Property(e => e.KlucenZbor).HasMaxLength(150);
            entity.Property(e => e.Mk)
                .HasMaxLength(250)
                .HasColumnName("MK");
            entity.Property(e => e.Sr)
                .HasMaxLength(250)
                .HasColumnName("SR");
        });

        modelBuilder.Entity<TblPriem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Priem");

            entity.ToTable("tblPriem");

            entity.HasIndex(e => e.TblPartnerId, "FK_tblPriem_tblPartneri");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.DatumNaDospeanost).HasColumnType("datetime");
            entity.Property(e => e.DatumNaKreiranjeNaPriem).HasColumnType("datetime");
            entity.Property(e => e.IspratnicaFakturaBroj).HasMaxLength(50);
            entity.Property(e => e.IspratnicaFakturaDatum).HasColumnType("datetime");
            entity.Property(e => e.KodNaDokument).HasMaxLength(70);
            entity.Property(e => e.ObjektId).HasColumnName("ObjektID");
            entity.Property(e => e.PriemDatum).HasColumnType("datetime");
            entity.Property(e => e.TblPartnerId).HasColumnName("tblPartnerID");
            entity.Property(e => e.TblUserId).HasColumnName("tblUserID");
            entity.Property(e => e.VkupenIznos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Zabeleska).HasMaxLength(50);

            entity.HasOne(d => d.TblPartner).WithMany(p => p.TblPriems)
                .HasForeignKey(d => d.TblPartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPriem_tblPartneri");
        });

        modelBuilder.Entity<TblPriemStavki>(entity =>
        {
            entity.ToTable("tblPriemStavki");

            entity.HasIndex(e => e.TblArtikalId, "FK_tblPriemStavki_tblArtikal");

            entity.HasIndex(e => e.TblPriemId, "FK_tblPriemStavki_tblPriem");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NabavnaCenaBezDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NabavnaCenaBezDDV");
            entity.Property(e => e.NabavnaCenaSoDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NabavnaCenaSoDDV");
            entity.Property(e => e.Rabat1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rabat2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rabat3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
            entity.Property(e => e.TblPriemId).HasColumnName("tblPriemID");

            entity.HasOne(d => d.TblArtikal).WithMany(p => p.TblPriemStavkis)
                .HasForeignKey(d => d.TblArtikalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPriemStavki_tblArtikal");

            entity.HasOne(d => d.TblPriem).WithMany(p => p.TblPriemStavkis)
                .HasForeignKey(d => d.TblPriemId)
                .HasConstraintName("FK_tblPriemStavki_tblPriem");
        });

        modelBuilder.Entity<TblSesija>(entity =>
        {
            entity.ToTable("_tblSesija");

            entity.HasIndex(e => e.Sesija, "IX__tblSesija").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FirmaId)
                .HasDefaultValue(1)
                .HasColumnName("FirmaID");
            entity.Property(e => e.Pocnata)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Sesija).HasDefaultValueSql("(newid())");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Zavrsena).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblSmetka>(entity =>
        {
            entity.ToTable("tblSmetka");

            entity.HasIndex(e => e.FirmaId, "FK_tblSmetka_tblFirma");

            entity.HasIndex(e => e.ObjektId, "FK_tblSmetka_tblObjekti");

            entity.HasIndex(e => e.TblPartnerId, "FK_tblSmetka_tblPartneri");

            entity.HasIndex(e => e.TblUserId, "FK_tblSmetka_tblUsers");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.DatumKraj).HasColumnType("datetime");
            entity.Property(e => e.DatumPocetok)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.KodNaDokument).HasMaxLength(70);
            entity.Property(e => e.ObjektId).HasColumnName("ObjektID");
            entity.Property(e => e.ProcentNaPopust).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SmenaId).HasColumnName("Smena_ID");
            entity.Property(e => e.TblPartnerId).HasColumnName("tblPartnerID");
            entity.Property(e => e.TblUserId).HasColumnName("tblUserID");
            entity.Property(e => e.Zatvorena).HasDefaultValue(false);

            entity.HasOne(d => d.Firma).WithMany(p => p.TblSmetkas)
                .HasForeignKey(d => d.FirmaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSmetka_tblFirma");

            entity.HasOne(d => d.Objekt).WithMany(p => p.TblSmetkas)
                .HasForeignKey(d => d.ObjektId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSmetka_tblObjekti");

            entity.HasOne(d => d.TblPartner).WithMany(p => p.TblSmetkas)
                .HasForeignKey(d => d.TblPartnerId)
                .HasConstraintName("FK_tblSmetka_tblPartneri");

            entity.HasOne(d => d.TblUser).WithMany(p => p.TblSmetkas)
                .HasForeignKey(d => d.TblUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSmetka_tblUsers");
        });

        modelBuilder.Entity<TblSmetkaIzmenetum>(entity =>
        {
            entity.ToTable("tblSmetkaIzmeneta");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.DatumKraj).HasColumnType("datetime");
            entity.Property(e => e.DatumNaIzmena)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DatumPocetok).HasColumnType("datetime");
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.ObjektId).HasColumnName("ObjektID");
            entity.Property(e => e.SmenaId).HasColumnName("Smena_ID");
            entity.Property(e => e.TblPartnerId).HasColumnName("tblPartnerID");
            entity.Property(e => e.TblSmetkaIzmenetaId).HasColumnName("tblSmetkaIzmenetaID");
            entity.Property(e => e.TblUserId).HasColumnName("tblUserID");
        });

        modelBuilder.Entity<TblSmetkaStavki>(entity =>
        {
            entity.ToTable("tblSmetkaStavki");

            entity.HasIndex(e => e.TblNalogId, "FK_tblSmetkaStavki_tblNalog");

            entity.HasIndex(e => e.TblSmetkaId, "FK_tblSmetkaStavki_tblSmetka");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.TblNalogId).HasColumnName("tblNalogID");
            entity.Property(e => e.TblSmetkaId).HasColumnName("tblSmetkaID");

            entity.HasOne(d => d.TblNalog).WithMany(p => p.TblSmetkaStavkis)
                .HasForeignKey(d => d.TblNalogId)
                .HasConstraintName("FK_tblSmetkaStavki_tblNalog");

            entity.HasOne(d => d.TblSmetka).WithMany(p => p.TblSmetkaStavkis)
                .HasForeignKey(d => d.TblSmetkaId)
                .HasConstraintName("FK_tblSmetkaStavki_tblSmetka");
        });

        modelBuilder.Entity<TblSmetkaStavkiIzmenetum>(entity =>
        {
            entity.ToTable("tblSmetkaStavkiIzmeneta");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.DatumNaIzmena).HasColumnType("datetime");
            entity.Property(e => e.TblNalogId).HasColumnName("tblNalogID");
            entity.Property(e => e.TblSmetkaId).HasColumnName("tblSmetkaID");
            entity.Property(e => e.TblSmetkaIzmenetaId).HasColumnName("tblSmetkaIzmenetaID");
        });

        modelBuilder.Entity<TblTipNaDokument>(entity =>
        {
            entity.ToTable("tblTipNaDokument");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Naslov).HasMaxLength(200);
            entity.Property(e => e.Naziv).HasMaxLength(50);
            entity.Property(e => e.ReportFileName).HasMaxLength(70);
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.ToTable("tblUsers");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(25);
            entity.Property(e => e.Status).HasDefaultValue(0);
            entity.Property(e => e.TblObjektId).HasColumnName("tblObjektId");
            entity.Property(e => e.UserName).HasMaxLength(25);
        });

        modelBuilder.Entity<TblUserConfig>(entity =>
        {
            entity.ToTable("tblUserConfigs");

            entity.HasIndex(e => e.UserId, "FK_tblUserConfigs_tblUsers");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.DateOfCreation)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ObjectName).HasMaxLength(300);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.TblUserConfigs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblUserConfigs_tblUsers");
        });

        modelBuilder.Entity<TblValuti>(entity =>
        {
            entity.ToTable("tblValuti");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Kratenka)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Opis).HasMaxLength(50);
        });

        modelBuilder.Entity<TblZabeleshki>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblZabeleshki");

            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Tip).HasMaxLength(512);
            entity.Property(e => e.Zabeleshka).HasMaxLength(512);
        });

        modelBuilder.Entity<TblZalihaNaArtikli>(entity =>
        {
            entity.ToTable("tblZalihaNaArtikli");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Datum)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IdnaDokument).HasColumnName("IDNaDokument");
            entity.Property(e => e.Izlez).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
            entity.Property(e => e.TipDokument).HasColumnName("TIpDokument");
            entity.Property(e => e.Vlez).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblZiroSmetki>(entity =>
        {
            entity.ToTable("tblZiroSmetki");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TblBankaId).HasColumnName("tblBankaID");
            entity.Property(e => e.TblPartnerId).HasColumnName("tblPartnerID");
            entity.Property(e => e.ZiroSmetka).HasMaxLength(15);
        });

        modelBuilder.Entity<ViewArtikalInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewArtikalInfo");

            entity.Property(e => e.AltSifra).HasMaxLength(50);
            entity.Property(e => e.Ddvprocent)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("DDVProcent");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Kratenka).HasMaxLength(3);
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.PlanskaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProdaznaCenaBezDdv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ProdaznaCenaBezDDV");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.TblDdvstavkaId).HasColumnName("tblDDVStavkaID");
            entity.Property(e => e.TblEdinecniMerkiId).HasColumnName("tblEdinecniMerkiID");
        });

        modelBuilder.Entity<ViewArtikaliNormativi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewArtikaliNormativi");

            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(250);
            entity.Property(e => e.KlucniZborovi).HasMaxLength(300);
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.Normativ)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PodgrupaId).HasColumnName("PodgrupaID");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(19, 3)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
        });

        modelBuilder.Entity<ViewArtikli>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewArtikli");

            entity.Property(e => e.AltNaziv).HasMaxLength(150);
            entity.Property(e => e.AltNaziv2).HasMaxLength(150);
            entity.Property(e => e.AltSifra).HasMaxLength(50);
            entity.Property(e => e.Barkod1).HasMaxLength(50);
            entity.Property(e => e.Barkod2).HasMaxLength(50);
            entity.Property(e => e.Edm)
                .HasMaxLength(3)
                .HasColumnName("EDM");
            entity.Property(e => e.Edmizlez).HasColumnName("EDMIzlez");
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.GrupaArtikal).HasMaxLength(50);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(250);
            entity.Property(e => e.KolicinaT).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.MinimalnaKolicinaNaZaliha).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.NabavnaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Naziv).HasMaxLength(20);
            entity.Property(e => e.NazivArtikal).HasMaxLength(150);
            entity.Property(e => e.PodGrupaArtikal).HasMaxLength(50);
            entity.Property(e => e.Procent).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
        });

        modelBuilder.Entity<ViewArtikliVoSmetka>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewArtikliVoSmetka");

            entity.Property(e => e.Iznos).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Kolicina).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(19, 3)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.SmetkaId).HasColumnName("SmetkaID");
        });

        modelBuilder.Entity<ViewArtikliVoSmetkaIzmenetum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewArtikliVoSmetkaIzmeneta");

            entity.Property(e => e.Iznos).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Kolicina).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(19, 3)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.SmetkaId).HasColumnName("SmetkaID");
        });

        modelBuilder.Entity<ViewArtikliVoSmetkaKasa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewArtikliVoSmetkaKASA");

            entity.Property(e => e.ArtikalId).HasColumnName("ArtikalID");
            entity.Property(e => e.CenaBezDdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("CenaBezDDV");
            entity.Property(e => e.CenaSoRabatIddv).HasColumnType("decimal(38, 7)");
            entity.Property(e => e.Ddvprocent)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("DDVProcent");
            entity.Property(e => e.Iznos).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.IznosBezDdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("IznosBezDDV");
            entity.Property(e => e.Kolicina).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.NalogId).HasColumnName("NalogID");
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.PresmetanDdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("PresmetanDDV");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(19, 3)");
            entity.Property(e => e.Rabat).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.Sifra2).HasMaxLength(50);
            entity.Property(e => e.SmetkaId).HasColumnName("SmetkaID");
            entity.Property(e => e.Zabeleska).HasMaxLength(350);
        });

        modelBuilder.Entity<ViewArtikliVoSmetkaKasabezZaokruzuenje>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewArtikliVoSmetkaKASAbezZaokruzuenje");

            entity.Property(e => e.ArtikalId).HasColumnName("ArtikalID");
            entity.Property(e => e.CenaBezDdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("CenaBezDDV");
            entity.Property(e => e.CenaSoRabatIddv).HasColumnType("decimal(38, 7)");
            entity.Property(e => e.Ddvprocent)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("DDVProcent");
            entity.Property(e => e.Iznos).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.IznosBezDdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("IznosBezDDV");
            entity.Property(e => e.Kolicina).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.NalogId).HasColumnName("NalogID");
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.PresmetanDdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("PresmetanDDV");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(19, 3)");
            entity.Property(e => e.Rabat).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.Sifra2).HasMaxLength(50);
            entity.Property(e => e.SmetkaId).HasColumnName("SmetkaID");
            entity.Property(e => e.Zabeleska).HasMaxLength(350);
        });

        modelBuilder.Entity<ViewDokumenti>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewDokumenti");

            entity.Property(e => e.BrojChar).HasMaxLength(15);
            entity.Property(e => e.BrojNaDokument).HasMaxLength(50);
            entity.Property(e => e.DatumNaValuta).HasColumnType("datetime");
            entity.Property(e => e.DatumPeriod).HasColumnType("datetime");
            entity.Property(e => e.Ddviznos)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("DDVIznos");
            entity.Property(e => e.Ddviznos18)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("DDVIznos18");
            entity.Property(e => e.Ddviznos5)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("DDVIznos5");
            entity.Property(e => e.DoObjektId).HasColumnName("DoObjektID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IznosBezDdv)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("IznosBezDDV");
            entity.Property(e => e.IznosSoDdv)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("IznosSoDDV");
            entity.Property(e => e.KodNaDokument).HasMaxLength(70);
            entity.Property(e => e.NazivPartner).HasMaxLength(350);
            entity.Property(e => e.Notes).HasMaxLength(400);
            entity.Property(e => e.ObejektDo)
                .HasMaxLength(50)
                .HasColumnName("ObejektDO");
            entity.Property(e => e.ObjektOd)
                .HasMaxLength(50)
                .HasColumnName("ObjektOD");
            entity.Property(e => e.OdObjektId).HasColumnName("OdObjektID");
            entity.Property(e => e.SifraPartner).HasMaxLength(20);
            entity.Property(e => e.TblPartnerId).HasColumnName("tblPartnerID");
            entity.Property(e => e.TipDokumentId).HasColumnName("TipDokumentID");
            entity.Property(e => e.TipNaDokument).HasMaxLength(50);
            entity.Property(e => e.UniqueIdPlacanje).HasMaxLength(20);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewDokumentiStavki>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewDokumentiStavki");

            entity.Property(e => e.AltSifra).HasMaxLength(50);
            entity.Property(e => e.ArikalNaziv).HasMaxLength(150);
            entity.Property(e => e.ArtikalId).HasColumnName("ArtikalID");
            entity.Property(e => e.Cena).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CenaBezDdv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CenaBezDDV");
            entity.Property(e => e.CenaSoRabatIddv).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ddviznos)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DDVIznos");
            entity.Property(e => e.Ddvstapka)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("DDVStapka");
            entity.Property(e => e.EdinecnaMerka).HasMaxLength(3);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsNormativ).HasColumnName("isNormativ");
            entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IznosBezDdv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IznosBezDDV");
            entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NabavnaVrednostBezDdviznos)
                .HasColumnType("decimal(37, 4)")
                .HasColumnName("NabavnaVrednostBezDDVIznos");
            entity.Property(e => e.NazivNaProdukt).HasMaxLength(150);
            entity.Property(e => e.NormativId).HasColumnName("NormativID");
            entity.Property(e => e.NormativNaziv).HasMaxLength(50);
            entity.Property(e => e.NormativSifra).HasMaxLength(20);
            entity.Property(e => e.NotesBroj).HasMaxLength(150);
            entity.Property(e => e.NotesRef).HasColumnName("NotesREF");
            entity.Property(e => e.NotesText).HasMaxLength(350);
            entity.Property(e => e.PlanskaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PlanskaVrednost).HasColumnType("decimal(37, 4)");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProdaznaVrednostSoDdv)
                .HasColumnType("decimal(37, 4)")
                .HasColumnName("ProdaznaVrednostSoDDV");
            entity.Property(e => e.ProsecnaNabavnaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProsecnaNabavnaCenaBezDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ProsecnaNabavnaCenaBezDDV");
            entity.Property(e => e.Rabat1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TblDokumentId).HasColumnName("tblDokumentID");
            entity.Property(e => e.TipNaDokumentId).HasColumnName("TipNaDokumentID");
            entity.Property(e => e.TipNadokument).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewDokumentiZaPlakjanaOdPartnerPoDokument>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewDokumentiZaPlakjanaOdPartnerPoDokument");

            entity.Property(e => e.Datum).HasColumnType("datetime");
            entity.Property(e => e.DocNaziv).HasMaxLength(64);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IznosNaDokument).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.PlatenoZaDokument).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PreostanatoZaPlacanje).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TblPartnerId).HasColumnName("tblPartnerID");
        });

        modelBuilder.Entity<ViewDokumentiZaPlakjanje>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewDokumentiZaPlakjanje");

            entity.Property(e => e.Broj).HasMaxLength(50);
            entity.Property(e => e.Datum).HasColumnType("datetime");
            entity.Property(e => e.DocNaziv).HasMaxLength(465);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IznosNaDokument).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.PlatenoZaDokument).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PreostanatoZaPlacanje).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SifraPartner).HasMaxLength(20);
            entity.Property(e => e.TblPartnerId).HasColumnName("tblPartnerID");
        });

        modelBuilder.Entity<ViewDospeaniFakturi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewDospeaniFakturi");

            entity.Property(e => e.BrojNaFakturaSporedPartner).HasMaxLength(50);
            entity.Property(e => e.DocNaziv).HasMaxLength(35);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IznosNaDokument).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.NazivPartner).HasMaxLength(350);
            entity.Property(e => e.PlatenoZaDokument).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PreostanatoZaPlacanje).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SifraPartner).HasMaxLength(20);
            entity.Property(e => e.TblPartnerId).HasColumnName("tblPartnerID");
        });

        modelBuilder.Entity<ViewFakturi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewFakturi");

            entity.Property(e => e.Banka).HasMaxLength(100);
            entity.Property(e => e.BrojNaFakturaSporedPartner).HasMaxLength(50);
            entity.Property(e => e.Ddv18)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("DDV18");
            entity.Property(e => e.Ddv5)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("DDV5");
            entity.Property(e => e.FakturiranDdv)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("FakturiranDDV");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Iznos).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.IznosBezDdv)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("IznosBezDDV");
            entity.Property(e => e.KodNaDokument).HasMaxLength(70);
            entity.Property(e => e.ListaNaIspratnici).HasMaxLength(150);
            entity.Property(e => e.Partner).HasMaxLength(350);
            entity.Property(e => e.SifraPartner).HasMaxLength(20);
            entity.Property(e => e.TblPartnerId).HasColumnName("tblPartnerID");
            entity.Property(e => e.ZiroSmetka).HasMaxLength(15);
        });

        modelBuilder.Entity<ViewFakturiStavki>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewFakturiStavki");

            entity.Property(e => e.AltSifa).HasMaxLength(50);
            entity.Property(e => e.Artikal).HasMaxLength(150);
            entity.Property(e => e.Barkod).HasMaxLength(50);
            entity.Property(e => e.Ddv)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("DDV");
            entity.Property(e => e.Ddviznos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DDVIznos");
            entity.Property(e => e.Edm)
                .HasMaxLength(3)
                .HasColumnName("EDM");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IznosBezDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IznosBezDDV");
            entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(19, 3)");
            entity.Property(e => e.ProdaznaCenaBezDdvirabat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ProdaznaCenaBezDDVIRabat");
            entity.Property(e => e.ProdaznaCenaSoDdvirabat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ProdaznaCenaSoDDVIRabat");
            entity.Property(e => e.Rabat1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rabat2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rabat3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
            entity.Property(e => e.TblFakturaId).HasColumnName("tblFakturaID");
        });

        modelBuilder.Entity<ViewIzvodi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewIzvodi");

            entity.Property(e => e.BrojNaDokument).HasMaxLength(50);
            entity.Property(e => e.BrojNaIzvod).HasMaxLength(50);
            entity.Property(e => e.DatumNaIzvod).HasColumnType("datetime");
            entity.Property(e => e.Dolzi).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NazivPartner).HasMaxLength(350);
            entity.Property(e => e.Pobaruva).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SifraPartner).HasMaxLength(20);
            entity.Property(e => e.Smetka).HasMaxLength(50);
            entity.Property(e => e.Zabeleska).HasMaxLength(250);
        });

        modelBuilder.Entity<ViewIzvodiStavki>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewIzvodiStavki");

            entity.Property(e => e.BrojNaDokument).HasMaxLength(150);
            entity.Property(e => e.BrojNaIzvod).HasMaxLength(50);
            entity.Property(e => e.DatumNaIzvod).HasColumnType("datetime");
            entity.Property(e => e.DokumentId).HasColumnName("DokumentID");
            entity.Property(e => e.Dolzi).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IznosDokument).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.NazivPartner).HasMaxLength(350);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Pobaruva).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SifraPartner).HasMaxLength(20);
            entity.Property(e => e.TblIzvodiId).HasColumnName("tblIzvodiID");
        });

        modelBuilder.Entity<ViewKnzienjaM>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewKnzienjaM");

            entity.Property(e => e.AltSifraArtikal).HasMaxLength(50);
            entity.Property(e => e.DatumNaKnizenje).HasColumnType("datetime");
            entity.Property(e => e.DatumNaKraj).HasColumnType("datetime");
            entity.Property(e => e.DatumNaPocetok).HasColumnType("datetime");
            entity.Property(e => e.DoObjekt)
                .HasMaxLength(50)
                .HasColumnName("doObjekt");
            entity.Property(e => e.EdinecnaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FakturaBroj).HasColumnName("fakturaBroj");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IznosBezDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IznosBezDDV");
            entity.Property(e => e.IznosDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IznosDDV");
            entity.Property(e => e.IznosNaRabat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IznosSoDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IznosSoDDV");
            entity.Property(e => e.KodNaDokument).HasMaxLength(70);
            entity.Property(e => e.Kolicina).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.Kratenka).HasMaxLength(3);
            entity.Property(e => e.NabavnaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.OdObjekt)
                .HasMaxLength(50)
                .HasColumnName("odObjekt");
            entity.Property(e => e.Procent).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProdaznaCenaSoRabat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rabat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
            entity.Property(e => e.TblDdvid).HasColumnName("tblDDVID");
            entity.Property(e => e.TblDokumentId).HasColumnName("tblDokumentID");
            entity.Property(e => e.TblNormativId).HasColumnName("tblNormativID");
            entity.Property(e => e.TblObjektiIddo).HasColumnName("tblObjektiIDDO");
            entity.Property(e => e.TblObjektiIdod).HasColumnName("tblObjektiIDOD");
            entity.Property(e => e.TblPartnerId).HasColumnName("tblPartnerID");
            entity.Property(e => e.TblPriemId).HasColumnName("tblPriemID");
            entity.Property(e => e.TblSmetkaId).HasColumnName("tblSmetkaID");
            entity.Property(e => e.TipNaArtikal).HasColumnName("tipNaArtikal");
            entity.Property(e => e.TipNaKnizenje).HasColumnName("tipNaKnizenje");
            entity.Property(e => e.VrabotenKojJaIzdalSmetkata).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewPopi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewPopis");

            entity.Property(e => e.AltSifraArtikal).HasMaxLength(50);
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.PreostanataKolicina).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProsecnaNabavnaCena)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prosecnaNabavnaCena");
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
        });

        modelBuilder.Entity<ViewPopisDetalenLagerListum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewPopisDetalen_LagerLista");

            entity.Property(e => e.AltSifraArtikal).HasMaxLength(50);
            entity.Property(e => e.KolicinaIzlez).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.KolicinaVlez).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Kratenka).HasMaxLength(3);
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.PreostanataKolicina).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProsecnaNabavnaCena)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prosecnaNabavnaCena");
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
        });

        modelBuilder.Entity<ViewPriemStavki>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewPriemStavki");

            entity.Property(e => e.AltSifra).HasMaxLength(50);
            entity.Property(e => e.Artikal).HasMaxLength(150);
            entity.Property(e => e.Ddv)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("DDV");
            entity.Property(e => e.Ddvstapka)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("DDVStapka");
            entity.Property(e => e.Edm)
                .HasMaxLength(3)
                .HasColumnName("EDM");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IznosBezDdv)
                .HasColumnType("decimal(37, 4)")
                .HasColumnName("IznosBezDDV");
            entity.Property(e => e.IznosSoDdv)
                .HasColumnType("decimal(37, 4)")
                .HasColumnName("IznosSoDDV");
            entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NabavnaCenaBezDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NabavnaCenaBezDDV");
            entity.Property(e => e.NabavnaCenaSoDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NabavnaCenaSoDDV");
            entity.Property(e => e.PlanskaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PlanskaVrednost).HasColumnType("decimal(37, 4)");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProdaznaVrednostSoDdv)
                .HasColumnType("decimal(37, 4)")
                .HasColumnName("ProdaznaVrednostSoDDV");
            entity.Property(e => e.Rabat1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rabat2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rabat3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Razlika).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
            entity.Property(e => e.TblPriemId).HasColumnName("tblPriemID");
        });

        modelBuilder.Entity<ViewPriemi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewPriemi");

            entity.Property(e => e.DatumNaDospeanost).HasColumnType("datetime");
            entity.Property(e => e.DatumNaKreiranjeNaPriem).HasColumnType("datetime");
            entity.Property(e => e.Ddviznos)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("DDVIznos");
            entity.Property(e => e.Ddviznos18)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("DDVIznos18");
            entity.Property(e => e.Ddviznos5)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("DDVIznos5");
            entity.Property(e => e.Dobavuvac).HasMaxLength(350);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IspratnicaFakturaBroj).HasMaxLength(50);
            entity.Property(e => e.IspratnicaFakturaDatum).HasColumnType("datetime");
            entity.Property(e => e.IznosBezDdv)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("IznosBezDDV");
            entity.Property(e => e.IznosSoDdv)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("IznosSoDDV");
            entity.Property(e => e.IznosSoDdvzaokruzeno)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("IznosSoDDVZaokruzeno");
            entity.Property(e => e.KodNaDokument).HasMaxLength(70);
            entity.Property(e => e.Objekt).HasMaxLength(50);
            entity.Property(e => e.ObjektId).HasColumnName("ObjektID");
            entity.Property(e => e.PriemDatum).HasColumnType("datetime");
            entity.Property(e => e.ProdaznaVrednostSoDdv)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("ProdaznaVrednostSoDDV");
            entity.Property(e => e.SifraPartner).HasMaxLength(20);
            entity.Property(e => e.TblPartnerId).HasColumnName("tblPartnerID");
            entity.Property(e => e.TblUserId).HasColumnName("tblUserID");
            entity.Property(e => e.UserFullName).HasMaxLength(50);
            entity.Property(e => e.VkupenIznos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Zabeleska).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSmetki>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewSmetki");

            entity.Property(e => e.DataVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.DatumKraj).HasColumnType("datetime");
            entity.Property(e => e.DatumPocetok).HasColumnType("datetime");
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Iznos).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.IznosBezDdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("IznosBezDDV");
            entity.Property(e => e.KodNaDokument).HasMaxLength(70);
            entity.Property(e => e.ObjektId).HasColumnName("ObjektID");
            entity.Property(e => e.Partner).HasMaxLength(373);
            entity.Property(e => e.PresmetanDdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("PresmetanDDV");
            entity.Property(e => e.PresmetkovnaEdinica).HasMaxLength(73);
            entity.Property(e => e.ProcentNaPopust).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SmenaId).HasColumnName("Smena_ID");
            entity.Property(e => e.TblPartnerId).HasColumnName("tblPartnerID");
            entity.Property(e => e.TblUserId).HasColumnName("tblUserID");
        });

        modelBuilder.Entity<ViewSveUedno>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewSveUEdno");

            entity.Property(e => e.AltSifra).HasMaxLength(50);
            entity.Property(e => e.Barkod).HasMaxLength(50);
            entity.Property(e => e.Ddv).HasColumnName("DDV");
            entity.Property(e => e.Ddvstapka)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("DDVStapka");
            entity.Property(e => e.Edm)
                .HasMaxLength(3)
                .HasColumnName("EDM");
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.GrupaNaziv).HasMaxLength(50);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KlucniZborovi).HasMaxLength(300);
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.Normativ)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PodGrupaNaziv).HasMaxLength(50);
            entity.Property(e => e.PodgrupaId).HasColumnName("PodgrupaID");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(19, 3)");
            entity.Property(e => e.SearchString).HasMaxLength(674);
            entity.Property(e => e.Sifra).HasMaxLength(20);
        });

        modelBuilder.Entity<ViewSveUednoBeZalihaIsamoArtikli>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewSveUEdnoBeZalihaISamoArtikli");

            entity.Property(e => e.AltSifra).HasMaxLength(50);
            entity.Property(e => e.Barkod).HasMaxLength(50);
            entity.Property(e => e.Ddv).HasColumnName("DDV");
            entity.Property(e => e.Ddvstapka)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("DDVStapka");
            entity.Property(e => e.Edm)
                .HasMaxLength(3)
                .HasColumnName("EDM");
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.GrupaNaziv).HasMaxLength(50);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KlucniZborovi).HasMaxLength(300);
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.Normativ)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PodGrupaNaziv).HasMaxLength(50);
            entity.Property(e => e.PodgrupaId).HasColumnName("PodgrupaID");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SearchString).HasMaxLength(674);
            entity.Property(e => e.Sifra).HasMaxLength(20);
        });

        modelBuilder.Entity<ViewZaliha>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewZaliha");

            entity.Property(e => e.AltSifraArtikal).HasMaxLength(50);
            entity.Property(e => e.DatumNaKnizenje).HasColumnType("datetime");
            entity.Property(e => e.DatumNaPocetok).HasColumnType("datetime");
            entity.Property(e => e.Ddvstapka)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("DDVStapka");
            entity.Property(e => e.EdinecnaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EdinecnaMerkaIzlez).HasMaxLength(3);
            entity.Property(e => e.FakturaBroj).HasColumnName("fakturaBroj");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IznosBezDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IznosBezDDV");
            entity.Property(e => e.IznosDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IznosDDV");
            entity.Property(e => e.IznosSoDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IznosSoDDV");
            entity.Property(e => e.KodNaDokument).HasMaxLength(70);
            entity.Property(e => e.KolicinaIzlez).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.KolicinaPoMerkaIzlez).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.KolicinaVlez).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.KolicinaZaliha).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Kratenka).HasMaxLength(3);
            entity.Property(e => e.NabavenIznosBezDdv)
                .HasColumnType("decimal(31, 6)")
                .HasColumnName("NabavenIznosBezDDV");
            entity.Property(e => e.NabavnaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.NormativNaziv).HasMaxLength(50);
            entity.Property(e => e.OtpecatenaFiskalna).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PreostanataKolicinaNaZaliha).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
            entity.Property(e => e.TblSmetkaId).HasColumnName("tblSmetkaID");
            entity.Property(e => e.TipNaKnizenje).HasColumnName("tipNaKnizenje");
            entity.Property(e => e.VrabotenKojJaIzdalSmetkata).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewZalihaCelosna>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewZalihaCelosna");

            entity.Property(e => e.AltSifraArtikal).HasMaxLength(50);
            entity.Property(e => e.EdinecnaMerkaIzlez).HasMaxLength(3);
            entity.Property(e => e.EdinecnaMerkaVlez).HasMaxLength(3);
            entity.Property(e => e.IzdadenaKolicina).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.IznosBezDdv)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("IznosBezDDV");
            entity.Property(e => e.IznosDdv)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("IznosDDV");
            entity.Property(e => e.IznosSoDdv)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("IznosSoDDV");
            entity.Property(e => e.KolicinaIzlez).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.KolicinaVlez).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.KolicinaZaliha).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Naziv).HasMaxLength(150);
            entity.Property(e => e.PreostanataKolicinaNaZaliha).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TblArtikalId).HasColumnName("tblArtikalID");
        });

        modelBuilder.Entity<ViewZarabotkaPoArtikal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewZarabotkaPoArtikal");

            entity.Property(e => e.Artikal).HasMaxLength(150);
            entity.Property(e => e.ArtikalId).HasColumnName("ArtikalID");
            entity.Property(e => e.FiskalNa).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IznosNabavena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IznosOdProdazba).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.KolicinaNaZaliha).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.NabavenaKolicina).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ProdadenaKolicina).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.ProdaznaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProsecnaNabavnaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProsecnaNabavnaCenaBezDdv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ProsecnaNabavnaCenaBezDDV");
            entity.Property(e => e.RealnaCena).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.Sifra).HasMaxLength(20);
            entity.Property(e => e.VrednostNaZaliha).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.VrednostNaZalihaBezDdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("VrednostNaZalihaBezDDV");
            entity.Property(e => e.Zarabotka).HasColumnType("decimal(38, 6)");
        });

        modelBuilder.Entity<ViewZiroSmetke>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewZiroSmetke");

            entity.Property(e => e.Banka).HasMaxLength(100);
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Partner).HasMaxLength(350);
            entity.Property(e => e.ZiroSmetka).HasMaxLength(15);
        });

        modelBuilder.Entity<VwIndexText>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_INDEX_TEXT");

            entity.Property(e => e.CreateSql).HasColumnName("create_sql");
            entity.Property(e => e.DisableSql)
                .HasMaxLength(410)
                .HasColumnName("disable_sql");
            entity.Property(e => e.DropSql)
                .HasMaxLength(401)
                .HasColumnName("drop_sql");
            entity.Property(e => e.EnableSql)
                .HasMaxLength(410)
                .HasColumnName("enable_sql");
            entity.Property(e => e.IndexName)
                .HasMaxLength(128)
                .HasColumnName("index_name");
            entity.Property(e => e.OwnerName)
                .HasMaxLength(128)
                .HasColumnName("owner_name");
            entity.Property(e => e.TableName)
                .HasMaxLength(128)
                .HasColumnName("table_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
