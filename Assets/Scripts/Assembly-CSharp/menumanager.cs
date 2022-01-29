using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
	public TMP_Text bestScore;

	private void Start()
	{
		bestScore.text = PlayerPrefs.GetInt("bestScore").ToString();
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			SceneManager.LoadScene(1);
		}
	}
}
