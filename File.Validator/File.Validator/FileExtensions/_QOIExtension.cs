using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _QOIExtension : FileExtensionInfo
	{
		public override string Name => "qoi";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"71-6F-69-66"};
	}
}