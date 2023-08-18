using TerrainFactory;
using TerrainFactory.Formats;
using System.Collections.Generic;

namespace TerrainFactory.Modules.ThreeD
{

	public class TerrainFactory3DModule : TerrainFactoryModule
	{

		public override string ModuleID => "3DExporter";
		public override string ModuleName => "3D Model Exporter";
		public override string ModuleVersion => "1.0";

		public override void RegisterFormats(List<FileFormat> registry)
		{
			registry.Add(new Autodesk3DSFormat());
			registry.Add(new WavefrontOBJFormat());
			registry.Add(new STLFormat());
			registry.Add(new PLYFormat());
		}
	}
}
