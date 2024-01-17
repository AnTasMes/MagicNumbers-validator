using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _FLPExtension : FileExtensionInfo
	{
		public override string Name => "flp";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"46-4C-68-64"};
	}
}