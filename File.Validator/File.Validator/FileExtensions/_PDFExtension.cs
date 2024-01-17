using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PDFExtension : FileExtensionInfo
	{
		public override string Name => "pdf";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"25-50-44-46-2D"};
	}
}