using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _KEYExtension : FileExtensionInfo
	{
		public override string Name => "key";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"2D-2D-2D-2D-2D-42-45-47-49-4E-20-50-52-49-56-41-54-45-20-4B-45-59-2D-2D-2D-2D-2D", "2D-2D-2D-2D-2D-42-45-47-49-4E-20-44-53-41-20-50-52-49-56-41-54-45-20-4B-45-59-2D-2D-2D-2D-2D", "2D-2D-2D-2D-2D-42-45-47-49-4E-20-52-45-41-20-50-52-49-56-41-54-45-20-4B-45-59-2D-2D-2D-2D-2D"};
	}
}