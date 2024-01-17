using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _OGAExtension : FileExtensionInfo
	{
		public override string Name => "oga";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4F-67-67-53"};
	}
}