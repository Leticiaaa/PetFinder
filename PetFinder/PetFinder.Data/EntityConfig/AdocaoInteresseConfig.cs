using PetFinder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.EntityConfig
{
    public class AdocaoInteresseConfig : EntityTypeConfiguration<AdocaoInteresse>
    {
        public AdocaoInteresseConfig()
        {
            HasRequired(a => a.Interessado).WithMany().HasForeignKey (a => a.InteressadoId);
        }
    }
}
