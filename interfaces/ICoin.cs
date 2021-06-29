using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinJar.interfaces
{
    public interface ICoin
    {
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }
    }
}
