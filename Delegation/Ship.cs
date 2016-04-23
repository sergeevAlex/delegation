using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegation
{
	class Ship : Vehicle
	{

		public string Port_registry { get; set; }
		public int passengers { get; set; }
		public Ship(int prise, int maxspeed, int year, string Port_registry, int passengers) : base(prise, maxspeed, year)
		{
			this.Port_registry = Port_registry;
			this.passengers = passengers;
		}   
	}
}