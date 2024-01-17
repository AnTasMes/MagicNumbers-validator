using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ZLIBExtension : FileExtensionInfo
	{
		public override string Name => "zlib";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"78-01", "78-5E", "78-9C", "78-DA", "78-20", "78-7D", "78-BB", "78-F9"};
	}
}