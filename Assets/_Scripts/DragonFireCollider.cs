using UnityEngine;
using System.Collections;

public class DragonFireCollider : MonoBehaviour {

	private AudioSource _fireBallSource;

	// Use this for initialization
	void Start () {
		this._fireBallSource = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public void OnTriggerEnter2D(Collider2D other){
		
		if (other.gameObject.CompareTag ("Enemy")) {
			Destroy (this.gameObject);
			this._fireBallSource.Play ();
		}
		if (other.gameObject.CompareTag ("EnemyD")) {
			Destroy (this.gameObject);
			this._fireBallSource.Play ();
		}
	}
}
