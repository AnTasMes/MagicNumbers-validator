using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _VBEExtension : FileExtensionInfo
	{
		public override string Name => "vbe";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"23-40-7E-5E"};
	}
}