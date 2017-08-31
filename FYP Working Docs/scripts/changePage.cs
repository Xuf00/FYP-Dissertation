using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changePage : MonoBehaviour {

	public void nextPage() {
		SceneManager.LoadSceneAsync (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void prevPage() {
		SceneManager.LoadSceneAsync (SceneManager.GetActiveScene ().buildIndex - 1);
	}

	void Update() {
		if (Input.GetKey (KeyCode.RightArrow)) {

			nextPage ();

		} else if (Input.GetKey (KeyCode.LeftArrow)) {

			prevPage ();

		}
	}
}
