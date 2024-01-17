using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _GIFExtension : FileExtensionInfo
	{
		public override string Name => "gif";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"47-49-46-38-37-61", "47-49-46-38-39-61"};
	}
}