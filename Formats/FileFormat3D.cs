using HMCon;
using HMCon.Export;
using HMCon.Formats;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMCon3D
{
	public abstract class FileFormat3D : FileFormat
	{
		public override FileSupportFlags SupportedActions => FileSupportFlags.Export;

		public virtual int VertexLimit => 65535;

		public override bool ValidateSettings(ExportSettings settings, HeightData data)
		{
			if (data.GridCellCount >= VertexLimit)
			{
				Console.WriteLine($"ERROR: Cannot export more than {VertexLimit} cells in a single 3d model file! Current amount: {data.GridCellCount}");
				Console.WriteLine("        Reduce splitting interval or increase subsampling to allow for exporting 3ds Files");
				return false;
			}
			else
			{
				return true;
			}
		}

		protected override bool ExportFile(string path, ExportTask task)
		{
			using (var stream = BeginWriteStream(path))
			{
				var scene = Assimp3DExporter.CreateAssimpScene(ModelData.Create(task.data));
				Assimp3DExporter.ExportToStream(stream, scene, Extension);
			}
			return true;
		}
	}
}
