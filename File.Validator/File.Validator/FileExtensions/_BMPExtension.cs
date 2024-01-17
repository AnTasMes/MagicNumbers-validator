using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _BMPExtension : FileExtensionInfo
	{
		public override string Name => "bmp";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"42-4D"};
	}
}