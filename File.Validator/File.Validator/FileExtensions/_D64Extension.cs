using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _D64Extension : FileExtensionInfo
	{
		public override string Name => "d64";
		public override int Offset => 0x165A4;
		public override string[] Hex => new string[] {"A0-32-41-A0-A0-A0"};
	}
}