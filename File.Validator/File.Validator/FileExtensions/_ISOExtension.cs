using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ISOExtension : FileExtensionInfo
	{
		public override string Name => "iso";
		public override int Offset => 0x8001;
		public override string[] Hex => new string[] {"43-44-30-30-31", "45-4D-55-33"};
	}
}