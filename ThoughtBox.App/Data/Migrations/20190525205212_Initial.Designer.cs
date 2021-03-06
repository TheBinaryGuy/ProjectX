﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThoughtBox.App.Data;

namespace ThoughtBox.App.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190525205212_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ThoughtBox.App.Models.DataProtectionKey", b =>
                {
                    b.Property<string>("FriendlyName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("XmlData");

                    b.HasKey("FriendlyName");

                    b.ToTable("DataProtectionKeys");
                });
#pragma warning restore 612, 618
        }
    }
}
