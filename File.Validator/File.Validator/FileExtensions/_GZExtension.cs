using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _GZExtension : FileExtensionInfo
	{
		public override string Name => "gz";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"1F-8B"};
	}
}