using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _SYSExtension : FileExtensionInfo
	{
		public override string Name => "sys";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4D-5A"};
	}
}