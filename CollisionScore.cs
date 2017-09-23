using UnityEngine;
using System.Collections;

public class CollisionScore : MonoBehaviour {	
	public GameObject Enemigo;
	public GameObject Player;

	public AudioSource audiosource;
	public AudioClip goalsound;

	void OnCollisionEnter2D(Collision2D col){
		Debug.LogError ("ColisionTriger "+col.collider.name);
				if (col.collider.name == "Ball" ) {
					Debug.LogError ("Choca Ball con Goal");
					//sound Goal
					audiosource.PlayOneShot(goalsound);
					Score scriptEnemigo = Enemigo.GetComponent<Score> ();
					scriptEnemigo.score++;
					if (scriptEnemigo.score == 5) {
						Debug.LogError (""+Enemigo+" You Win!");
						//Restart Marcadores
						Score scriptPlayer = Player.GetComponent<Score> ();
						scriptEnemigo.score = 0;
						scriptPlayer.score = 0;
					}
				}
	}

//	void OnTriggerEnter2D(Collider2D col){
//		Debug.LogError ("ColisionTriger "+col.name);
//		if (col.name == "Ball" ) {
//			Debug.LogError ("Choca Ball con Goal");
//			Score scriptEnemigo = Enemigo.GetComponent<Score> ();
//			scriptEnemigo.score++;
//			if (scriptEnemigo.score == 5) {
//				Debug.LogError (""+Enemigo+" You Win!");
//				//Restart Marcadores
//				Score scriptPlayer = Player.GetComponent<Score> ();
//				scriptEnemigo.score = 0;
//				scriptPlayer.score = 0;
//			}
//		}
//	}
		
}
