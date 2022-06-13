using HMCon;
using HMCon.Export;
using HMCon.Formats;
using HMCon.Import;
using System;
using System.Collections.Generic;

namespace HMCon3D {

	[ModuleInfo("3DModule", "3D exporter v1.0")]
	public class HMCon3DModule : HMConModule {

		public override HMConCommandHandler GetCommandHandler() {
			return null;
		}

		public override void RegisterFormats(List<FileFormat> registry)
		{
			registry.Add(new Autodesk3DSFormat());
			registry.Add(new WavefrontOBJFormat());
			registry.Add(new STLFormat());
			registry.Add(new PLYFormat());
		}
	}
}
