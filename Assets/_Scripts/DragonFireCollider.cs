using UnityEngine;
using System.Collections;

public class DragonFireCollider : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.CompareTag ("Enemy")) {
			Destroy (this.gameObject);
		}
		if (other.gameObject.CompareTag ("EnemyD")) {
			Destroy (this.gameObject);
		}
	}
}
