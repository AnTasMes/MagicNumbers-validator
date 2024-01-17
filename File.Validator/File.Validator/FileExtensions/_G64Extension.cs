using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _G64Extension : FileExtensionInfo
	{
		public override string Name => "g64";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"47-53-52-2D-31-35-34-31"};
	}
}