using Coins.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins.Persistence.Mapping
{
    public class TypeCoinMap : EntityTypeConfiguration<TypeCoin>
    {
        public TypeCoinMap() {
            Property(e => e.Name)
                .HasMaxLength(50)
                .IsRequired();
            Property(e => e.Tag)
                .HasMaxLength(3)
                .IsRequired();
        }
    }
}
