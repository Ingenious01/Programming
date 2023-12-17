using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class CategoryEventsArgs: EventArgs
    {
        public Category Category { get; private set; }

        public CategoryEventsArgs(Category category) 
        {
            Category = category;
        }
    }
}
