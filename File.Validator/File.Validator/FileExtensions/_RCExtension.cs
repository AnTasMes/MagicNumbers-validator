using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _RCExtension : FileExtensionInfo
	{
		public override string Name => "rc";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"53-45-51-36"};
	}
}