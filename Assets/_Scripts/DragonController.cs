﻿using UnityEngine;
using System.Collections;

public class DragonController : MonoBehaviour {

	// PUBLIC VARIABLES
	public float speed;
	public float fireRate;
	public GameObject dragonBall;

	// PRIVATE VARIABLES
	private Transform _dragonBallTransform;
	private Transform _transform;
	private float moveVertical;
	private Vector2 currentPostion;
	private float nextFire;
	private AudioSource _dragonShotSource;

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
		this._dragonBallTransform = this.dragonBall.gameObject.GetComponent<Transform> ();
		this._dragonShotSource = this.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			this._dragonBallTransform.position = this._transform.position;
			Instantiate (this.dragonBall);
			this._dragonShotSource.Play ();
		}

		this.currentPostion = this._transform.position;

		this.moveVertical = Input.GetAxis ("Vertical");
		if (this.moveVertical < 0) {
			this.currentPostion -= new Vector2 (0.0f, this.speed);
		}
		if (this.moveVertical > 0) {
			this.currentPostion += new Vector2 (0.0f, this.speed);
		}

		SetBoundary ();

		this._transform.position = this.currentPostion;
	}

	private void SetBoundary(){

		if(this.currentPostion.y <= -115){
			this.currentPostion.y = -115f;
		}

		if (this.currentPostion.y >= 115) {
			this.currentPostion.y = 115f;
		}
	}
}
