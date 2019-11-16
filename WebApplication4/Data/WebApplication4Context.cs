﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models
{
    public class WebApplication4Context : DbContext
    {
        public WebApplication4Context (DbContextOptions<WebApplication4Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication4.Models.Employee> Employee { get; set; }
    }
}
