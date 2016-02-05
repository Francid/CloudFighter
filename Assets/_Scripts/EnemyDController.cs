using UnityEngine;
using System.Collections;

public class EnemyDController : MonoBehaviour {

	// PRIVATE INSTANCE VARIABLE
	private Transform _enemyDTransform;
	private Vector2 _enemyDPosition;

	// PUBLIC INSTANCE VARIABLE
	public float speed;

	// Use this for initialization
	void Start () {
		this._enemyDTransform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		this._enemyDPosition = this._enemyDTransform.position;
		this._enemyDPosition -= new Vector2 (this.speed, 0.0f);
		this._enemyDTransform.position = this._enemyDPosition;

		if (this._enemyDTransform.position.x <= -212) {
			Destroy(gameObject);
		}
	}

	public void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.CompareTag ("DragonFire")) {
			Destroy(gameObject);
		}
		if (other.gameObject.CompareTag ("Dragon")) {
			Destroy(gameObject);
		}
	}
}
