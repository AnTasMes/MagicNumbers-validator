using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ORCExtension : FileExtensionInfo
	{
		public override string Name => "orc";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4F-52-43"};
	}
}