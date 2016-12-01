using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {
	public string sceneLoad = "";

	public void SceneChange () {
		SceneManager.LoadScene (sceneLoad);
	}
}
