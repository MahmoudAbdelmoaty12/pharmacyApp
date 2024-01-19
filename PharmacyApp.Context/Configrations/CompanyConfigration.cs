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
    public class CompanyConfigration : IEntityTypeConfiguration<ProducingCompany>
    {
        public void Configure(EntityTypeBuilder<ProducingCompany> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100);
        }
    }
}
