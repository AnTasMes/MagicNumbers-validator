using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _XPMExtension : FileExtensionInfo
	{
		public override string Name => "xpm";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"2F-2A-20-58-50-4D-20-2A", "2F"};
	}
}