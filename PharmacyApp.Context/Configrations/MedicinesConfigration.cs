using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pharmacyApp.models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp.Context.Configrations
{
    public class MedicinesConfigration: IEntityTypeConfiguration<Medicincs>
    {
        public void Configure(EntityTypeBuilder<Medicincs> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Price).HasDefaultValue(50);
            builder.Property(x => x.Quantity).HasDefaultValue(50);

        }
    }
}
