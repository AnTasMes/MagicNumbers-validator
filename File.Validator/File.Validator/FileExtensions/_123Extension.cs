using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _123Extension : FileExtensionInfo
	{
		public override string Name => "123";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00-00-1A-00-05-10-04"};
	}
}