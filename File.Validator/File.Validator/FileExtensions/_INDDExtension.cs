using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _INDDExtension : FileExtensionInfo
	{
		public override string Name => "indd";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"06-06-ED-F5-D8-1D-46-E5-BD-31-EF-E7-FE-74-B7-1D"};
	}
}