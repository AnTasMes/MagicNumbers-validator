using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _BZ2Extension : FileExtensionInfo
	{
		public override string Name => "bz2";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"42-5A-68"};
	}
}