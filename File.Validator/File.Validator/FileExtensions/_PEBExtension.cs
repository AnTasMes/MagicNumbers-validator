using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PEBExtension : FileExtensionInfo
	{
		public override string Name => "peb";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"78-56-34"};
	}
}