using Coins.Persistence;
using CoinsRepository.FactoryContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinsRepository.FactoryContext
{
   public class MyFactoryContext : IMyFactoryContext
    {
        public ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
