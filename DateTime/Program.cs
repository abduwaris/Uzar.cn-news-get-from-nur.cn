using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //14213629935330733
            //1421321881
            
            DateTime dt = DateTime.Now;
            DateTime lt = new DateTime(1970, 1, 1);

            TimeSpan ts = dt - lt;

            //
            DateTime dtt = new DateTime(14213218810000000);
            dtt = dtt.AddTicks(lt.Ticks);
            Console.WriteLine(dtt);
            Console.ReadKey();
        }
    }
}
