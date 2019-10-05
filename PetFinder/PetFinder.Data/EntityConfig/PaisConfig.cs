using PetFinder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.EntityConfig
{
    class PaisConfig : EntityTypeConfiguration<Pais>
    {
        public PaisConfig()
        {
            Property(a => a.Sigla).HasMaxLength(2);
        }
    }
}
