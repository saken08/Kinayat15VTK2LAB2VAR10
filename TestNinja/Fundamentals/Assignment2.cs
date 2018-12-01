
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestNinja.Fundamentals
{
    public class Assignment2
    {
        public IEnumerable<int> GetMinus(int qwe)
        {
            for (var i = -4; i <= qwe; i++)
                if (i >= 0)
                    yield return i;
        }
    }
}