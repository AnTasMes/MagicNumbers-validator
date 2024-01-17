using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PSTExtension : FileExtensionInfo
	{
		public override string Name => "pst";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"21-42-44-4E"};
	}
}