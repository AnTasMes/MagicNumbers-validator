using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _D81Extension : FileExtensionInfo
	{
		public override string Name => "d81";
		public override int Offset => 0x61819;
		public override string[] Hex => new string[] {"A0-33-44-A0-A0"};
	}
}