using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _OCXExtension : FileExtensionInfo
	{
		public override string Name => "ocx";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4D-5A"};
	}
}