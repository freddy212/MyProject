using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyProject.Models;

namespace MyProject.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20170501025039_Receipts")]
    partial class Receipts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyProject.Models.Receipt", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("address")
                        .IsRequired();

                    b.Property<string>("city")
                        .IsRequired();

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<string>("products")
                        .IsRequired();

                    b.Property<double>("totalPrice");

                    b.HasKey("id");

                    b.ToTable("Receipts");
                });
        }
    }
}
