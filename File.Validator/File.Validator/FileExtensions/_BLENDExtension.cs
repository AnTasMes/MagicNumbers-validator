using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _BLENDExtension : FileExtensionInfo
	{
		public override string Name => "blend";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"42-4C-45-4E-44-45-52"};
	}
}