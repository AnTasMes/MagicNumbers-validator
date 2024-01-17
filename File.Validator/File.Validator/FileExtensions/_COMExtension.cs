using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _COMExtension : FileExtensionInfo
	{
		public override string Name => "com";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"C9"};
	}
}