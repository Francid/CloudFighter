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
		StartCoroutine ("BulletFlight");
	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator BulletFlight () {
		do{
		this.ballCurrentPosition = this._transform.position;
		this.ballCurrentPosition += new Vector2 (fireRate * Time.deltaTime, 0.0f);
		this._transform.position = ballCurrentPosition;
		yield return null;
		}while(true);
	}
}
