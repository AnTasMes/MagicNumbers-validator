using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _LZExtension : FileExtensionInfo
	{
		public override string Name => "lz";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4C-5A-49-50"};
	}
}