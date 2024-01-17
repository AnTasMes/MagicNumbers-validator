using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _MKSExtension : FileExtensionInfo
	{
		public override string Name => "mks";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"1A-45-DF-A3"};
	}
}