using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _BINExtension : FileExtensionInfo
	{
		public override string Name => "bin";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"53-50-30-31"};
	}
}