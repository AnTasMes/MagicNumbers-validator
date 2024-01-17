using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _MNYExtension : FileExtensionInfo
	{
		public override string Name => "mny";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00-01-00-00-4D-53-49-53-41-4D-20-44-61-74-61-62-61-73-65"};
	}
}