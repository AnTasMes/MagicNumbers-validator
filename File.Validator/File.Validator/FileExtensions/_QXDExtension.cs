using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _QXDExtension : FileExtensionInfo
	{
		public override string Name => "qxd";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00-00-49-49-58-50-52", "00-00-4D-4D-58-50-52"};
	}
}