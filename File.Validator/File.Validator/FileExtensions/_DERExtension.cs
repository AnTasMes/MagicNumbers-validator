using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DERExtension : FileExtensionInfo
	{
		public override string Name => "der";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"30-82"};
	}
}