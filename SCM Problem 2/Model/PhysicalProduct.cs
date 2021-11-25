using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_Problem_2.Model
{
    public abstract class PhysicalProduct : Product
    {
        public override void GetSlip()
        {
            Operations.Add("Generated a packing slip for shipping.");
            Console.WriteLine("Generated a packing slip for shipping.");
        }
        public virtual void AddCommission()
        {
            Operations.Add("Commission payment to the agent");
            Console.WriteLine("Commission payment to the agent");
        }
    }
}
