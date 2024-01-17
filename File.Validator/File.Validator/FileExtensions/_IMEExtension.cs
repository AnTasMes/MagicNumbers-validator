using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _IMEExtension : FileExtensionInfo
	{
		public override string Name => "ime";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4D-5A"};
	}
}