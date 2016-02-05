using UnityEngine;
using System.Collections;

public class DragonCollider : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLE
	public GameController gameController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.CompareTag ("Enemy")) {
			this.gameController.LivesValue -= 1;
		}
		if (other.gameObject.CompareTag ("EnemyD")) {
			this.gameController.LivesValue -= 1;
		}
	}
}
