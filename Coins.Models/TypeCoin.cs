using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins.Models
{
    public class TypeCoin
    {
        private long id;
        private string name;
        private string tag;
        private ICollection<Coin> coins;

        public TypeCoin(long  _id, string _name, string _Tag) {
            this.id = _id;
            this.name = _name;
            this.tag = _Tag;
        }
        public long Id {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Tag {
            get{ return this.tag; }
            set { this.tag = value; }
        }

        public ICollection<Coin> Coins{
            get{ return this.coins; }
            set{ this.coins = value; }
         }

    }
}
