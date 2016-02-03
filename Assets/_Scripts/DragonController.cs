using UnityEngine;
using System.Collections;

public class DragonController : MonoBehaviour {

	// PUBLIC VARIABLES
	public float speed;

	// PRIVATE VARIABLES
	private Transform _transform;
	private float moveVertical;
	private Vector2 currentPostion;

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

		/*if (Input.GetButton ("Fire1")) {
			Instantiate (this.ball, this.ballSpawn.transform.position, this.ballSpawn.transform.rotation);
		}*/

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
