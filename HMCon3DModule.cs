using HMCon;
using HMCon.Formats;
using System.Collections.Generic;

namespace HMCon3D
{

	public class HMCon3DModule : HMConModule
	{

		public override string ModuleID => "3DModule";
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
