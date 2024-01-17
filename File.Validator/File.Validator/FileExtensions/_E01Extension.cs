using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _E01Extension : FileExtensionInfo
	{
		public override string Name => "e01";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"45-56-46"};
	}
}