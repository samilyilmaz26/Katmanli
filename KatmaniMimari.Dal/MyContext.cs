﻿using KatmaniMimari.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmaniMimari.Dal
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> db):base(db)
        {

        }
      public  DbSet<Personel> Personel { get; set; }
    }
}
