using Yuxi.StupidLibrary;

namespace Yuxi.StupidConsole
{
    class OwnerProducts
    {
        static Television _tvSet = new Television();

        static void Main(string[] args)
        {
            BuyProducts();
        }

        static void BuyProducts()
        {
            _tvSet.Brand = "Toshiba";
            _tvSet.Model = "U76";
            _tvSet.Series = "LATAM15478998777TS";

            Computer _myLaptop = new Computer();
            _myLaptop.Brand = _tvSet.Brand;
            _myLaptop.Model = "ProBook 4440s";
            _myLaptop.Series = "6CGFQ02WY3G42K";
        }
    }
}
