using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _EVTExtension : FileExtensionInfo
	{
		public override string Name => "evt";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4C-66-4C-65"};
	}
}