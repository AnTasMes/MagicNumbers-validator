using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _FTXTExtension : FileExtensionInfo
	{
		public override string Name => "ftxt";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"46-4F-52-4D", "46-54-58-54"};
	}
}