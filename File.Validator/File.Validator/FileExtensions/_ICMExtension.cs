using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ICMExtension : FileExtensionInfo
	{
		public override string Name => "icm";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4B-43-4D-53"};
	}
}