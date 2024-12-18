using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Decorator
{
	internal class EncryptionDecorator : DataDecorator
	{
		public EncryptionDecorator(IData data) : base(data)
		{
		}

		public override void Save(string data)
		{
			string encrypted = Encrypt(data);
			base._data.Save(encrypted);
		}

		public string Encrypt(string data)
		{
			return "asdasdasdadadasdasdas";
		}
	}
}
