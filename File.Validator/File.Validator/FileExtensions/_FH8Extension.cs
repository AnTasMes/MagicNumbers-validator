using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _FH8Extension : FileExtensionInfo
	{
		public override string Name => "fh8";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"41-47-44-33"};
	}
}