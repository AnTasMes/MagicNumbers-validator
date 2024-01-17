using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DIRExtension : FileExtensionInfo
	{
		public override string Name => "dir";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"52-49-46-58", "4D-56-39-33", "58-46-49-52", "33-39-56-4D"};
	}
}