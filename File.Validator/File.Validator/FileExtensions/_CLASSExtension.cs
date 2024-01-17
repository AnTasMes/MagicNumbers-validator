using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _CLASSExtension : FileExtensionInfo
	{
		public override string Name => "class";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"CA-FE-BA-BE"};
	}
}