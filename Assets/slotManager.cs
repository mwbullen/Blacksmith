using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotManager : MonoBehaviour {

	public int numberslots = 64;

	public GameObject slotPrefab;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < numberslots; i++) {
			GameObject newslot = GameObject.Instantiate (slotPrefab);
			newslot.transform.parent = gameObject.transform;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
