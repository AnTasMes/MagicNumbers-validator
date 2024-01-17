using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _CR2Extension : FileExtensionInfo
	{
		public override string Name => "cr2";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"49-49-2A-00-10-00-00-00", "43-52"};
	}
}