using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project___Restaurant
{
    class EggOrder: Order
    {
        public int quality;
        public EggOrder(int quantity) : base(quantity)
        {
            quality = new Random().Next(101);
        }
        public int GetQuality()
        {
            return quality;
        }
        public void Crack()
        {  }
        public void Discard()
        {  }
        public override void Cook()
        {
            throw new Exception ("Egg is cooked");
        }

    }
}
