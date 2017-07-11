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

			/*
			Sprite spriteTexture = (Sprite) Resources.Load (targetName);

			Debug.Log (spriteTexture);
			return (spriteTexture);
			//return Sprite.Create(spriteTexture, new Rect(0f, 0f, spriteTexture.width, spriteTexture.height), new Vector2(.5f, .5f));
			*/
		}
	}
}

