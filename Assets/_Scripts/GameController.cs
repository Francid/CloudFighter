using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Public Variables
	public GameObject enemy;
	public int enemyCount;
	public float enemyWait;
	public float startEnemyWait;
	public float waveEnemyWait;




	// Use this for initialization
	void Start () {
		StartCoroutine (EnemyWaves ());
	}
	
	// Update is called once per frame
	//void Update () {

	//}

	IEnumerator EnemyWaves(){
		yield return new WaitForSeconds (this.startEnemyWait);

		while (true) {
			for (int i = 0; i < this.enemyCount; i++) {
				Instantiate (this.enemy);
				yield return new WaitForSeconds (this.enemyWait);
			}
			yield return new WaitForSeconds (this.waveEnemyWait);
		}
	}
}
