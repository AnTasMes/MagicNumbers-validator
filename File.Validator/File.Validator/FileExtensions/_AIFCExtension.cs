using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _AIFCExtension : FileExtensionInfo
	{
		public override string Name => "aifc";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"46-4F-52-4D", "41-49-46-46"};
	}
}