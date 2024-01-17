using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _EZ3Extension : FileExtensionInfo
	{
		public override string Name => "ez3";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"45-4D-55-33"};
	}
}