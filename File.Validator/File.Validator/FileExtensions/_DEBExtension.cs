using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DEBExtension : FileExtensionInfo
	{
		public override string Name => "deb";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"21-3C-61-72-63-68-3E-0A"};
	}
}