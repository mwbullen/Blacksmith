using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileManagement : MonoBehaviour {

	List<GameObject> tiles;
	public enum tileType {none, iron_ingot, steel_ingot, platinum_ingot };

	public GameObject genericTilePrefab;


	// Use this for initialization
	void Start () {
		//GameObject testTile =  createTile (tileType.iron_ingot);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public GameObject createTile(tileType newTileType) {		
		GameObject newTile = GameObject.Instantiate (genericTilePrefab);

		newTile.GetComponent<tileStatus> ().setTileType (newTileType);

		return newTile;
	}
}
