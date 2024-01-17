using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _HAZELRULESExtension : FileExtensionInfo
	{
		public override string Name => "hazelrules";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"48-5A-4C-52-00-00-00-18"};
	}
}