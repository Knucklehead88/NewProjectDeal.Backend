﻿using Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Config
{
    public class PersonalInfoConfiguration : IEntityTypeConfiguration<PersonalInfo>
    {
        public void Configure(EntityTypeBuilder<PersonalInfo> builder)
        {
            builder
                .HasMany(p => p.Locations)
                .WithOne(p => p.PersonalInfo)
                .HasForeignKey(p => p.PersonalInfoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
