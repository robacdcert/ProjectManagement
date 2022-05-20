﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementClasses
{
    public class AppDbContext : DbContext
    {

        public virtual DbSet<Work> Work { get; set; } = null!;
        public virtual DbSet<Projects> Projects { get; set; } = null!;
        public virtual DbSet<Resources> Resources { get; set; } = null!;

        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }



        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {

            var connStr = @"server=localhost\sqlexpress;database=ProjectManagementDb;trustServerCertificate=true;trusted_connection=true";

            builder.UseSqlServer(connStr);
        }
    }
}
