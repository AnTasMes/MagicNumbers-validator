using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _YTRExtension : FileExtensionInfo
	{
		public override string Name => "YTR";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00"};
	}
}