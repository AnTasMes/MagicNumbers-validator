using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _CNTExtension : FileExtensionInfo
	{
		public override string Name => "cnt";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"3A-42-61-73-65-20"};
	}
}