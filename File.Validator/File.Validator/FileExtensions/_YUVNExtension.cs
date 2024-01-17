using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _YUVNExtension : FileExtensionInfo
	{
		public override string Name => "yuvn";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"46-4F-52-4D", "59-55-56-4E"};
	}
}