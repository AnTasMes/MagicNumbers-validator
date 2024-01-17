using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _T64Extension : FileExtensionInfo
	{
		public override string Name => "t64";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"43-36-34-20-74-61-70-65-20-69-6D-61-67-65-20-66-69-6C-65"};
	}
}