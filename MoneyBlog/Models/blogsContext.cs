using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MoneyBlog.Models
{
    public partial class blogsContext : DbContext
    {
        public blogsContext()
        {
        }

        public blogsContext(DbContextOptions<blogsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Accounttransaction> Accounttransaction { get; set; }
        public virtual DbSet<Transactiondispute> Transactiondispute { get; set; }
        public virtual DbSet<UserInformation> UserInformation { get; set; }
        public virtual DbSet<Useraccount> Useraccount { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=iloveblog.database.windows.net;Initial Catalog=blogs;User ID=orndorf;Password=lalalaLALALA89;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountName)
                    .HasColumnName("accountName")
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber).HasColumnName("accountNumber");

                entity.Property(e => e.AccountType)
                    .HasColumnName("accountType")
                    .IsUnicode(false);

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Accounttransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__accountt__9B57CF72D7099156");

                entity.ToTable("accounttransaction");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transactionId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Recipient)
                    .HasColumnName("recipient")
                    .IsUnicode(false);

                entity.Property(e => e.Time).HasColumnName("time");
            });

            modelBuilder.Entity<Transactiondispute>(entity =>
            {
                entity.HasKey(e => e.DisputeId)
                    .HasName("PK__transact__BC97D4F070BFA218");

                entity.ToTable("transactiondispute");

                entity.Property(e => e.DisputeId)
                    .HasColumnName("disputeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.TransactionId).HasColumnName("transactionId");
            });

            modelBuilder.Entity<UserInformation>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__userInfo__CBA1B257892FDC11");

                entity.ToTable("userInformation");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Useraccount>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__useracco__CB9A1CFF6061641B");

                entity.ToTable("useraccount");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.UserRole)
                    .HasColumnName("userRole")
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
