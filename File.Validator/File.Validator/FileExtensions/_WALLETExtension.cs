using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _WALLETExtension : FileExtensionInfo
	{
		public override string Name => "wallet";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"0A-16-6F-72-67-2E-62-69-74-63-6F-69-6E-2E-70-72"};
	}
}