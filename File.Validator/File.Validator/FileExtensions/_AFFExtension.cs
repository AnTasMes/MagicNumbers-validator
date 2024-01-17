using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _AFFExtension : FileExtensionInfo
	{
		public override string Name => "aff";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"41-46-46"};
	}
}