using HMCon;
using HMCon.Export;
using HMCon.Formats;
using HMCon3D;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMCon3D
{
	public class STLFormat : FileFormat3D
	{
		public override string Identifier => "STL";
		public override string ReadableName => "STL 3D Model";
		public override string CommandKey => "stl";
		public override string Description => ReadableName;
		public override string Extension => "stl";
	}
}
