using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _VOCExtension : FileExtensionInfo
	{
		public override string Name => "voc";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"43-72-65-61-74-69-76-65-20-56-6F-69-63-65-20-46-69-6C-65-1A-1A-00"};
	}
}