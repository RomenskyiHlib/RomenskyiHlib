using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondtask.model.devices
{
    internal class FlyCarpet : Devices
    {
        public FlyCarpet(string Name, int Weight, decimal Price)
            : base(Name, Weight, Price, 0)
        {

        }

        public override bool HaveEngineOrNot => false;

        public override bool Electric => true;

        public override string Material => "Wool";

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

