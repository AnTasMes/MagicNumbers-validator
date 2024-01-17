using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _TSAExtension : FileExtensionInfo
	{
		public override string Name => "tsa";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"47"};
	}
}