using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project___Restaurant
{
    public class Server
    {
        MenuItem[][] requests = new MenuItem[8][];


        public void ReceiveRequest(int chickenQuantity, int eggQuantity, Drinks drink)
        {
            MenuItem[] singleOrder = new MenuItem[chickenQuantity + eggQuantity + 1];

            for (int i = 0; i < chickenQuantity; i++)
            {
                singleOrder[i] = MenuItem.Chicken;
            }
            Array.Resize(ref requests[], 8);

            for (int j = 0; j < eggQuantity; j++)
            {
                singleOrder[chickenQuantity + j] = MenuItem.Egg;
            }
            singleOrder[singleOrder.Length - 1] = MenuItem.Drinks;
            requests[requests.Length - 1] = singleOrder;
            if (requests.Length > 8)
                throw new Exception("Request from one table should be less 8");
            if (chickenQuantity == 0 && eggQuantity == 0 && drink == Drinks.None)
                throw new Exception("You haven't made request, please choose menu items");
        }


        public int chickenQuantity, eggQuantity = 0;
        object chicken, egg;
        public void SendRequest()
        {
            Cook cook = new Cook();
            foreach (MenuItem[] item in requests)
            {
                foreach (var elem in item)
                {
                    if (elem == MenuItem.Chicken)
                    {
                        chickenQuantity++;
                    }
                    else if (elem == MenuItem.Egg)
                    {
                        eggQuantity++;
                    }
                }
            }
            chicken = cook.SubmitRequest(chickenQuantity, MenuItem.Chicken);
            cook.PrepareFood(chicken);
            egg = cook.SubmitRequest(eggQuantity, MenuItem.Egg);
            cook.PrepareFood(egg);
        }
        public void Serve()
        {
        }
    }
}
