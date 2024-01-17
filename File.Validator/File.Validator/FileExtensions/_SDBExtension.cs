using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _SDBExtension : FileExtensionInfo
	{
		public override string Name => "sdb";
		public override int Offset => 8;
		public override string[] Hex => new string[] {"73-64-62-66"};
	}
}