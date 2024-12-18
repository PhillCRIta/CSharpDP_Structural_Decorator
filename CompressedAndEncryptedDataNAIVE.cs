using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Decorator
{
	internal class CompressedAndEncryptedDataNAIVE : CloudDataNAIVE
	{
		public CompressedAndEncryptedDataNAIVE(string url) : base(url)
		{
		}
		public override void Save(string data)
		{
			string compressed = new CompressDataNAIVE(_url).Compress(data);
			string encryptedAndCompressed = new EncryptDataNAIVE(_url).Encrypt(compressed);
			base.Save(encryptedAndCompressed);
		}
	}
}
