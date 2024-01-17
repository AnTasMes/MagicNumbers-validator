using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PPMExtension : FileExtensionInfo
	{
		public override string Name => "ppm";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"50-33-0A", "50-36-0A"};
	}
}