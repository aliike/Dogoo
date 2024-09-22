using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GUIScript : MonoBehaviour
{
	public PlayerScript ps;
	public Text scoreText;
	public int textNumber = 5 ;
	

	// Start is called before the first frame update
	void Start()
	{
		scoreText.text = "Score: ";

	}

	// Update is called once per frame
	void FixedUpdate()
	{
		scoreText.text = "Score: "+textNumber;
		textNumber++;
	}

	
}
