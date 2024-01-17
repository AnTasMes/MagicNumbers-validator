using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _NUPExtension : FileExtensionInfo
	{
		public override string Name => "nup";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4E-55-52-55-49-4D-47", "4E-55-52-55-50-41-4C"};
	}
}