using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DPXExtension : FileExtensionInfo
	{
		public override string Name => "dpx";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"53-44-50-58", "58-50-44-53"};
	}
}