using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Public Variables
	//public GameObject enemy;
	public int enemyCount;
	public float enemyWait;
	public float startEnemyWait;
	public float waveEnemyWait;
	public GameObject enemyDistration;

	// PRIVATE INSTANCE VARIABLE
	private Transform _enemyDTransform;

	// Use this for initialization
	void Start () {
		this._enemyDTransform = this.enemyDistration.GetComponent<Transform>();
		StartCoroutine (EnemyWaves ());
	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator EnemyWaves(){
		yield return new WaitForSeconds (this.startEnemyWait);

		while (true) {
			for (int i = 0; i < this.enemyCount; i++) {
				this._enemyDTransform.position = new Vector2 (212f, Random.Range (-125, 125));
				Instantiate (this.enemyDistration);
				yield return new WaitForSeconds (this.enemyWait);
			}
			yield return new WaitForSeconds (this.waveEnemyWait);
		}
	}
}
