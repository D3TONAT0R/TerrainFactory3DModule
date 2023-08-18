using TerrainFactory;
using TerrainFactory.Export;
using TerrainFactory.Formats;
using System;
using System.Collections.Generic;
using System.Text;

namespace TerrainFactory.Modules.ThreeD
{
	public abstract class FileFormat3D : FileFormat
	{
		public override FileSupportFlags SupportedActions => FileSupportFlags.Export;

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
