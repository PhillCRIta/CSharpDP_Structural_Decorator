using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Decorator
{
	internal class CompressionDecorator : DataDecorator
	{
		public CompressionDecorator(IData data) : base(data)
		{
		}

		public override void Save(string data)
		{
			Console.WriteLine("Compressing data inside decorator");
			string compressed = Compress(data);
			//base.Save(compressed); //i can't call directly the base.Save, because in this case is not inherits from base class, but we use the composition
			//base.data is the object wrapped into decorator
			base._data.Save(compressed);
		}

		public string Compress(string data)
		{
			return data.Substring(0, 9);
		}
	}
}
