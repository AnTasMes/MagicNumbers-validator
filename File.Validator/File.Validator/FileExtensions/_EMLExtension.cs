using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _EMLExtension : FileExtensionInfo
	{
		public override string Name => "eml";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"52-65-63-65-69-76-65-64", "3A"};
	}
}