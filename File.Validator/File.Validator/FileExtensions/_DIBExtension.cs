using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DIBExtension : FileExtensionInfo
	{
		public override string Name => "dib";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"42-4D"};
	}
}