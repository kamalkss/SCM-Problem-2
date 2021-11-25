using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_Problem_2.Model
{
    public abstract class Product
    {
        public string ItemName { get; set; }
        public List<string> Operations { get; set; }
        public abstract void GetSlip();
    }
}
