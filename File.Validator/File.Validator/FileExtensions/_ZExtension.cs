using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ZExtension : FileExtensionInfo
	{
		public override string Name => "z";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"1F-9D", "1F-A0"};
	}
}