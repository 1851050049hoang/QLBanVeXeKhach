﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanVeXeKhach
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyBanVeXeKhachEntities : DbContext
    {
        public QuanLyBanVeXeKhachEntities()
            : base("name=QuanLyBanVeXeKhachEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChuyenXe> ChuyenXes { get; set; }
        public virtual DbSet<LoaiNhanVien> LoaiNhanViens { get; set; }
        public virtual DbSet<LoaiXe> LoaiXes { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<VeXe> VeXes { get; set; }
        public virtual DbSet<Xe> Xes { get; set; }
    }
}
