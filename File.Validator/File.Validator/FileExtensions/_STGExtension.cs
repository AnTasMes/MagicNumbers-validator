using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _STGExtension : FileExtensionInfo
	{
		public override string Name => "stg";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4D-49-4C-20"};
	}
}