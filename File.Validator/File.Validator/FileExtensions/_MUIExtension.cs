using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _MUIExtension : FileExtensionInfo
	{
		public override string Name => "mui";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4D-5A"};
	}
}