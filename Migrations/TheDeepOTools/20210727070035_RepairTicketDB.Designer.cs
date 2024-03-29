﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheDeepOTools.Data;

namespace TheDeepOTools.Migrations.TheDeepOTools
{
    [DbContext(typeof(TheDeepOToolsContext))]
    [Migration("20210727070035_RepairTicketDB")]
    partial class RepairTicketDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheDeepOTools.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<byte[]>("ProfilePicture");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.Property<int>("UsernameChangeLimit");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("TheDeepOTools.Models.Inventory", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .IsRequired();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("ItemIdentifier")
                        .IsRequired();

                    b.Property<string>("ItemName")
                        .IsRequired();

                    b.Property<int>("OnHandQty");

                    b.Property<int>("OutQty");

                    b.Property<decimal>("Price");

                    b.Property<string>("Subcategory");

                    b.Property<int>("TotalQty");

                    b.HasKey("ItemID");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("TheDeepOTools.Models.RepairTicket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("OwnerId");

                    b.Property<string>("TicketState");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("RepairTicket");
                });

            modelBuilder.Entity("TheDeepOTools.Models.RepairTicketMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Message");

                    b.Property<string>("OwnerId");

                    b.Property<Guid>("TicketId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("TicketId");

                    b.ToTable("RepairTicketMessage");
                });

            modelBuilder.Entity("TheDeepOTools.Models.RepairTicket", b =>
                {
                    b.HasOne("TheDeepOTools.Areas.Identity.Data.ApplicationUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("TheDeepOTools.Models.RepairTicketMessage", b =>
                {
                    b.HasOne("TheDeepOTools.Areas.Identity.Data.ApplicationUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.HasOne("TheDeepOTools.Models.RepairTicket", "Ticket")
                        .WithMany("Messages")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
