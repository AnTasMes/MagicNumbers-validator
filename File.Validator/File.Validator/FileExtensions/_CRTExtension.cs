using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _CRTExtension : FileExtensionInfo
	{
		public override string Name => "crt";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"43-36-34-20-43-41-52-54-52-49-44-47-45-20-20-20", "2D-2D-2D-2D-2D-42-45-47-49-4E-20-43-45-52-54-49-46-49-43-41-54-45-2D-2D-2D-2D-2D"};
	}
}