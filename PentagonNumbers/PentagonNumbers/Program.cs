using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentagonNumbers {
    class Program {
        static void Main(string[] args) {
            var pentagons = new List<int>();
            var differences = new List<int>();
            var diff = 0;
            var sum = 0;
            for (var i = 1; i < 5000; i++) {
                var result1 = (i * ((3 * i) - 1)) / 2;
                pentagons.Add(result1);
            }
            var currPent = pentagons[0];
            for (var j = 0; j < 3000; j++) {
                for (var k = j + 1; k < 3000; k++) {
                    diff = Math.Abs(pentagons[j] - pentagons[k]);
                    sum = pentagons[j] + pentagons[k];
                    if (pentagons.Contains(diff) && pentagons.Contains(sum)) {
                        Console.WriteLine("Pof{0} and Pof{1}: Difference = {2}, Sum = {3}", j - 1, k - 1, diff, sum);
                        differences.Add(Math.Abs(pentagons[j] - pentagons[k]));
                    }
                    //Console.WriteLine("{0} {1} {2} {3}", k, j, sum, diff);
                }
                if (j % 500 == 0) {
                    Console.WriteLine("Finished with {0}", j);
                }
            }
            int smallestDiff = 999999999;
            foreach(var num in differences) {
                if (smallestDiff > num) {
                    smallestDiff = num;
                }
            }
            Console.WriteLine(smallestDiff);
            Console.ReadLine();
        }
    }
}
