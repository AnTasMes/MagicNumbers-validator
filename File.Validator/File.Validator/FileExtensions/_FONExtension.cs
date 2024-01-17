using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _FONExtension : FileExtensionInfo
	{
		public override string Name => "fon";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4D-5A"};
	}
}