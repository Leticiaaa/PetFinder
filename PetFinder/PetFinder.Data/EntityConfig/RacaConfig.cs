using PetFinder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.EntityConfig
{
    class RacaConfig : EntityTypeConfiguration<Raca>
    {
        public RacaConfig()
        {
            HasKey(a => a.RacaId);
            Property(a => a.Descricao).HasMaxLength(500);
        }
    }
}

