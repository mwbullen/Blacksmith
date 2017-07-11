using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileManagement : MonoBehaviour {

	//List<GameObject> tiles;
	public enum tileType {none, iron_ingot, steel_ingot, platinum_ingot, copper_ingot };

	public GameObject[] tileIcons;

	public GameObject genericTilePrefab;


	// Use this for initialization
	void Start () {
		GameObject testTile =  createTile (tileType.copper_ingot);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public GameObject getIconforType(string typeName) {
		foreach (GameObject g in tileIcons) {
			if (g.name == typeName) {
				return GameObject.Instantiate(g);
			}
		}

		return null;
	}

	public GameObject createTile(tileType newTileType) {		
		GameObject newTile = GameObject.Instantiate (genericTilePrefab);

		newTile.GetComponent<tileStatus> ().setTileType (newTileType);

		return newTile;
	}
}
