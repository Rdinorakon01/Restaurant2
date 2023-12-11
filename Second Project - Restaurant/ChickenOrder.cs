using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project___Restaurant
{
    class ChickenOrder: Order
    {
        public ChickenOrder(int quantity) : base(quantity)
        { }
        public void CutUp()
        { }
        public override void Cook()
        {
            throw new Exception("Chicken is cooked");
        }
    }
}
