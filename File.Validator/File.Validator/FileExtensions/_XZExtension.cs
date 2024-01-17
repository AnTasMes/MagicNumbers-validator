using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _XZExtension : FileExtensionInfo
	{
		public override string Name => "xz";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"FD-37-7A-58-5A-00"};
	}
}