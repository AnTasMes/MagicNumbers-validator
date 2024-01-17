using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _RTFExtension : FileExtensionInfo
	{
		public override string Name => "rtf";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"7B-5C-72-74-66-31"};
	}
}