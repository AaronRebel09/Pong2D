using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public int score= 0;
	public int x, y;

	void OnGUI(){
		GUI.Label (new Rect(x,y,100,200),"Score "+score);
	}

}
