using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PSAFE3Extension : FileExtensionInfo
	{
		public override string Name => "psafe3";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"50-57-53-33"};
	}
}