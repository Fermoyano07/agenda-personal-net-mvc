﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Agenda.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Agenda.Data
{
    public class AgendaContext : IdentityDbContext<IdentityUser>
    {
        public AgendaContext (DbContextOptions<AgendaContext> options)
            : base(options)
        {
        }

        public DbSet<Agenda.Models.Contacto> Contacto { get; set; } = default!;
    }
}
