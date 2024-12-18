using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Decorator
{
	internal class CloudData : IData //the only difference respect to naive solution is implementing the IData interface
	{
		private readonly string _url;
		public CloudData(string url)
		{
			_url = url;
		}
		public virtual void Save(string data)
		{
			Console.WriteLine("I'm saving data " + data + " to cloud at: " + _url);
		}
	}
}
