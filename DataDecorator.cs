using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Decorator
{
	internal abstract class DataDecorator : IData //this is the BASE DECORATOR
	{
		//datadecorator class make easier to create different concrete decorator,
		//it's a helper class with some base function for a concrete decorator
		protected IData _data; //this is the object that we would DECORATE

		public DataDecorator(IData data)
		{
			_data = data;
		}

		public abstract void Save(string data);
	}
}
