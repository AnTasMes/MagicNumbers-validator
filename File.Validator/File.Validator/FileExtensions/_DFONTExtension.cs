using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DFONTExtension : FileExtensionInfo
	{
		public override string Name => "dfont";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00-01-00-00-00"};
	}
}