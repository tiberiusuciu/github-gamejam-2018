using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon_object : MonoBehaviour {

	public Sprite pop_sprite;

	private AudioSource audioSource;
	private bool isPopped = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		if (!isPopped) {
			// Destroy(gameObject);
			isPopped = true;
			SpriteRenderer sr = GetComponent<SpriteRenderer>();
			sr.sprite = pop_sprite;
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 10);
			transform.Rotate(0, 0, Random.Range(0f, 35f));
			audioSource = GetComponent<AudioSource>();
			audioSource.Play(0);
		}
	}
}
