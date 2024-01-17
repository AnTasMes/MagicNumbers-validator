using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _EZ2Extension : FileExtensionInfo
	{
		public override string Name => "ez2";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"45-4D-58-32"};
	}
}