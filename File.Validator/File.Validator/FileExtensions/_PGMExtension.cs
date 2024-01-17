using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PGMExtension : FileExtensionInfo
	{
		public override string Name => "pgm";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"50-32-0A", "50-35-0A"};
	}
}