using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DRCExtension : FileExtensionInfo
	{
		public override string Name => "drc";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"44-52-41-43-4F"};
	}
}