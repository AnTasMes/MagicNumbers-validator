using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _WASMExtension : FileExtensionInfo
	{
		public override string Name => "wasm";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00-61-73-6D"};
	}
}