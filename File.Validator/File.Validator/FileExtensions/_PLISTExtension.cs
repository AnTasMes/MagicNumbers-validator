using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PLISTExtension : FileExtensionInfo
	{
		public override string Name => "plist";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"62-70-6C-69-73-74"};
	}
}