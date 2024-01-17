using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DCRExtension : FileExtensionInfo
	{
		public override string Name => "dcr";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"52-49-46-58", "46-47-44-4D", "58-46-49-52", "4D-44-47-46", "58-46-49-52-4D-44-47-46"};
	}
}