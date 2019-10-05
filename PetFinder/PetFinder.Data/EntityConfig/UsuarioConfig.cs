using PetFinder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.EntityConfig
{
    class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig() 
        {
            Property(a => a.Telefone).HasMaxLength(20);
            Property(a => a.Cpf).HasMaxLength(11);
        }
    }
}

