using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PBTExtension : FileExtensionInfo
	{
		public override string Name => "pbt";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"78-56-34"};
	}
}