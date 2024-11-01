﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class TestConfig : IEntityTypeConfiguration<TestTable>
    {
        public void Configure(EntityTypeBuilder<TestTable> builder)
        {
            builder.HasKey(x => x.Id);  
        }
    }
}
