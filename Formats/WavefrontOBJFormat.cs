using TerrainFactory;
using TerrainFactory.Export;
using TerrainFactory.Formats;
using TerrainFactory.Modules.ThreeD;
using System;
using System.Collections.Generic;
using System.Text;

namespace TerrainFactory.Modules.ThreeD
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
