using HMCon;
using HMCon.Export;
using HMCon.Formats;
using HMCon3D;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMCon3D
{
	public class PLYFormat : FileFormat3D
	{
		public override string Identifier => "PLY";
		public override string ReadableName => "PLY 3D Model";
		public override string CommandKey => "ply";
		public override string Description => ReadableName;
		public override string Extension => "ply";
	}
}
