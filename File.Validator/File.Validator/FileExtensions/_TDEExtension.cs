using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _TDEExtension : FileExtensionInfo
	{
		public override string Name => "tde";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"20-02-01-62-A0-1E-AB-07", "02-00-00-00"};
	}
}