using UnityEngine;
using System.Collections;

public class FighterController : MonoBehaviour {

	// PUBLIC VARIABLES
	public float speed;

	// PRIVATE VARIABLES
	private Transform transform;
	private float moveVertical;
	private Vector2 currentPostion;

	// Use this for initialization
	void Start () {
		transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		this.currentPostion = this.transform.position;

		this.moveVertical = Input.GetAxis ("Vertical");
		if (this.moveVertical < 0) {
			this.currentPostion -= new Vector2 (0.0f, this.speed);
		}
		if (this.moveVertical > 0) {
			this.currentPostion += new Vector2 (0.0f, this.speed);
		}
		this.transform.position = this.currentPostion;
	}
}
