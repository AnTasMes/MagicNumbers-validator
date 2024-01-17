using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _WK1Extension : FileExtensionInfo
	{
		public override string Name => "wk1";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00-00-02-00-06-04-06-00-08-00-00-00-00-00"};
	}
}