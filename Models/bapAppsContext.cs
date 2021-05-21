﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BapProject.Models
{
    public partial class bapAppsContext : DbContext
    {
        public bapAppsContext()
        {
        }

        public bapAppsContext(DbContextOptions<bapAppsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BapApp> BapApps { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
      //      {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //        optionsBuilder.UseSqlite("Data Source=.\\App_Data\\bapApps.db;");
        //    }
      //  }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BapApp>(entity =>
            {
                entity.HasKey(e => e.AppId);

                entity.ToTable("bapApps");

                entity.Property(e => e.AppId).HasColumnName("AppID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
