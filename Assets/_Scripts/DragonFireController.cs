using UnityEngine;
using System.Collections;

public class DragonFireController : MonoBehaviour {

	// PUBLIC VARIABLE
	public float fireRate;

	// PRIVATE VARIABLES
	private Transform _transform;
	private Vector2 ballCurrentPosition;


	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		this.ballCurrentPosition = this._transform.position;
		this.ballCurrentPosition += new Vector2 (fireRate, 0.0f);
		this._transform.position = ballCurrentPosition;
		setBoundary ();
	}

	private void setBoundary(){

		if(this.ballCurrentPosition.x >= 195){
			Destroy (this.gameObject);
		}
	}
}
