using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinBoundary : MonoBehaviour {
	public string sceneLoad = "";

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			Destroy (other.gameObject);
			SceneManager.LoadScene (sceneLoad);
		}
	}
}
