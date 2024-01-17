using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _RPMExtension : FileExtensionInfo
	{
		public override string Name => "rpm";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"ED-AB-EE-DB"};
	}
}