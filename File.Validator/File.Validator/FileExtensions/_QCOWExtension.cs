using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _QCOWExtension : FileExtensionInfo
	{
		public override string Name => "qcow";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"51-46-49"};
	}
}