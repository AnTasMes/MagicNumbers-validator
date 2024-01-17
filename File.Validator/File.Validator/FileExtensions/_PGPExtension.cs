using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PGPExtension : FileExtensionInfo
	{
		public override string Name => "pgp";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"85-03"};
	}
}