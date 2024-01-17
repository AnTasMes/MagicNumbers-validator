using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _3G2Extension : FileExtensionInfo
	{
		public override string Name => "3g2";
		public override int Offset => 4;
		public override string[] Hex => new string[] {"66-74-79-70-33-67"};
	}
}