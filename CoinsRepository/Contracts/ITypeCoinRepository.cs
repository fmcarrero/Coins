using Coins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinsRepository.Contracts
{
    public interface ITypeCoinRepository
    {
        void Save(TypeCoin Typecoin);
    }
}
