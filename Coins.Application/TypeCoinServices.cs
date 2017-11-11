using Coins.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coins.Models;
using CoinsRepository.Contracts;

namespace Coins.Application
{
    public class TypeCoinServices : ITypeCoinServices
    {
        private readonly ITypeCoinRepository _ITypeCoinRepository;
        public TypeCoinServices(ITypeCoinRepository _typeCoinRepository) {
            _ITypeCoinRepository = _typeCoinRepository;
        }
        public void Save(TypeCoin Typecoin)
        {
            _ITypeCoinRepository.Save(Typecoin);
        }
    }
}
