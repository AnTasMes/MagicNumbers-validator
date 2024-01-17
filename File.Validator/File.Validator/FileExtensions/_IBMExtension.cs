using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _IBMExtension : FileExtensionInfo
	{
		public override string Name => "ibm";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"46-4F-52-4D", "49-4C-42-4D"};
	}
}