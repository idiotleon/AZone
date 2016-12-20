using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
 * Given two integers x and y, calculate the Hamming distance.
 * Note:
 *  0 ≤ x, y< 2^31
 */
namespace CSharpAZone.Solutions.Easy
{
    /// <summary>
    ///  T
    /// </summary>
    class HammingDistanceSolution
    {
        public int HammingDistance(int x, int y)
        {
            int z = x ^ y;
            int n = 0;
            while (z > 0)
            {
                z = z & (z - 1);
                ++n;
            }
            return n;
        }
    }
}
