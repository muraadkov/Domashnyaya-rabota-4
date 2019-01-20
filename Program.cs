using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество машин: ");
            int countOfCars = Convert.ToInt32(Console.ReadLine());
            Car[] car = new Car[countOfCars];
            try
            {
                if (countOfCars < 5)
                {
                    throw new Exception("Машин может быть не больше 5-ти");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception();
            }
            for (int i = 0; i < countOfCars; i++)
            {
                car[i] = new Car();
                Console.WriteLine("Ввод данных: \n");
                Console.WriteLine("Введите название машины: ");
                car[i].Name = Console.ReadLine();
                Console.WriteLine("Введите цвет машины: ");
                car[i].Color = Console.ReadLine();
                Console.WriteLine("Введите объём двигателя машины: ");
                car[i].EngineCapacity = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите год машины: ");
                car[i].Year = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество лошадинных сил: ");
                car[i].MaxSpeed = int.Parse(Console.ReadLine());
                car[i] = new Car(car[i].Name, car[i].Color, car[i].EngineCapacity, car[i].Year, car[i].MaxSpeed);


            }
            Console.WriteLine("Машины в гараже: \n");
            for(int i = 0; i < countOfCars; i++)
            {
                Console.WriteLine(car[i].showCarSpecifications());
                Console.WriteLine("-------------------------------------");
            }
            Console.Read();
        }
    }
}
