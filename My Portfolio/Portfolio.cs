using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Portfolio
{
    internal class Portfolio
    {
       
        public List<Stock> porftolio;
      
        public Portfolio()
        {
            porftolio = new List<Stock>();
        }

        public void AddStock(Stock stock)
        {
            porftolio.Add(stock);
        }

        public void RemoveStock(Stock stock)
        {
            porftolio.Remove(stock);
        }
      
        public void ViewPortfolio()
        {
            foreach (var stock in porftolio)
            {
                Console.WriteLine($"Stock Name: {stock.StockName}\nOpening Price: {stock.OpeningPrice}\nClosing Price: {stock.ClosingPrice}");
                stock.PriceChange();
                Console.WriteLine();
            }
        }



    }
}





