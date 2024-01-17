using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DSSExtension : FileExtensionInfo
	{
		public override string Name => "dss";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"02-64-73-73", "03-64-73-73"};
	}
}