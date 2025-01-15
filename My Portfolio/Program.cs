namespace My_Portfolio
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var AAPL = new Stock("Apple", 234.40, 233.28);
            var GOOGL = new Stock("Google", 191.23, 189.66);
            var O = new Stock("Realty Income Coporation", 52.54, 53.15);
            var MSFT = new Stock("Microsoft", 417.81, 415.67);
            
            var MyPortfolio = new Portfolio();

            MyPortfolio.AddStock(AAPL);
            MyPortfolio.AddStock(GOOGL);
            MyPortfolio.AddStock(O);
            MyPortfolio.AddStock(MSFT);

            MyPortfolio.ViewPortfolio();
            
        }
    }
}
