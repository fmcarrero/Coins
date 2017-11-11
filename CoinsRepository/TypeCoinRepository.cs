using CoinsRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coins.Models;
using CoinsRepository.FactoryContext;
using System.Data.SqlClient;

namespace CoinsRepository
{
    public class TypeCoinRepository : ITypeCoinRepository
    {
        private readonly IMyFactoryContext _IFactoryContext;
        public TypeCoinRepository(IMyFactoryContext Factory) {
            _IFactoryContext = Factory;
        }
        public void Save(TypeCoin Typecoin)
        {
            using (var context = _IFactoryContext.Create()) {
                string sqlquery = "insert into TypeCoins(Name,Tag) values(@Name,@Tag)";
                context.Database.ExecuteSqlCommand(sqlquery
                    ,new SqlParameter("Name",Typecoin.Name)
                    ,new SqlParameter("Tag", Typecoin.Tag));
                context.SaveChanges();
            }
        }
    }
}
