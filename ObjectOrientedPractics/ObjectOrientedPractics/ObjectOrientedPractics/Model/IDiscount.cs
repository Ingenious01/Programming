using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public interface IDiscount
    {
        string Info();
        int Calculate(List<Item> items);
        int Apply(List<Item> items);
        void Update(List<Item> items);
    }
}
