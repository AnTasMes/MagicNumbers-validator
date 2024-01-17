using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _P25Extension : FileExtensionInfo
	{
		public override string Name => "p25";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"65-87-78-56"};
	}
}