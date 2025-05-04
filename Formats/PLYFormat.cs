using TerrainFactory;
using TerrainFactory.Export;
using TerrainFactory.Formats;
using TerrainFactory.Modules.ThreeD;
using System;
using System.Collections.Generic;
using System.Text;

namespace TerrainFactory.Modules.ThreeD
{
	public class PLYFormat : FileFormat3D
	{
		public override string Identifier => "PLY";
		public override string ReadableName => "PLY 3D Model";
		public override string Command => "ply";
		public override string Description => ReadableName;
		public override string Extension => "ply";
	}
}
