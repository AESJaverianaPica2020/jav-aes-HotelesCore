﻿using HotelesCore.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;


namespace VuelosCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<ReservaHotel> ReservaHotels { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

    }
}
