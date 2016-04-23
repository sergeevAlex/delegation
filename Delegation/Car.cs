using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegation
{
	class Car : Vehicle
	{
		public int Power { get; set; }
		public Car(int prise, int maxspeed, int year, int Power) : base(prise, maxspeed, year)
		{
			this.Power = Power;
		}   
	}
}