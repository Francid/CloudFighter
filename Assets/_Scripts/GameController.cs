using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	// Public Variables
	public int enemyCount;
	public float enemyWait;
	public float startEnemyWait;
	public float waveEnemyWait;
	public GameObject enemyDistration;
	public DragonController dragon;
	public EnemyController enemy;
	public Text livesLabel;
	public Text scoreLabel;
	public Text gameOverLabel;
	public Button restartButton;


	// PRIVATE INSTANCE VARIABLE
	private Transform _enemyDTransform;
	private int _scoreValue;
	private int _livesValue;

	public int ScoreValue{
		get{
			return this._scoreValue;
		}
		set{ 
			this._scoreValue = value;
			this.scoreLabel.text = "Score: " + this._scoreValue;
		}
	}

	public int LivesValue{
		get{
			return this._livesValue;
		}
		set{
			this._livesValue = value;
			if (this._livesValue <= 0) {
				this._EndGame ();
			}
			this.livesLabel.text = "Lives: " + this._livesValue;
		}
	}

	// Use this for initialization
	void Start () {
		this._Intialize ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void _Intialize(){
		this.ScoreValue = 0;
		this.LivesValue = 3;
		this.gameOverLabel.gameObject.SetActive (false);
		this.restartButton.gameObject.SetActive (false);

		this._enemyDTransform = this.enemyDistration.GetComponent<Transform>();
		StartCoroutine (EnemyWaves ());
	}

	private void _EndGame(){
		this.dragon.gameObject.SetActive (false);
		this.enemy.gameObject.SetActive (false);
		this.livesLabel.gameObject.SetActive (false);
		this.scoreLabel.gameObject.SetActive (false);
		this.gameOverLabel.gameObject.SetActive (true);
		this.restartButton.gameObject.SetActive (true);
	}

	// Instantiate New Enemy at a Setting time
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

	// Restart the Main Scene
	public void RestartButtonclick(){
		Application.LoadLevel ("Main");
	}
}
