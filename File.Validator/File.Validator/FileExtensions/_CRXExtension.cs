using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _CRXExtension : FileExtensionInfo
	{
		public override string Name => "crx";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"43-72-32-34"};
	}
}