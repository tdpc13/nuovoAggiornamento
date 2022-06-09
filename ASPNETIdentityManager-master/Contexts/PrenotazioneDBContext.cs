﻿using ASPNETIdentityManager.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETIdentityManager.Contexts
{
    public class PrenotazioneDBContext : IdentityDbContext<Prenotazione>
    {
        public DbSet<Prenotazione> Prenotazione { get; set; }       //nome tabella

        public PrenotazioneDBContext(DbContextOptions<PrenotazioneDBContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
