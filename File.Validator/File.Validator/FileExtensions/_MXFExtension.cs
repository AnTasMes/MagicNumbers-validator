using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _MXFExtension : FileExtensionInfo
	{
		public override string Name => "mxf";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"06-0E-2B-34-02-05-01-01-0D-01-02-01-01-02"};
	}
}