﻿using Coins.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins.Persistence.Mapping
{
   public class CoinsMap : EntityTypeConfiguration<Coin>
    {
        public CoinsMap() {
            Property(e => e.Name)
                .HasMaxLength(50)
                .IsRequired();
            HasKey(e => e.Id);

            HasRequired(e=> e.TypeCoins)
                .WithMany(l=> l.Coins)
                .HasForeignKey(a=> a.TypecoinId)
                .WillCascadeOnDelete(false)
                ;
        }
    }
}
