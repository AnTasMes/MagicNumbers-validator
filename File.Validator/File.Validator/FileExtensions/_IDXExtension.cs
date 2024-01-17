using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _IDXExtension : FileExtensionInfo
	{
		public override string Name => "idx";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"49-4E-44-58"};
	}
}