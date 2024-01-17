using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _WKSExtension : FileExtensionInfo
	{
		public override string Name => "wks";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"0E-57-4B-53"};
	}
}