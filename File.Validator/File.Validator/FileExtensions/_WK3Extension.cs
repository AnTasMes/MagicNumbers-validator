using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _WK3Extension : FileExtensionInfo
	{
		public override string Name => "wk3";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00-00-1A-00-00-10-04-00-00-00-00-00"};
	}
}