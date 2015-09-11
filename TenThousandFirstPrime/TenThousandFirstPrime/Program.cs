using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenThousandFirstPrime {
    class Program {
        static void Main(string[] args) {
            var ithPrime = 1;
            int currNum = 3;
            int currPrime = 0;
            var prime = true;
            while (ithPrime < 10001) {
                for (var i = 2; i <= (Math.Sqrt(currNum)); i++) {
                    if (currNum % i == 0) {
                        prime = false;
                        break;
                    }                    
                }
                if (prime == true) {
                    ithPrime++;
                    currPrime = currNum;
                }
                prime = true;
                currNum++;
            }
            Console.WriteLine("{0} is the 10,0001st prime number", currPrime);
            Console.WriteLine(ithPrime);
            Console.ReadLine();
        }
    }
}
