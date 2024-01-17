using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _CPIOExtension : FileExtensionInfo
	{
		public override string Name => "cpio";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"30-37-30-37-30-37"};
	}
}