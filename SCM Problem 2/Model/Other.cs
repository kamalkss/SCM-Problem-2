using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_Problem_2.Model
{
    public  class Other: PhysicalProduct
    {
        public Other(string name)
        {
            ItemName = name;
            Operations = new List<string>();
            base.GetSlip();
            base.AddCommission();
        }
    }
}
