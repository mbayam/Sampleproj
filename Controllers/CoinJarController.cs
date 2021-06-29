using CoinJar.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinJar.Controllers
{
    [ApiController]
    [Route("coin")]
    public class CoinJarControllerm : ControllerBase
    {
        ICoinJar coinJar = new CoinJarI();
        [HttpPost]
        public String addCoin(Coin coin)
        {
            ICoin coin1 = coin;
            coinJar.addCoin(coin1);
            return "Coin created";
        }
        [HttpGet]
        public IActionResult GetTotalAmount()
        {
           var amount = coinJar.GetTotalAmount();
           return Ok(amount);
        }
        [HttpPut]
        public IActionResult ResetCoin()
        {
            coinJar.Reset();
            return Ok();
        }
    }
    
}
