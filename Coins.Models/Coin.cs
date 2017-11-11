using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins.Models
{
    public class Coin
    {
        private long id;
        private string name;
        private TypeCoin typeCoin;
        private long typecoinId;
       

        public Coin(long _id, string _name, TypeCoin _typecoin) {
            this.id = _id;
            this.name = _name;
            this.typeCoin = _typecoin;
        }
        public TypeCoin TypeCoins {
            get { return this.typeCoin; }
            set { this.typeCoin = value; }
        }
        public long Id {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public long TypecoinId
        {
            get { return this.typecoinId; }
            set { this.typecoinId = value; }
        }
    }
}
