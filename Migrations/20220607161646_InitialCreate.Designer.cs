// <auto-generated />
using System;
using ComplaintsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ComplaintsApi.Migrations
{
    [DbContext(typeof(ComplaintDbContext))]
    [Migration("20220607161646_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ComplaintsApi.Models.Complaint", b =>
                {
                    b.Property<long>("ComplaintId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ComplaintId"), 1L, 1);

                    b.Property<string>("ApplicationFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FilesFileId")
                        .HasColumnType("bigint");

                    b.Property<int>("Form")
                        .HasColumnType("int");

                    b.Property<int>("Tin")
                        .HasColumnType("int");

                    b.Property<int>("address")
                        .HasColumnType("int");

                    b.Property<int>("complaint_text")
                        .HasColumnType("int");

                    b.Property<int>("ecp_code")
                        .HasColumnType("int");

                    b.Property<int>("email")
                        .HasColumnType("int");

                    b.Property<int>("indication_id")
                        .HasColumnType("int");

                    b.Property<int>("lot_nomer")
                        .HasColumnType("int");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("pnfl")
                        .HasColumnType("bigint");

                    b.Property<int>("signing_date")
                        .HasColumnType("int");

                    b.Property<int>("sip_id")
                        .HasColumnType("int");

                    b.Property<int>("unique_number")
                        .HasColumnType("int");

                    b.HasKey("ComplaintId");

                    b.HasIndex("FilesFileId");

                    b.ToTable("Complaints");
                });

            modelBuilder.Entity("ComplaintsApi.Models.File", b =>
                {
                    b.Property<long>("FileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("FileId"), 1L, 1);

                    b.Property<byte[]>("file")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FileId");

                    b.ToTable("File");
                });

            modelBuilder.Entity("ComplaintsApi.Models.Complaint", b =>
                {
                    b.HasOne("ComplaintsApi.Models.File", "Files")
                        .WithMany()
                        .HasForeignKey("FilesFileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Files");
                });
#pragma warning restore 612, 618
        }
    }
}
