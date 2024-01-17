using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _TTFExtension : FileExtensionInfo
	{
		public override string Name => "ttf";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00-01-00-00-00"};
	}
}