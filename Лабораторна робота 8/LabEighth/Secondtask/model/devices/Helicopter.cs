using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondtask.model.devices
{
    internal class Helicopter : Devices
    {
        public Helicopter(string Name, int Weight, decimal Price, int Power)
            : base(Name, Weight, Price, Power)
        { }

        public override bool HaveEngineOrNot => true;

        public override bool Electric => false;

        public override string Material => "Aluminium alloys";

        public override string ToString()
        {
            return base.ToString() + $"/ Engine: {Power}";
        }
    }
}
