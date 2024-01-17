using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ALIASExtension : FileExtensionInfo
	{
		public override string Name => "alias";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"62-6F-6F-6B-00-00-00-00", "6D-61-72-6B-00-00-00-00"};
	}
}