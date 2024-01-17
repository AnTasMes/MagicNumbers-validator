using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _WOFFExtension : FileExtensionInfo
	{
		public override string Name => "woff";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"77-4F-46-46"};
	}
}