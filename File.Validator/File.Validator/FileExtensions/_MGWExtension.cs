using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _MGWExtension : FileExtensionInfo
	{
		public override string Name => "mgw";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"6D-61-69-6E-2E-62-73"};
	}
}