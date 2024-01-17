using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PNGExtension : FileExtensionInfo
	{
		public override string Name => "png";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"89-50-4E-47-0D-0A-1A-0A"};
	}
}