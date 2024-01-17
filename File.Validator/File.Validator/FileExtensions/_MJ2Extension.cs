using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _MJ2Extension : FileExtensionInfo
	{
		public override string Name => "mj2";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"FF-4F-FF-51"};
	}
}