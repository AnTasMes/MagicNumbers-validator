using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DOCExtension : FileExtensionInfo
	{
		public override string Name => "doc";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"D0-CF-11-E0-A1-B1-1A-E1", "0D-44-4F-43"};
	}
}