using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _SMUExtension : FileExtensionInfo
	{
		public override string Name => "smu";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"46-4F-52-4D", "53-4D-55-53"};
	}
}