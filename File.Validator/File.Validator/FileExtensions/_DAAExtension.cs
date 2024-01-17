using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DAAExtension : FileExtensionInfo
	{
		public override string Name => "daa";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"44-41-41"};
	}
}