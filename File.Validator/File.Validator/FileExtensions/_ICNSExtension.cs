using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ICNSExtension : FileExtensionInfo
	{
		public override string Name => "icns";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"69-63-6E-73"};
	}
}