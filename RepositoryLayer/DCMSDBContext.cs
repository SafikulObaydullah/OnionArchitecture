﻿
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class DCMSDBContext : DbContext
    {
        public DCMSDBContext(DbContextOptions<DCMSDBContext> options) : base(options)
        {
        }
    }
}
