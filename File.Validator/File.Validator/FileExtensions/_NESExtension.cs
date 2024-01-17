using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _NESExtension : FileExtensionInfo
	{
		public override string Name => "nes";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4E-45-53", "4E-45-53-1A"};
	}
}