using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number10
{
    class Program
    {
        static int Perimetr (int osnovanieBig, int osnovanieSmal, int high)
        {
            int katet = (osnovanieBig - osnovanieSmal)/2;
            int gipotinyza = (int)(Math.Sqrt(Math.Pow(katet, 2)+Math.Pow(high,2)));
            int perimetr = osnovanieSmal + osnovanieBig + gipotinyza * 2;
            return perimetr;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                int osnovanieBig = 10, osnovanieSmal = 2, high = 4;
                int resultOfMethod = Perimetr(osnovanieBig, osnovanieSmal, high);
                int sumOfPerimetr = 0;
            }
            

        }
    }
}
