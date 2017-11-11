using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins.Models
{
    public class TypeCoin
    {
        private long Id;
        private string Name;
        private string Tag;
        private ICollection<Coin> Coins;
    }
}
