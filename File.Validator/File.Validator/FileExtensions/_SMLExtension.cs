using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _SMLExtension : FileExtensionInfo
	{
		public override string Name => "sml";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"3A-29-0A"};
	}
}