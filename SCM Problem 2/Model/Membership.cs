using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_Problem_2.Model
{
    public class Membership : NonPhysicalProduct
    {
        public Membership()
        {
            Operations = new List<string>();
            base.GetSlip();

            Operations.Add("Active The MemberShip");
            Console.WriteLine("Active The MemberShip");

            base.DropMail();
        }
    }
}
