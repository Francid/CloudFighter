using UnityEngine;
using System.Collections;

public class CloudMover : MonoBehaviour {

	// Public Variables
	public float speed;

	//Private Variables
	private Transform _transform;
	private Vector2 cloudPosition;

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
		this.Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		this.cloudPosition = this._transform.position;
		this.cloudPosition -= new Vector2 (this.speed, 0.0f);
		this._transform.position = this.cloudPosition;

		if (this.cloudPosition.x <= -608) {
			this.Reset ();
		}
	}

	public void Reset(){
		this._transform.position = new Vector2 (608f, 0.0f);
	}
}
