using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _TOASTExtension : FileExtensionInfo
	{
		public override string Name => "toast";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"45-52-02-00-00-00", "8B-45-52-02-00-00-00"};
	}
}