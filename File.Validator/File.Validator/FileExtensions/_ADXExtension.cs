using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ADXExtension : FileExtensionInfo
	{
		public override string Name => "adx";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"03-00-00-00-41-50-50-52"};
	}
}