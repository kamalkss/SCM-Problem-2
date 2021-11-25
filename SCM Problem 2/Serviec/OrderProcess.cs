using SCM_Problem_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_Problem_2.Serviec
{
    public class OrderProcess
    {
        public static Product ConvertToType(string[] input)
        {
            ProductType type;
            try
            {
                type = (ProductType)Enum.Parse(typeof(ProductType), input[0], ignoreCase: true);
            }
            catch (Exception ex)
            {
                type = ProductType.Other;
            }
            Product product;
            string name = input.Length > 1 ? string.Join(' ', input, 1, input.Length - 1) : string.Empty;
            switch(type)
            {
                case ProductType.Upgrade:
                    {
                        product = new Upgrade();
                        break;
                    }
                case ProductType.Video:
                    {
                        product = new Video(name);
                        break;
                    }
                case ProductType.MemberShip:
                    {
                        product = new Membership();
                        break;
                    }
                case ProductType.Book:
                    {
                        product = new Book(name);
                        break;
                    }
                case ProductType.Other:
                default:
                    {
                        product = new Other(name);
                        break;
                    }
            }
            return product;
        }
    }
}
