using TerrainFactory;
using TerrainFactory.Export;
using TerrainFactory.Formats;
using TerrainFactory.Modules.ThreeD;
using System;
using System.Collections.Generic;
using System.Text;

namespace TerrainFactory.Modules.ThreeD
{
	public class STLFormat : FileFormat3D
	{
		public override string Identifier => "STL";
		public override string ReadableName => "STL 3D Model";
		public override string Command => "stl";
		public override string Description => ReadableName;
		public override string Extension => "stl";
	}
}
