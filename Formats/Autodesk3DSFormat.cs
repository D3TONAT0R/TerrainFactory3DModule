using HMCon;
using HMCon.Export;
using HMCon.Formats;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMCon3D
{
	public class Autodesk3DSFormat : FileFormat3D
	{
		public override string Identifier => "3DS";
		public override string ReadableName => "Autodesk 3DS 3D Model";
		public override string CommandKey => "3ds";
		public override string Description => ReadableName;
		public override string Extension => "3ds";
	}
}
