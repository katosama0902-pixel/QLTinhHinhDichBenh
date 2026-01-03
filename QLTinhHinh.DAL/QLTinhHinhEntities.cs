using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLTinhHinh.DAL
{
    public partial class QLTinhHinhEntities : DbContext
    {
        public QLTinhHinhEntities()
            : base("name=QLTinhHinhEntities")
        {
        }

        public virtual DbSet<DiaPhuong> DiaPhuongs { get; set; }
        public virtual DbSet<TrangThai> TrangThais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrangThai>()
                .HasMany(e => e.DiaPhuongs)
                .WithRequired(e => e.TrangThai)
                .WillCascadeOnDelete(false);
        }
    }
}
