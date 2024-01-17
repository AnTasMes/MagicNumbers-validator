using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _OARExtension : FileExtensionInfo
	{
		public override string Name => "oar";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4F-41-52"};
	}
}