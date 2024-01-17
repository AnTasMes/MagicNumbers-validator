using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PPKExtension : FileExtensionInfo
	{
		public override string Name => "ppk";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"50-75-54-54-59-2D-55-73-65-72-2D-4B-65-79-2D-46-69-6C-65-2D-32-3A", "50-75-54-54-59-2D-55-73-65-72-2D-4B-65-79-2D-46-69-6C-65-2D-33-3A"};
	}
}