using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DRWExtension : FileExtensionInfo
	{
		public override string Name => "drw";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"01-FF-02-04-03-02"};
	}
}