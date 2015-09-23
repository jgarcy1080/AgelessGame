using UnityEngine;
using System.Collections;

public class gamemanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (CountdownTimer.minutes >= 10){
			Debug.Log ("You have died")
		}

	}
}
