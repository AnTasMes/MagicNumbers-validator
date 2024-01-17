using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _FLMExtension : FileExtensionInfo
	{
		public override string Name => "flm";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"31-30-4C-46"};
	}
}