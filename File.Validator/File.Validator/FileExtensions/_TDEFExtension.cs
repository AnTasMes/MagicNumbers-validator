using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _TDEFExtension : FileExtensionInfo
	{
		public override string Name => "TDEF";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"54-44-45-46"};
	}
}