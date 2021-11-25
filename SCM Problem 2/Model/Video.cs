using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_Problem_2.Model
{
    public class Video : NonPhysicalProduct
    {
        public Video(string VideoName)
        {
            Operations = new List<string>();
            ItemName = VideoName;
            GetSlip();
        }
        public override void GetSlip()
        {
            base.GetSlip();
            if(ItemName.ToLower().Equals("learning to ski"))
            {
                Operations.Add("First Aid video added to the packing slip");
                Console.WriteLine("First Aid video added to the packing slip");
            }
        }
    }
}
