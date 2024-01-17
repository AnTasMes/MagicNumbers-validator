using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _MUSExtension : FileExtensionInfo
	{
		public override string Name => "mus";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"46-4F-52-4D", "53-4D-55-53", "46-4F-52-4D", "43-4D-55-53"};
	}
}