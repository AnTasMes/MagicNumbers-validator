using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _CDIExtension : FileExtensionInfo
	{
		public override string Name => "cdi";
		public override int Offset => 0x5EAC9;
		public override string[] Hex => new string[] {"43-44-30-30-31"};
	}
}