using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PLExtension : FileExtensionInfo
	{
		public override string Name => "pl";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"D0-4F-50-53"};
	}
}