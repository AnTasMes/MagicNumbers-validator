using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _TOXExtension : FileExtensionInfo
	{
		public override string Name => "tox";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"74-6F-78-33"};
	}
}