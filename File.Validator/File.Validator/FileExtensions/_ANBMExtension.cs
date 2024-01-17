using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ANBMExtension : FileExtensionInfo
	{
		public override string Name => "anbm";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"46-4F-52-4D", "41-4E-42-4D"};
	}
}