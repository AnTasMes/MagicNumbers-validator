using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _CWKExtension : FileExtensionInfo
	{
		public override string Name => "cwk";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"05-07-00-00-42-4F-42-4F", "05-07-00-00-00-00-00-00", "00-00-00-00-00-01", "06-07-E1-00-42-4F-42-4F", "06-07-E1-00-00-00-00-00", "00-00-00-00-00-01"};
	}
}