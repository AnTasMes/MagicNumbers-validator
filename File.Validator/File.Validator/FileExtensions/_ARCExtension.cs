using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ARCExtension : FileExtensionInfo
	{
		public override string Name => "arc";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"41-52-43", "1A-08"};
	}
}