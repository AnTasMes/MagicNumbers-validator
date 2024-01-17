using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _MPGExtension : FileExtensionInfo
	{
		public override string Name => "mpg";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"47", "00-00-01-BA", "00-00-01-B3"};
	}
}