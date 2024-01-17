using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _IDENTIFIERExtension : FileExtensionInfo
	{
		public override string Name => "Identifier";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"5B-5A-6F-6E-65-54-72-61", "6E-73-66-65-72-5D"};
	}
}