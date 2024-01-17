using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _CDBExtension : FileExtensionInfo
	{
		public override string Name => "cdb";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"0D-F0-1D-C0"};
	}
}