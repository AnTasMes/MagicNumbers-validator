using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PCVExtension : FileExtensionInfo
	{
		public override string Name => "pcv";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"55-55-AA-AA"};
	}
}