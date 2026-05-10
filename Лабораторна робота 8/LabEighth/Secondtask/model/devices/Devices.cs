using Secondtask.intarface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondtask.model.devices
{
    internal abstract class Devices : IDevice<Devices>, IEngine, IPart, ICloneable, IComparable<Devices>
    {
        public string Name { get; protected set; }
        public int Weight { get; protected set; }
        public abstract bool HaveEngineOrNot { get; }

        public abstract bool Electric { get; }
        public decimal Price { get; protected set; }
        public int Power { get; }
        public abstract string Material { get; }

        public Devices(string name, int weight, decimal price, int power)
        {
            Name = name;
            Weight = weight;
            Price = price;
            Power = power;
        }

        public Devices()
        {
            Name = "Unknown Device";
            Weight = 100;
        }

        public override string ToString()
        {
            return $"{Name}: {Weight}kg - {Price} millions / Material of the parts: {Material}";
        }

        public object Clone()
        {
            return Name.Clone();
        }

        public int CompareTo(Devices other)
        {
            if (other == null) return 1;
            return string.Compare(this.Name, other.Name);
        }
    }
}
