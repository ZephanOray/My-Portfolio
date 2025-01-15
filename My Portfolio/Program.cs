namespace My_Portfolio
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            var AAPL = new Stock("Apple", 240.00, 225.00);

            AAPL.PriceChange();
        }
    }
}
