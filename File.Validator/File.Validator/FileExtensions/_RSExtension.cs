using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _RSExtension : FileExtensionInfo
	{
		public override string Name => "rs";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4D-5A", "52-53-56-4B-44-41-54-41"};
	}
}