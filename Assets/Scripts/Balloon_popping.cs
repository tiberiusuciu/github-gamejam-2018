using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Balloon_popping : MonoBehaviour {

	public GameObject balloon_template;

	GameObject[] listOfBalloons = new GameObject[10];

	// Use this for initialization
	void Start() {
		for (int i = 0; i < 10; i++) {
			listOfBalloons[i] = Instantiate(balloon_template, new Vector3(Random.Range(-8f, 8f), Random.Range(5f, -3f), i * 1f), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		bool gameDone = true;
		for (int i = 0; i < 10; i++) {
			if (!(listOfBalloons[i].GetComponent<Balloon_object>().isPopped)) {
				gameDone = false;
			}
		}
		if (gameDone) {
			GameManager gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
			gm.gameIsPlaying = false;

			SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
		}
	}
}
