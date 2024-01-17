using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _HIVExtension : FileExtensionInfo
	{
		public override string Name => "hiv";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"72-65-67-66"};
	}
}