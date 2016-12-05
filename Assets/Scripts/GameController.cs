using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	int lives = 3;
	public GameObject popcornSpawn;
	public GameObject popcornPrefab;
	public Text popcornLives;

	public GameObject thirdLife;
	public GameObject secondLife;
	public GameObject firstLife;

	public int getLives(){
		return lives;
	}

	public void subtractLife(){
		lives -= 1;
		if (lives == 2) {
			Destroy (thirdLife.gameObject);
		} else if (lives == 1) {
			Destroy (secondLife.gameObject);
		} else if(lives == 0) {
			Destroy (firstLife.gameObject);
		}
	}

	public void spawnPopcorn (){
		popcornPrefab.transform.position = popcornSpawn.transform.position;
	}
}
