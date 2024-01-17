using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _XMLExtension : FileExtensionInfo
	{
		public override string Name => "xml";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"3C-3F-78-6D-6C-20", "3C-00-3F-00-78-00-6D-00", "6C-00-20", "00-3C-00-3F-00-78-00-6D", "00-6C-00-20", "3C-00-00-00-3F-00-00-00", "78-00-00-00-6D-00-00-00", "6C-00-00-00-20-00-00-00", "00-00-00-3C-00-00-00-3F", "00-00-00-78-00-00-00-6D", "00-00-00-6C-00-00-00-20", "4C-6F-A7-94-93-40"};
	}
}