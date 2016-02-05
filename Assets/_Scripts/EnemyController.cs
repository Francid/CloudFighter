using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLE
	public int enemySpeed;
	public GameController gameController;

	//Private Variables
	private Transform _transform;
	private Vector2 enemyPosition;

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
		this.Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		this.enemyPosition = this._transform.position;
		this.enemyPosition -= new Vector2 (this.enemySpeed, 0.0f);
		this._transform.position = this.enemyPosition;

		if (this.enemyPosition.x <= -220) {
			this.Reset ();
		}
	}

	public void Reset(){
		this._transform.position = new Vector2 (220f, Random.Range(-119,119));
	}

	public void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.CompareTag ("DragonFire")) {
			this.gameController.ScoreValue += 50;
			Reset ();
		}
		if (other.gameObject.CompareTag ("Dragon")) {
			Reset ();
		}
	}
}
