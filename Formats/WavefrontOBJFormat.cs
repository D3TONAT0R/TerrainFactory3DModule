using HMCon;
using HMCon.Export;
using HMCon.Formats;
using HMCon3D;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMCon3D
{
	public class WavefrontOBJFormat : FileFormat3D
	{
		public override string Identifier => "OBJ";
		public override string ReadableName => "OBJ 3D Model";
		public override string CommandKey => "obj";
		public override string Description => ReadableName;
		public override string Extension => "obj";
	}
}
