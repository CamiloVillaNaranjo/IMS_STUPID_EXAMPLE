using Yuxi.StupidLibrary;
using System;

namespace Yuxi.StupidConsole
{
    class Program
    {
        static void Main()
        {
            var myTv = Television.Instance;
            myTv.ColorMode = "CMYK";

            var myTvNew = Television.Instance;
            myTvNew.ColorMode = "RGB";


            if(myTv == myTvNew)
            {
                Console.WriteLine("instance are equals");
                Console.WriteLine("Because its property ColorMode has the following values:");
                Console.WriteLine("first instance: \'{0}\'", myTv.ColorMode);
                Console.WriteLine("second instance: \'{0}\'", myTvNew.ColorMode);

                Console.ReadLine();
            }
        }
    }
}
