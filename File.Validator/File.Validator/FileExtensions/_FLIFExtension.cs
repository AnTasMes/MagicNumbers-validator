using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _FLIFExtension : FileExtensionInfo
	{
		public override string Name => "flif";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"46-4C-49-46"};
	}
}