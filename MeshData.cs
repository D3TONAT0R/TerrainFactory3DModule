using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace TerrainFactory.Modules.ThreeD
{
	internal class MeshData
	{
		public string name = null;
		public List<Vector3> vertices = new List<Vector3>();
		public List<int> tris = new List<int>();
		public List<Vector2> uvs = new List<Vector2>();
	}
}
