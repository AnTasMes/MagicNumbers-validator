using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PSExtension : FileExtensionInfo
	{
		public override string Name => "ps";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"25-21-50-53"};
	}
}