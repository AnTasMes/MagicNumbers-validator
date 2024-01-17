using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ANIMExtension : FileExtensionInfo
	{
		public override string Name => "anim";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"46-4F-52-4D", "41-4E-49-4D"};
	}
}