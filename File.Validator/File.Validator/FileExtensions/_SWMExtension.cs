using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _SWMExtension : FileExtensionInfo
	{
		public override string Name => "swm";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4D-53-57-49-4D-00-00-00", "D0-00-00-00-00"};
	}
}