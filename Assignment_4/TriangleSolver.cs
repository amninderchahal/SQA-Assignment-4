using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public static class TriangleSolver
    {
        public static string analyze(int side_A, int side_B, int side_C)
        {
            string result = null;

            if (side_A == 0 || side_B == 0 || side_C == 0)
                result = "Triangle sides cannot be 0";

            else if (side_A < 0 || side_B < 0 || side_C < 0)
                result = "Triangle sides cannot negative";

            else if ((side_A + side_B < side_C) || (side_B + side_C < side_A) || (side_A + side_C < side_B))
                result = "Triangle cannot be formed with the given sides";

            else if (side_A == side_B && side_B == side_C)
                result = "Triangle is Equilateral";
                
            else if (side_A == side_B || side_B == side_C || side_C == side_A)
                result = "Triangle is Isosceles";

            else if (side_A != side_B && side_B != side_C && side_C != side_A)
                result = "Triangle is Scalene";

            return result;
        }
    }
}
