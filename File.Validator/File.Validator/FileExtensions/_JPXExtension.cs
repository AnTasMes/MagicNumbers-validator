using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _JPXExtension : FileExtensionInfo
	{
		public override string Name => "jpx";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"FF-4F-FF-51"};
	}
}