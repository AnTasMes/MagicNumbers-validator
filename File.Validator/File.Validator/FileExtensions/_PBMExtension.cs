using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PBMExtension : FileExtensionInfo
	{
		public override string Name => "pbm";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"50-31-0A", "50-34-0A"};
	}
}