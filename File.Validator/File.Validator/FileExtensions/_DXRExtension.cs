using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DXRExtension : FileExtensionInfo
	{
		public override string Name => "dxr";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"58-46-49-52", "33-39-56-4D"};
	}
}