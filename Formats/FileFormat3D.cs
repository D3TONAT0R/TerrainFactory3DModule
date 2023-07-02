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
