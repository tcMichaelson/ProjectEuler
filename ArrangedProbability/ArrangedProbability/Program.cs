using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrangedProbability {
    class Program {
        static void Main(string[] args) {

            long total = 1017050000000;
            long currNum;
            long minNum;
            long maxNum = total;
            double midPoint;
            bool found = false;
            bool nextNum = false;
            Console.WriteLine("Started at {0}.", DateTime.Now);
            while (total < 9999999999999 && found == false) {
                if (total % 500000000 == 0) Console.WriteLine(total);
                currNum = total / 2;
                minNum = 1;
                maxNum = total;
                while (nextNum == false && found == false) {
                    double prob = ((double)currNum / (double)total) * (((double)currNum - 1) / ((double)total - 1));
                    if (prob > .4999999999 && prob < .50000000001) {
                        Console.WriteLine("{0} is the number of discs, and {1} is the number of blue discs", total, currNum);
                        Console.WriteLine("Found at {0}.", DateTime.Now);
                        total++;
                        nextNum = true;
                        found = true;
                    } else if (prob > .5) {
                        midPoint = (minNum + currNum) / 2;
                        maxNum = (int)currNum;
                        currNum = (int)midPoint;
                    } else {
                        midPoint = (maxNum + currNum) / 2;
                        minNum = (int)currNum;
                        currNum = (int)midPoint;
                    }
                    if (minNum == currNum || maxNum == currNum) {
                        total++;
                        nextNum = true;
                    }
                }
                nextNum = false;
            }
            Console.ReadLine();

        }
    }
}
