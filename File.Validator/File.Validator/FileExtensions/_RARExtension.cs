using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _RARExtension : FileExtensionInfo
	{
		public override string Name => "rar";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"52-61-72-21-1A-07-00", "52-61-72-21-1A-07-01-00"};
	}
}