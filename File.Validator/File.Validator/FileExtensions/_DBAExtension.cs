using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DBAExtension : FileExtensionInfo
	{
		public override string Name => "DBA";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"BE-BA-FE-CA", "00-01-42-44"};
	}
}