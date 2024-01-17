using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _TIFFExtension : FileExtensionInfo
	{
		public override string Name => "tiff";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4D-4D-00-2A"};
	}
}