using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _WOFF2Extension : FileExtensionInfo
	{
		public override string Name => "woff2";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"77-4F-46-32"};
	}
}