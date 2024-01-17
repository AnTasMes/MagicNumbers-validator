using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _CINExtension : FileExtensionInfo
	{
		public override string Name => "cin";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"80-2A-5F-D7"};
	}
}