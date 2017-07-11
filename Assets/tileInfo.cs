using System;
using UnityEngine;
using UnityEngine.UI;

namespace AssemblyCSharp
{
	[Serializable]
	public class tileInfo
	{
		public tileManagement.tileType myTileType;
		public string Name;
		public UnityEngine.Texture2D imageTexture;
		public UnityEngine.GameObject parentGameObject;

		public tileInfo ()
		{
		}
	}
}

