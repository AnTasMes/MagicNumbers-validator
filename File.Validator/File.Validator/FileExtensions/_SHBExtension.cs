using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _SHBExtension : FileExtensionInfo
	{
		public override string Name => "shb";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"52-49-46-46-73-68-62-35"};
	}
}