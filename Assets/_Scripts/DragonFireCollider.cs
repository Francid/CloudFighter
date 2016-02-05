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
			Debug.Log ("Collider with the enemey");
			Destroy (this.gameObject);
		}
	}
}
