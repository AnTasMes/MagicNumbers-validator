using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _EX01Extension : FileExtensionInfo
	{
		public override string Name => "Ex01";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"45-56-46-32"};
	}
}