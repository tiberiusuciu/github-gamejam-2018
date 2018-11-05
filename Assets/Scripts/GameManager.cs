using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public double timeInterval;

	string[] available_games = { "BalloonPop" };
	double currentTime;
	public bool gameIsPlaying = false;


	private static bool created = false;

	void Awake() {
		if (!created) {
			DontDestroyOnLoad(this.gameObject);
			created = true;
			Debug.Log("Awake: " + this.gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		currentTime = Time.frameCount;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.frameCount >= currentTime + timeInterval && !gameIsPlaying) {
			SceneManager.LoadScene(available_games[0], LoadSceneMode.Single);
			gameIsPlaying = true;
		}
	}
}
