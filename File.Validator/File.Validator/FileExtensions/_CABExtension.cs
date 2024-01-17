using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _CABExtension : FileExtensionInfo
	{
		public override string Name => "cab";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4D-53-43-46", "49-53-63-28"};
	}
}