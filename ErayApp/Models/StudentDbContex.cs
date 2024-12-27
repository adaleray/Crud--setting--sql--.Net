using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErayApp.Models
{
    public class StudentDbContex : DbContext
    {



        public DbSet<Ogrenci> Ogrenciler { get; set; }

        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
      
        public DbSet<OgrenciDers> OgrenciDersler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=ERAY-MONSTER\SQLEXPRESS;Initial Catalog=ErayFinal1;Integrated Security=true ;TrustServerCertificate=True");

        }



        
           protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Ogrenci>(entity =>
            {
                entity.Property(e => e.Ad)
              .IsRequired()  
              .HasMaxLength(50)  
              .HasColumnType("Varchar");  

                
                entity.Property(e => e.Soyad)
                      .IsRequired()   
                      .HasMaxLength(50)  
                      .HasColumnType("Varchar");  

              
                entity.Property(e => e.Numara)
                      .IsRequired()  
                      .HasMaxLength(50)  
                      .HasColumnType("Varchar");

               
                entity.HasOne(o => o.Sinif) 
                      .WithMany(s => s.Ogrenciler) 
                      .HasForeignKey(o => o.SinifId); 
                     

            });

            modelBuilder.Entity<Ders>(entity =>
            {
                entity.Property(e => e.Ad).IsRequired().HasMaxLength(100).HasColumnType("Varchar");
            });

            modelBuilder.Entity<Sinif>(entity =>
            {
                entity.Property(e => e.Ad).IsRequired().HasMaxLength(50).HasColumnType("Varchar");
                entity.Property(e => e.Kontenjan).IsRequired();
            });

            modelBuilder.Entity<OgrenciDers>()
                .HasKey(sd => new { sd.OgrenciId, sd.DersId });
        }

    }
}