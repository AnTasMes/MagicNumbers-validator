using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _TTEExtension : FileExtensionInfo
	{
		public override string Name => "tte";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00-01-00-00-00"};
	}
}