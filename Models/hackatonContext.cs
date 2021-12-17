using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace hackaton.Models
{
    public class hackatonContext : DbContext
    {
        public DbSet<category> category { get; set; }
        public DbSet<challenger> challenger { get; set; }
        public DbSet<challengerStatus> challengerStatus { get; set; }
        public DbSet<conversation> conversation { get; set; }
        public DbSet<message> message { get; set; }
        public DbSet<order> order { get; set; }
        public DbSet<orderStatus> orderStatus { get; set; }
        public DbSet<participant> participant { get; set; }
        public DbSet<user> user { get; set; }
        public DbSet<userStatus> userStatus { get; set; }
        public hackatonContext(DbContextOptions<hackatonContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<participant>().HasKey(p => new { p.id_conv, p.user_id });
            modelBuilder.Entity<challenger>().HasKey(p => new { p.user_id, p.id_order });

            modelBuilder.Entity<participant>().HasOne(p => p.conversation).WithMany(p => p.participants).HasForeignKey(p => p.id_conv);
            modelBuilder.Entity<participant>().HasOne(p => p.user).WithMany(p => p.participations).HasForeignKey(p => p.user_id);
            modelBuilder.Entity<user>().HasOne(p => p.userStatus).WithMany(p => p.users).HasForeignKey(p => p.status_id);
            modelBuilder.Entity<message>().HasOne(p => p.participant).WithMany(p => p.messages).HasForeignKey(p => new { p.id_conv, p.user_id });
            modelBuilder.Entity<challenger>().HasOne(p => p.user).WithMany(p => p.challenges).HasForeignKey(p => p.user_id);
            modelBuilder.Entity<challenger>().HasOne(p => p.order).WithMany(p => p.challengers).HasForeignKey(p => p.id_order);
            modelBuilder.Entity<challenger>().HasOne(p => p.challengerStatus).WithMany(p => p.challengers).HasForeignKey(p => p.id_status);
            modelBuilder.Entity<order>().HasOne(p => p.user).WithMany(p => p.orders).HasForeignKey(p => p.user_id);
            modelBuilder.Entity<order>().HasOne(p => p.orderStatus).WithMany(p => p.orders).HasForeignKey(p => p.id_status);
            modelBuilder.Entity<order>().HasOne(p => p.category).WithMany(p => p.orders).HasForeignKey(p => p.id_category);
            modelBuilder.Entity<category>().HasOne(p => p.upper).WithMany(p => p.categories).HasForeignKey(p => p.id_upper);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            string configuring = "Data Source=35.223.191.239;Initial Catalog=hackatondb;Integrated Security=False;User ID=sqlserver;Password=hakatonctk;";
            optionsBuilder.UseSqlServer(configuring);
        }
    }
}
