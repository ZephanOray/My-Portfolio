using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace My_Portfolio
{
    internal class Stock
    {
        public string StockName { get; set; }
        public double OpeningPrice { get; set; }
        public double ClosingPrice { get; set; }

        public Stock(string stockName, double openingPrice, double closingPrice)
        {
            StockName = stockName;
            OpeningPrice = openingPrice;
            ClosingPrice = closingPrice;
        }

        public void PriceChange()
        {
            string result = ClosingPrice > OpeningPrice ? $"Down {(ClosingPrice - OpeningPrice).ToString("C2")}" : $"Up {(OpeningPrice - ClosingPrice).ToString("C2")}";

            Console.WriteLine(result);
        }

        
      

    }
}
