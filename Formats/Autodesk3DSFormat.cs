using TerrainFactory;
using TerrainFactory.Export;
using TerrainFactory.Formats;
using System;
using System.Collections.Generic;
using System.Text;

namespace TerrainFactory.Modules.ThreeD
{
	public class Autodesk3DSFormat : FileFormat3D
	{
		public override string Identifier => "3DS";
		public override string ReadableName => "Autodesk 3DS 3D Model";
		public override string Command => "3ds";
		public override string Description => ReadableName;
		public override string Extension => "3ds";

		public virtual int VertexLimit => 65535;

		public override bool ValidateSettings(ExportSettings settings, ElevationData data)
		{
			if(data.TotalCellCount >= VertexLimit)
			{
				ConsoleOutput.WriteError($"Cannot export more than {VertexLimit} cells in a single 3DS model file. Current amount: {data.TotalCellCount}");
				ConsoleOutput.WriteError($"Reduce splitting interval or increase sub-sampling to successfully export 3DS files.");
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
