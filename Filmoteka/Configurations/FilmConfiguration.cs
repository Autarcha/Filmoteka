using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmoteka.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Filmoteka.Configurations
{
    class FilmConfiguration: IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.ToTable("Films");
            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Rating).IsRequired();
        }
    }
}
