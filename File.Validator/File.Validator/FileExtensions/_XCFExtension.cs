using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _XCFExtension : FileExtensionInfo
	{
		public override string Name => "xcf";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"67-69-6D-70-20-78-63-66"};
	}
}