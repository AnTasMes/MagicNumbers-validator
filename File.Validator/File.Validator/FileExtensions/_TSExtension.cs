using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _TSExtension : FileExtensionInfo
	{
		public override string Name => "ts";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"47"};
	}
}