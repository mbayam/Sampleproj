using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinJar.interfaces
{
    public interface ICoinJar
    {
        public void addCoin(ICoin coin);
        public decimal GetTotalAmount();
        public void Reset();
    }
}
