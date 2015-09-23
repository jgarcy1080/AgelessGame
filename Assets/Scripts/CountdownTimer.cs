using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {

	public Text countdownText;
	public static float seconds;
	public static float minutes;
	//public float timeLimit = 5f;
	// Use this for initialization
	void Start () {
		countdownText = GetComponent<Text>() as Text;
		}
	
	// Update is called once per frame
	void Update () {
		minutes = (int)(Time.timeSinceLevelLoad / 60f);
		seconds = (int)(Time.timeSinceLevelLoad % 60f);
		countdownText.text = minutes.ToString("00") + ":" + seconds.ToString("00");

	
	}
}
