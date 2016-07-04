using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_4
{
    class Cart
    {
        List<IProduct> list = new List<IProduct>();
        public bool Add(IProduct product)
        {
            try
            {
                list.Add(product);               
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(IProduct product)
        {
            try
            {
                list.Remove(product);               
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int Count()
        {

            int commonCost = 0;
            foreach (var item in list)
            {
                commonCost += item.GetCost();
            }
            return commonCost;
               
           
        }
    }
}
