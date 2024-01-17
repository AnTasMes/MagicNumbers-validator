using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _TIFExtension : FileExtensionInfo
	{
		public override string Name => "tif";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"49-49-2A-00", "4D-4D-00-2A"};
	}
}