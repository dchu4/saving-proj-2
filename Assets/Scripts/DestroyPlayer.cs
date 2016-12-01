using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DestroyPlayer : MonoBehaviour {
	public GameController gameController;
	public string sceneLoad;

	void OnTriggerEnter2D(Collider2D other){
		
		gameController.subtractLife ();

		if (other.tag == "Player" && gameController.getLives () > 0) {
			gameController.spawnPopcorn ();
		} else if(gameController.getLives() < 1){
			SceneManager.LoadScene (sceneLoad);
		}
	}
}
