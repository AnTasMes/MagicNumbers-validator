using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ACEExtension : FileExtensionInfo
	{
		public override string Name => "ace";
		public override int Offset => 7;
		public override string[] Hex => new string[] {"2A-2A-41-43-45-2A-2A"};
	}
}