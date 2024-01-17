using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DJVUExtension : FileExtensionInfo
	{
		public override string Name => "djvu";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"41-54-26-54-46-4F-52-4D", "-44-4A-56"};
	}
}