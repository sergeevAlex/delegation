using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegation
{
	class Program
	{
		static void Main(string[] args)
		{

			//Самолет        
			var Plane = new Plane(50, 200, 1980, 11800, 180);
			Console.WriteLine();
			Console.WriteLine("Самолет  -  Airbus A320 ");
			Console.WriteLine("Цена самолета(млн $) - {0}", Plane.Price);
			Console.WriteLine("Максимальная скорость - {0}", Plane.Maxspeed);
			Console.WriteLine("Год выпуска - {0}", Plane.Year_create);
			Console.WriteLine("Количество  пассажиров - {0}", Plane.passengers);

			//Машина
			var Car = new Car(prise:22700, maxspeed:250,year:2008,Power:381);
			Console.WriteLine();
			Console.WriteLine("Машина -  BMW X5");
			Console.WriteLine("Цена ($) - {0}", Car.Price);
			Console.WriteLine("Максимальная скорость - {0}", Car.Maxspeed);
			Console.WriteLine("Год выпуска - {0}", Car.Year_create);
			Console.WriteLine("Мощность - {0}", Car.Power);


			//Корабль
			var Ship = new Ship(prise:40000,maxspeed:250,year:2000,Port_registry:"Port X",passengers:25);
			Console.WriteLine();
			Console.WriteLine("Корабль");
			Console.WriteLine("Цена ($) - {0}", Ship.Price);
			Console.WriteLine("Максимальная скорость - {0}", Ship.Maxspeed);
			Console.WriteLine("Год выпуска - {0}", Ship.Year_create);
			Console.WriteLine("Количество  пассажиров - {0}", Ship.passengers);
			Console.ReadLine();
		}
	}
}