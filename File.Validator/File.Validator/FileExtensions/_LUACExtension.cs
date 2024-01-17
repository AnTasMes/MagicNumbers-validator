using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _LUACExtension : FileExtensionInfo
	{
		public override string Name => "luac";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"1B-4C-75-61"};
	}
}