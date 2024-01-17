using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ASCExtension : FileExtensionInfo
	{
		public override string Name => "asc";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"2D-2D-2D-2D-2D-42-45-47-49-4E-20-50-47-50-20-50-55-42-4C-49-43-20-4B-45-49-20-42-4C-4F-43-4B-2D-2D-2D-2D-2D"};
	}
}