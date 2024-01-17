using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _HLPExtension : FileExtensionInfo
	{
		public override string Name => "hlp";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"3F-5F"};
	}
}