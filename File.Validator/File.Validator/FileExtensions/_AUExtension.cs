using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _AUExtension : FileExtensionInfo
	{
		public override string Name => "au";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"2E-73-6E-64"};
	}
}