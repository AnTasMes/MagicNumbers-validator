using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DBExtension : FileExtensionInfo
	{
		public override string Name => "db";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"53-51-4C-69-74-65-20-66", "6F-72-6D-61-74-20-33-00"};
	}
}