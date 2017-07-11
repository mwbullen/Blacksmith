using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AssemblyCSharp;

public class tileStatus : MonoBehaviour {

	public tileInfo myTileInfo;

	// Use this for initialization
	void Start () {

	}

	void refreshSprite() {
		Image imageComponent = gameObject.GetComponent<Image> ();

		imageComponent.sprite = myTileInfo.mySprite;
	}

	public void setTileType(tileManagement.tileType newTileType) {
		GameObject gameControl = GameObject.Find ("gameControl");

		myTileInfo.mySprite = SpriteManager.getSprite(newTileType.ToString());
			
		//Texture2D myTexture = gameControl.GetComponent<tileManagement>().getTextureforTileType (newTileType);
		//myTileInfo.imageTexture = myTexture;

		myTileInfo.myTileType = newTileType;

		refreshSprite ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
