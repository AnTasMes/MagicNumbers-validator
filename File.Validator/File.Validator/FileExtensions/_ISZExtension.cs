using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ISZExtension : FileExtensionInfo
	{
		public override string Name => "isz";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"49-73-5A-21"};
	}
}