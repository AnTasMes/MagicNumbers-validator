using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _8SVExtension : FileExtensionInfo
	{
		public override string Name => "8sv";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"46-4F-52-4D", "38-53-56-58"};
	}
}