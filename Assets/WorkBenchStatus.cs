using System.Collections;
using System.Collections.Generic;
using AssemblyCSharp;
using UnityEngine;

public class WorkBenchStatus : MonoBehaviour {

	WorkBenchInfo myWorkBenchInfo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void setWorkBenchInfo (WorkBenchInfo newWorkBenchInfo) {
		myWorkBenchInfo = newWorkBenchInfo;

		for (int i = 0; i < myWorkBenchInfo.numSquares; i++) {
			//add worksquare
		}
	}
}
