using UnityEngine;
using System.Collections;

public class DragonCollider : MonoBehaviour {

	private AudioSource[] _audioSource;
	private AudioSource _dragonCollider;


	// PUBLIC INSTANCE VARIABLE
	public GameController gameController;

	// Use this for initialization
	void Start () {
		this._audioSource = this.gameObject.GetComponents<AudioSource> ();
		this._dragonCollider = this._audioSource [1];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.CompareTag ("Enemy")) {
			this._dragonCollider.Play ();
			this.gameController.LivesValue -= 1;
		}
		if (other.gameObject.CompareTag ("EnemyD")) {
			this._dragonCollider.Play ();
			this.gameController.LivesValue -= 1;
		}
	}
}
