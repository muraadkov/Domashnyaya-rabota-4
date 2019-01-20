using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    public partial class Car
    {
        private string _name;
        private string _color;
        private int _year;
        private double _engineCapacity;
        private int _maxSpeed;
        public string Name { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public double EngineCapacity { get; set; }
        public int MaxSpeed { get; set; }
        public static int GetName { get; }
        public static int GetColor { get; }
        
        public void machineSpecifications(string name, string color, int year, double engineCapacity, int maxSpeed)
        {
            _name = name;
            _color = color;
            _year = year;
            _engineCapacity = engineCapacity;
            _maxSpeed = maxSpeed;
        }
        public Car()
        {
            _name = Name; _color = Color; _engineCapacity = EngineCapacity; _year = Year;_maxSpeed = MaxSpeed;
        }
        public Car(string name, string color, double engineCapacity)
        {
            _name = name; _color = color; _engineCapacity = engineCapacity; _year = 0; _maxSpeed = 0;
        }
        public Car(string name, string color, double engineCapacity, int year, int maxSpeed)
        {
            _name = name; _color = color; _engineCapacity = engineCapacity; _year = year; _maxSpeed = maxSpeed;
        }
        static Car()
        {

        }

    }
}
