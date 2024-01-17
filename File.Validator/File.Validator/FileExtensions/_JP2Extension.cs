using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _JP2Extension : FileExtensionInfo
	{
		public override string Name => "jp2";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00-00-00-0C-6A-50-20-20-0D-0A-87-0A", "FF-4F-FF-51"};
	}
}