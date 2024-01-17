using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DTDExtension : FileExtensionInfo
	{
		public override string Name => "dtd";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"07-64-74-32-64-64-74-64"};
	}
}