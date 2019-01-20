using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    public partial class Car
    {
        public string showCarSpecifications()
        {
            return "Название: " + _name + "\nЦвет: " + _color + "\nОбъём двигателя: " + _engineCapacity + "\nГод: " + _year + "\nКоличество лошадинных сил: " + _maxSpeed;
        }
    }
}
