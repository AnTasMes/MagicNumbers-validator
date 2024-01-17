using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _CDAExtension : FileExtensionInfo
	{
		public override string Name => "cda";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"52-49-46-46", "43-44-44-41"};
	}
}