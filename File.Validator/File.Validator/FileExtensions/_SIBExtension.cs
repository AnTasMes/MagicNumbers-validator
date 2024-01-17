using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _SIBExtension : FileExtensionInfo
	{
		public override string Name => "sib";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"0F-53-49-42-45-4C-49-55-53"};
	}
}