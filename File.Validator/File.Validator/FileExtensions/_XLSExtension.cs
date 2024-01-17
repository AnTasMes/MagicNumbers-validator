using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _XLSExtension : FileExtensionInfo
	{
		public override string Name => "xls";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"D0-CF-11-E0-A1-B1-1A-E1"};
	}
}