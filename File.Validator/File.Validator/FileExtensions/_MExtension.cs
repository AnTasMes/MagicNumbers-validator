using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _MExtension : FileExtensionInfo
	{
		public override string Name => "m";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"6D-64-66-00"};
	}
}