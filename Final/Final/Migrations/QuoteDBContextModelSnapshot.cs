// <auto-generated />
using Final.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Final.Migrations
{
    [DbContext(typeof(QuoteDBContext))]
    partial class QuoteDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Final.Models.Quotes", b =>
                {
                    b.Property<int>("QuoteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Citation")
                        .HasColumnType("TEXT");

                    b.Property<int>("Date")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Quote")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.HasKey("QuoteID");

                    b.ToTable("submissions");

                    b.HasData(
                        new
                        {
                            QuoteID = 1,
                            Author = "Han Solo",
                            Citation = "",
                            Date = 1977,
                            Quote = "Great, kid, don't get cocky.",
                            Subject = "Cinema"
                        },
                        new
                        {
                            QuoteID = 2,
                            Author = "Qui-Gon Jinn",
                            Citation = "",
                            Date = 1999,
                            Quote = "The ability to speak does not make you intelligent",
                            Subject = "Cinema"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
