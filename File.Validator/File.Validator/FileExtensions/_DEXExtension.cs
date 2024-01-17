using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DEXExtension : FileExtensionInfo
	{
		public override string Name => "dex";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"64-65-78-0A-30-33-35-00"};
	}
}