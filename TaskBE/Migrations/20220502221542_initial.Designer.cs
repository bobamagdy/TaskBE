// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskBE.EntityFrameWork;

namespace TaskBE.Migrations
{
    [DbContext(typeof(TaskContext))]
    [Migration("20220502221542_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskBE.Entities.DemographicTypeDTLTbl", b =>
                {
                    b.Property<int>("DemTypeDTL_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChoicesAr")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ChoicesEn")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("DemTypeID")
                        .HasColumnType("int");

                    b.Property<int>("WeightValue")
                        .HasColumnType("int");

                    b.HasKey("DemTypeDTL_ID");

                    b.HasIndex("DemTypeID");

                    b.ToTable("DemographicTypeDTLTbl");
                });

            modelBuilder.Entity("TaskBE.Entities.DemographicTypeTbl", b =>
                {
                    b.Property<int>("DemTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeDescAr")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("TypeDescEn")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("DemTypeId");

                    b.ToTable("DemographicTypeTbl");
                });

            modelBuilder.Entity("TaskBE.Entities.DemographicTypeDTLTbl", b =>
                {
                    b.HasOne("TaskBE.Entities.DemographicTypeTbl", "DemographicTypeTbl")
                        .WithMany()
                        .HasForeignKey("DemTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DemographicTypeTbl");
                });
#pragma warning restore 612, 618
        }
    }
}
