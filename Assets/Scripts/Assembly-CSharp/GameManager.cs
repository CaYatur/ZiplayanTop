using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public TMP_Text scoreText;

	public int score;

	private void Start()
	{
	}

	private void Update()
	{
		scoreText.text = score.ToString();
		if (score > PlayerPrefs.GetInt("bestScore"))
		{
			PlayerPrefs.SetInt("bestScore", score);
		}
	}

	public void restartGame()
	{
		SceneManager.LoadScene(0);
	}
}
