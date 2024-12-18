using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Decorator
{
	internal class CloudDataNAIVE
	{
		protected readonly string _url;

		public CloudDataNAIVE(string url)
		{
			_url = url;
		}
		public virtual void Save(string data)
		{
			Console.WriteLine("I'm saving data "+data+" to cloud at: " + _url);
		}
	}
}
