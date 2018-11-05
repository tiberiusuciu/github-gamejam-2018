using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon_popping : MonoBehaviour {

	public GameObject balloon_template;

	// Use this for initialization
	void Start() {
		for (int i = 0; i < 10; i++) {
			Instantiate(balloon_template, new Vector3(Random.Range(-8f, 8f), Random.Range(5f, -3f), i * 1f), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
			
	}
}
