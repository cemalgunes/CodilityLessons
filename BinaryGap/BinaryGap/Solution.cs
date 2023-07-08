using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    public class Solution
    {
        public int solution(int N)   
        {
            return Convert.ToString(N, 2).Trim('0').Split(new[] { '1' }).Max(x => x.Length);
        }
    }
}
