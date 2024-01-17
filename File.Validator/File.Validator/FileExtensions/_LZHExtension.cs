using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _LZHExtension : FileExtensionInfo
	{
		public override string Name => "lzh";
		public override int Offset => 2;
		public override string[] Hex => new string[] {"2D-68-6C-30-2D", "2D-68-6C-35-2D"};
	}
}