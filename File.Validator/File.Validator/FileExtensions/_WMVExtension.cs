using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _WMVExtension : FileExtensionInfo
	{
		public override string Name => "wmv";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"30-26-B2-75-8E-66-CF-11", "A6-D9-00-AA-00-62-CE-6C"};
	}
}