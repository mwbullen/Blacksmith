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

		public Sprite mySprite;
		public UnityEngine.GameObject parentGameObject;

		public tileInfo ()
		{
		}
	}
}

