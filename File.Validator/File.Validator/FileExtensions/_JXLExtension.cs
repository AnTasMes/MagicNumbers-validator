using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _JXLExtension : FileExtensionInfo
	{
		public override string Name => "jxl";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00-00-00-0C-4A-58-4C-20-0D-0A-87-0A", "FF-0A"};
	}
}