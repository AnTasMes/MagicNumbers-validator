using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PICExtension : FileExtensionInfo
	{
		public override string Name => "PIC";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00"};
	}
}