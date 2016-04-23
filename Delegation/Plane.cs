using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegation
{
	class Plane : Vehicle
	{
		public int height { get; set; }
		public int passengers { get; set; }
		public Plane(int prise, int maxspeed, int year, int height, int passengers)
			: base(prise, maxspeed, year)
		{
			this.height = height;
			this.passengers = passengers;
		}   
	}
}