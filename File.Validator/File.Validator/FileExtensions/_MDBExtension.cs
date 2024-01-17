using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _MDBExtension : FileExtensionInfo
	{
		public override string Name => "mdb";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00-01-00-00-53-74-61-6E-64-61-72-64-20-4A-65-74-20-44-42"};
	}
}