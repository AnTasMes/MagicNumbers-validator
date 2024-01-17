using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _RBXLExtension : FileExtensionInfo
	{
		public override string Name => "rbxl";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"3C-72-6F-62-6C-6F-78-21"};
	}
}