using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GUIScript : MonoBehaviour
{
	public PlayerScript ps;
	//public Text scoreText;
	//public Text highestScoreText;
	
	public TextMeshProUGUI scoreText;
	public TextMeshProUGUI highestScoreText;
	public GameObject pauseMenu;
	private bool isPaused = false;
	

	// Start is called before the first frame update
	void Start()
	{
		GameObject player = GameObject.FindWithTag("Player");
		ps = player.GetComponent<PlayerScript>();
		
	}

	// Update is called once per frame
	void Update()
	{
		scoreText.text = "Score: "+ps.score.ToString();
		highestScoreText.text = "Best Score: " + ps.highestScore.ToString();
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (isPaused)
			{
				pauseMenu.SetActive(false);
				Resume(); 
				
				// Resume if currently paused
			}
			else
			{
				OpenMainMenu(); // Pause if not already paused
			}
		}
		
	
	}

	public void OpenMainMenu()
	{
		Pause();
		pauseMenu.SetActive(true);
	}
	public void ResumeButton()
	{
		pauseMenu.SetActive(false);
		Resume();
	}
	public void RestartButton()
	{
		SceneManager.LoadScene("Gameplay");
		Resume();
	}
	public void OptionsButton()
	{
		
	}
	
	public void Pause()
	{
		isPaused = true;
		Time.timeScale = 0f;
	}
	public void Resume()
	{
		Time.timeScale = 1f;
		isPaused = false;
	}
}
