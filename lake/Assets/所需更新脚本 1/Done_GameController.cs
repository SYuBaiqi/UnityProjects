using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Done_GameController : MonoBehaviour
{
	public GameObject[] hazards;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	
	public Text scoreText;
	public Text restartText;
	public Text gameOverText;

	private bool gameOver;
	private bool restart;
	private int score;
	
	void Start ()
	{
		gameOver = false;
		restart = false;
		if (scoreText != null) {
			restartText.text = "";
		}
		if (gameOverText != null) {
			gameOverText.text = "";
		}
		score = 0;
		

		UpdateScore ();
		StartCoroutine (SpawnWaves ());
	}
	
	void Update ()
	{

		if (sj.syzdsm == 0) {
			
			GameOver ();

		}
		if (restart)
		{
			if (Input.GetKeyDown (KeyCode.R))
			{
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
		}
	}
	
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				GameObject hazard = hazards [Random.Range (0, hazards.Length)];
				Vector3 spawnPosition = new Vector3 (Random.Range (25, 55), spawnValues.y, Random.Range (60, 90));
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
			
			if (gameOver)
			{
				if (restartText != null) {
					restartText.text = "Press 'R' for Restart";
				}
				restart = true;
				break;
			}
		}
	}
	
	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}
	
	void UpdateScore ()
	{
		if (scoreText != null) {
			scoreText.text = "Score: " + score;
		}
	}
	
	public void GameOver ()
	{
		if (gameOverText != null) {
			gameOverText.text = "Game Over!";
		}
		gameOver = true;

	}
}