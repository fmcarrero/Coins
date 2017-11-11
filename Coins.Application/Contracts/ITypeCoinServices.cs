using Coins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins.Application.Contracts
{
    public interface ITypeCoinServices
    {
        void Save(TypeCoin Typecoin);
    }
}
