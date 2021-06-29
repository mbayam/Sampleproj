using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoinJar.utils
{
    public class StreamWriterAndRead
    {
        public static async Task AddCoin(string text)
        {
            await File.WriteAllTextAsync("C:\\Projects\\WriteText.txt", text);
        }

       
    }
}
