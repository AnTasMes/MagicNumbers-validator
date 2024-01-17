using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _3GPExtension : FileExtensionInfo
	{
		public override string Name => "3gp";
		public override int Offset => 4;
		public override string[] Hex => new string[] {"66-74-79-70-33-67"};
	}
}