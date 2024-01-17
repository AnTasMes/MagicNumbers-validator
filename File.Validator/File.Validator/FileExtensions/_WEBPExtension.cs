using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _WEBPExtension : FileExtensionInfo
	{
		public override string Name => "webp";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"52-49-46-46", "57-45-42-50"};
	}
}