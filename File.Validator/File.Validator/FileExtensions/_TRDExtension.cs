using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _TRDExtension : FileExtensionInfo
	{
		public override string Name => "trd";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"52-59-46-46-54-52-49-44"};
	}
}