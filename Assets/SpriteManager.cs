using System;
using UnityEngine;

namespace AssemblyCSharp
{
	public static class SpriteManager
	{
		public static Sprite getSprite(string targetName) {
			Sprite[] allSprites = Resources.FindObjectsOfTypeAll<Sprite> ();

			Debug.Log (allSprites.Length);
			foreach (Sprite s in allSprites) {
				Debug.Log (s.name);
				if (s.name == targetName) {
					return s;
				}
			}
			return null;
		}
	}
}

