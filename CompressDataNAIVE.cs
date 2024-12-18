using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Decorator
{
	internal class CompressDataNAIVE : CloudDataNAIVE
	{
		public CompressDataNAIVE(string url) : base(url)
		{
		}

		public override void Save(string data)
		{
			string compressed = Compress(data);
			base.Save(compressed);
		}

		public string Compress(string data)
		{
			return data.Substring(0, 9);
		}
	}
}
