using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinJar.interfaces
{
    public class Coin : ICoin
    {
        private decimal _amount;
        private decimal _volume;
        public decimal Amount {
            get => _amount;
            set => _amount = value;
        }
        public decimal Volume {
            get => _volume;
            set => _volume = value;
        }
    }
}
