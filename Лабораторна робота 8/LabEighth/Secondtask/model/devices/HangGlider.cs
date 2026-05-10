using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondtask.model.devices
{
    internal class HangGlider : Devices
    {
        public HangGlider(string Name, int Weight, decimal Price)
            : base(Name, Weight, Price, 0)
        {

        }

        public override bool HaveEngineOrNot => false;

        public override bool Electric => false;

        public override string Material => "Aluminium, polyester, steel";

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
   