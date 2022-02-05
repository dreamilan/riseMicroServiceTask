﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Rise.ReportCore;

namespace Rise.ReportCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220205080718_Report4")]
    partial class Report4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Rise.ReportCore.Models.Const", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("CDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ConstDesc")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("ConstID")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int?>("ConstOrder")
                        .HasColumnType("integer");

                    b.Property<string>("ConstValue")
                        .HasColumnType("text");

                    b.Property<bool?>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("MDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Consts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("10ce7569-424b-4c8a-aaaa-e4d6862ed1bc"),
                            CDate = new DateTimeOffset(new DateTime(2022, 2, 5, 11, 7, 18, 220, DateTimeKind.Unspecified).AddTicks(7337), new TimeSpan(0, 3, 0, 0, 0)),
                            ConstDesc = "Cell Phone",
                            ConstID = "ReportInfoTypes",
                            ConstOrder = 0,
                            ConstValue = "0",
                            Deleted = false
                        },
                        new
                        {
                            Id = new Guid("ceb5d0ce-384e-4b6b-8daa-56164c33718a"),
                            CDate = new DateTimeOffset(new DateTime(2022, 2, 5, 11, 7, 18, 220, DateTimeKind.Unspecified).AddTicks(8312), new TimeSpan(0, 3, 0, 0, 0)),
                            ConstDesc = "E-Mail",
                            ConstID = "ReportInfoTypes",
                            ConstOrder = 1,
                            ConstValue = "1",
                            Deleted = false
                        },
                        new
                        {
                            Id = new Guid("324ade75-b9cf-474f-96aa-de3b0ad37953"),
                            CDate = new DateTimeOffset(new DateTime(2022, 2, 5, 11, 7, 18, 220, DateTimeKind.Unspecified).AddTicks(8326), new TimeSpan(0, 3, 0, 0, 0)),
                            ConstDesc = "Location",
                            ConstID = "ReportInfoTypes",
                            ConstOrder = 2,
                            ConstValue = "2",
                            Deleted = false
                        },
                        new
                        {
                            Id = new Guid("cda80de6-12da-4a2f-abe6-8cad6954e8c6"),
                            CDate = new DateTimeOffset(new DateTime(2022, 2, 5, 11, 7, 18, 220, DateTimeKind.Unspecified).AddTicks(8329), new TimeSpan(0, 3, 0, 0, 0)),
                            ConstDesc = "Preparing",
                            ConstID = "ReportStatus",
                            ConstOrder = 0,
                            ConstValue = "0",
                            Deleted = false
                        },
                        new
                        {
                            Id = new Guid("376f608d-97e2-4bfd-9271-69267bc277e9"),
                            CDate = new DateTimeOffset(new DateTime(2022, 2, 5, 11, 7, 18, 220, DateTimeKind.Unspecified).AddTicks(8331), new TimeSpan(0, 3, 0, 0, 0)),
                            ConstDesc = "Completed",
                            ConstID = "ReportStatus",
                            ConstOrder = 1,
                            ConstValue = "1",
                            Deleted = false
                        });
                });

            modelBuilder.Entity("Rise.ReportCore.Models.ConstLang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("CDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ConstLangDesc")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<Guid>("ConstRID")
                        .HasColumnType("uuid");

                    b.Property<bool?>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LangID")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("MDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ConstRID");

                    b.ToTable("ConstLangs");
                });

            modelBuilder.Entity("Rise.ReportCore.Models.Report", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("CDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool?>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("MDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ReportID")
                        .HasColumnType("text");

                    b.Property<string>("ReportName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Reports");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3dc186b5-750f-4085-abd0-eb4ec385eebe"),
                            CDate = new DateTimeOffset(new DateTime(2022, 2, 5, 11, 7, 18, 216, DateTimeKind.Unspecified).AddTicks(6617), new TimeSpan(0, 3, 0, 0, 0)),
                            Deleted = false,
                            ReportID = "00001",
                            ReportName = "Statistics of Contact by Location"
                        });
                });

            modelBuilder.Entity("Rise.ReportCore.Models.ReportRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("CDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool?>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("MDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ReportStatusRID")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("RequestedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ReportStatusRID");

                    b.ToTable("ReportRequests");
                });

            modelBuilder.Entity("Rise.ReportCore.Models.ConstLang", b =>
                {
                    b.HasOne("Rise.ReportCore.Models.Const", "Const")
                        .WithMany("ConstLangs")
                        .HasForeignKey("ConstRID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Const");
                });

            modelBuilder.Entity("Rise.ReportCore.Models.ReportRequest", b =>
                {
                    b.HasOne("Rise.ReportCore.Models.Const", "ConstReportStatus")
                        .WithMany("ReportRequests")
                        .HasForeignKey("ReportStatusRID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ConstReportStatus");
                });

            modelBuilder.Entity("Rise.ReportCore.Models.Const", b =>
                {
                    b.Navigation("ConstLangs");

                    b.Navigation("ReportRequests");
                });
#pragma warning restore 612, 618
        }
    }
}