using IMS.StupidLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.StupidConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTv = Television.Instance;
            myTv.ColorMode = "CMYK";

            var myTvNew = Television.Instance;
            myTvNew.ColorMode = "RGB";


            if(myTv == myTvNew)
            {
                Console.WriteLine("instance 'myTv' and 'myTvNew' are equals");
                Console.WriteLine("Because its property values for ColoMode are:");
                Console.WriteLine("'myTv' - '{0}'", myTv.ColorMode);
                Console.WriteLine("'myTvNew' - '{0}'", myTvNew.ColorMode);

                Console.ReadLine();
            }
        }
    }
}
