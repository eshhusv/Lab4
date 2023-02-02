using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Price<T> : ICloneable, IComparable
    {
        public T Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }

        public object Clone()
        {
            return new Price<T>
            {
                Id = this.Id,
                Name = this.Name,
                Cost = this.Cost
            };
        }

        public int CompareTo(object? obj)
        {
            if (obj is Price<T>)
            {
                var p=obj as Price<T>;
                if (this.Name.CompareTo(p.Name)>0)
                    return 1;
                else if (this.Name.CompareTo(p.Name) < 1)
                    return -1;
                else
                    return 0;
            }
            else
                throw new Exception("Object must be type of Price");
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
