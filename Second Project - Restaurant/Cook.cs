using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project___Restaurant
{
    public class Cook
    {
        public Order SubmitRequest(MenuItem menuItem, int quantity)
        {
            Order order = null;
            switch (menuItem)
            {
                case MenuItem.Chicken:
                    order = new ChickenOrder(quantity);
                    break;
                case MenuItem.Egg:
                    order = new EggOrder(quantity);
                    break;
            }
            return order;
        }

        public void PrepareFood(Order order)
        {
            order.Cook();

        }


    }     
}
