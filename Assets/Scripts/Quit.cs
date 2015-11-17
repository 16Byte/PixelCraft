using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	public int xpos;
	public int ypos;
	public int height;
	public int width;

	void Update() {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
			Debug.Log("Closing Game");
		}
	}

	void OnGUI() {
		if(GUI.Button(new Rect(xpos, ypos, width, height), "Close Game")) {
			Application.Quit();
			Debug.Log ("Closing Game");
		}
	}

}
