using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileManagement : MonoBehaviour {

	List<GameObject> tiles;
	public enum tileType {none, iron_ingot, steel_ingot, platinum_ingot };

	public GameObject genericTilePrefab;

	public List <Texture2D> tileTextures;

	// Use this for initialization
	void Start () {
		GameObject testTile =  createTile (tileType.iron_ingot);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public  Texture2D getTextureforTileType(tileType t) {
		Texture2D newTileTexture = null;
		foreach (Texture2D tmpTexture in tileTextures) {
			Debug.Log (tmpTexture.name);
			if (tmpTexture.name == t.ToString()) {
				newTileTexture = tmpTexture;
			}
		}

		return newTileTexture;
	}

	public GameObject createTile(tileType newTileType) {		
		GameObject newTile = GameObject.Instantiate (genericTilePrefab);

		newTile.GetComponent<tileStatus> ().setTileType (newTileType);

		return newTile;
	}
}
