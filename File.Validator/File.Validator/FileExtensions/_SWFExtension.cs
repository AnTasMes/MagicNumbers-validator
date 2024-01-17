using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _SWFExtension : FileExtensionInfo
	{
		public override string Name => "swf";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"43-57-53", "46-57-53"};
	}
}