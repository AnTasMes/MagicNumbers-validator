using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _AVROExtension : FileExtensionInfo
	{
		public override string Name => "avro";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4F-62-6A-01"};
	}
}