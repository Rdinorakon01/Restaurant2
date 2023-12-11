using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project___Restaurant
{
    class Cook
    {
        public void SubmitRequest()
        { }
        public string PrepareFood(int chickenQuantity, int eggQuantity)
        {
            EggOrder egg = new EggOrder(eggQuantity);
            ChickenOrder chicken = new ChickenOrder(chickenQuantity);
            if (menuItem is ChickenOrder)
            {
                for (int i = 0; i < chickenQuantity; i++)
                {
                    chicken.CutUp();
                }
                chicken.Cook();
                return "Chicken has been prepared.";
            }
            if (menuItem is EggOrder)
            {
                for (int i = 0; i < eggQuantity; i++)
                {
                    try
                    {
                        egg.Crack();
                    }
                    catch
                    {
                        throw new Exception("Egg is rotten");
                    }
                    finally
                    {
                        egg.Discard();
                    }
                }
                egg.Cook();
                return "Egg has been prepared.";
            }
            return "Request has been prepared.";


        }
    }
}
