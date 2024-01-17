using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _XARExtension : FileExtensionInfo
	{
		public override string Name => "xar";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"78-61-72-21"};
	}
}