using HMCon;
using HMCon.Export;
using HMCon.Formats;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMCon3D
{
	public class Autodesk3DSFormat : FileFormat
	{
		public override string Identifier => "3DS";
		public override string ReadableName => "Autodesk 3DS 3D Model";
		public override string CommandKey => "3ds";
		public override string Description => ReadableName;
		public override string Extension => "3ds";
		public override FileSupportFlags SupportedActions => FileSupportFlags.Export;

		public override bool ValidateSettings(ExportSettings settings, HeightData data)
		{
			if (data.GridCellCount >= 65535)
			{
				Console.WriteLine("ERROR: Cannot export more than 65535 cells in a single 3ds file! Current amount: " + data.GridCellCount);
				Console.WriteLine("       Reduce splitting interval or increase subsampling to allow for exporting 3ds Files");
				return false;
			}
			else
			{
				return true;
			}
		}

		protected override bool ExportFile(string path, ExportJob job)
		{
			var model = ModelData.Create(job.data);
			using (var stream = BeginWriteStream(path))
			{
				//TODO: use single library, perhaps look for a better alternative?
				if (HMCon3DModule.exported3dFiles < 50)
				{
					new Aspose3DExporter(model).WriteFile(stream, this);
				}
				else
				{
					ConsoleOutput.WriteWarning("Aspose3D's export limit was reached! Attempting to export using Assimp, which may throw an error.");
					new Assimp3DExporter(model).WriteFile(stream, this);
				}
				HMCon3DModule.exported3dFiles++;
			}
			return true;
		}
	}
}
