using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GUIScript : MonoBehaviour
{
	public PlayerScript ps;
	//public Text scoreText;
	//public Text highestScoreText;
	
	public TextMeshProUGUI scoreText;
	public TextMeshProUGUI highestScoreText;
	
	
	
	

	// Start is called before the first frame update
	void Start()
	{
		GameObject player = GameObject.FindWithTag("Player");
		ps = player.GetComponent<PlayerScript>();
		//scoreText.text = "Score: ";
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		scoreText.text = ps.score.ToString();
		highestScoreText.text = "Highest Score: " + ps.highestScore.ToString();
		
	}

	
}
