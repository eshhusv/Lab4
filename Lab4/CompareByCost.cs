using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class CompareByCost : IComparer
    {
        public int Compare(object? x, object? y)
        {
            var p1 = x as Price<int>;
            var p2 = y as Price<int>;

            if (p1 != null && p2 != null)
            {
                if (p1.Id > p2.Id)
                    return 1;
                else if (p1.Id < p2.Id)
                    return -1;
                else
                    return 0;
            }
            else
                throw new Exception("Object must be type of Price");
        }
    }
}
