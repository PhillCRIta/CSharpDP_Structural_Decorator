using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Decorator
{
	internal class EncryptDataNAIVE : CloudDataNAIVE
	{
		public EncryptDataNAIVE(string url) : base(url)
		{
		}
		public override void Save(string data)
		{
			string encrypted = Encrypt(data);
			base.Save(encrypted);
		}

		public string Encrypt(string data)
		{
			return "asdasdasdadadasdasdas";
		}
	}
}
