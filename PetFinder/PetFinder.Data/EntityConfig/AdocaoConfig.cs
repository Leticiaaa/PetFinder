using PetFinder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.EntityConfig
{
    class AdocaoConfig : EntityTypeConfiguration<Adocao>
    {
        public AdocaoConfig()
        {
            HasRequired(a => a.Doador)
                .WithMany()
                .HasForeignKey(a => a.DoadorId);
        }
    }
}

