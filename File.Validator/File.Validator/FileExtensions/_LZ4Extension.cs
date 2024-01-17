using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _LZ4Extension : FileExtensionInfo
	{
		public override string Name => "lz4";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"04-22-4D-18"};
	}
}