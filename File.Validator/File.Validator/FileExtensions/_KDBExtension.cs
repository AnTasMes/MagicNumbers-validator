using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _KDBExtension : FileExtensionInfo
	{
		public override string Name => "kdb";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"37-48-03-02-00-00-00-00", "58-35-30-39-4B-45-59"};
	}
}