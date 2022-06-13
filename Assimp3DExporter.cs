using HMCon;
using HMCon.Export;
using Assimp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using HMCon.Formats;
using Assimp.Unmanaged;

namespace HMCon3D
{
	internal static class Assimp3DExporter
	{

		public static Scene CreateAssimpScene(ModelData model)
		{
			try
			{
				bool makeChildNodes = model.meshes.Count > 1;
				var scene = new Scene();
				scene.RootNode = new Node("Root");
				scene.Materials.Add(new Material() { Name = "DefaultMaterial" });
				for (int i = 0; i < model.meshes.Count; i++)
				{
					var mesh = model.meshes[i];
					Mesh m = new Mesh();
					foreach (Vector3 v in mesh.vertices) m.Vertices.Add(new Vector3D(v.X, v.Y, v.Z));
					m.SetIndices(mesh.tris.ToArray(), 3);
					m.MaterialIndex = 0;
					int index = scene.Meshes.Count;
					scene.Meshes.Add(m);
					if (makeChildNodes)
					{
						Node n = new Node("mesh" + (i + 1));
						n.MeshIndices.Add(index);
						scene.RootNode.Children.Add(n);
					}
					else
					{
						scene.RootNode.MeshIndices.Add(0);
					}
				}
				return scene;
			}
			catch (Exception e)
			{
				ConsoleOutput.WriteError("ERROR while creating 3D data for Assimp:");
				ConsoleOutput.WriteLine(e.ToString());
				throw e;
			}
		}

		public static void ExportToStream(FileStream stream, Scene scene, string extension)
		{
			AssimpContext context = new AssimpContext();
			var blob = context.ExportToBlob(scene, extension);
			stream.Write(blob.Data, 0, blob.Data.Length);
			context.Dispose();
		}
	}
}