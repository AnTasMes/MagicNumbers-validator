using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _CSRExtension : FileExtensionInfo
	{
		public override string Name => "csr";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"2D-2D-2D-2D-2D-42-45-47-49-4E-20-43-45-52-54-49-46-49-43-41-54-45-20-52-45-51-55-45-53-54-2D-2D-2D-2D-2D"};
	}
}