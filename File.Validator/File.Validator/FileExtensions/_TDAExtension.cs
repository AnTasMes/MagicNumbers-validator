using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _TDAExtension : FileExtensionInfo
	{
		public override string Name => "TDA";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00-01-44-54"};
	}
}