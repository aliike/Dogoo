using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//using Unity.VisualScripting.Dependencies.NCalc;
using UnityEditor.Callbacks;
using Unity.Netcode;

public class PlayerScript : NetworkBehaviour
{
	public SpriteRenderer sr;
	public Sprite movingRightSprite;
	public Sprite movingLeftSprite;
	public Sprite eatSprite;
	public Sprite notMovingSprite;
	public LogicScript logic;
	private float velocity = 20;
	private float lastPosition; 
	public int score;
	public int highestScore;
	private float minX = -8;// Left border
	private float maxX = 8;// Right border
	public int size = 0;
	// Start is called before the first frame update
	void Start()
	{
		lastPosition = transform.position.x; 
		logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
		highestScore = PlayerPrefs.GetInt("HighScore", 0);
	}

	// Update is called once per frame
	void Update()
	{
		MoveWithLimits();
		ChangeSpriteWhileMoving();
		
	}

	private void ChangeSpriteWhileMoving()
	{
		if (transform.position.x < lastPosition)
		{
			//sağa gidiyor
			sr.sprite = movingRightSprite;
		
		}
		else if (transform.position.x > lastPosition)
		{
			sr.sprite = movingLeftSprite;
		}
		else{
			sr.sprite = notMovingSprite;
		}
		// Update lastPosition for the next frame
		lastPosition = transform.position.x;
	}
	
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "Peanut")
		{
			//logic.ScaleUp(gameObject);
			score += 1;
			Destroy(collision.gameObject);	
			if (score > highestScore)
		{
			highestScore = score;

			// Save the new high score
			PlayerPrefs.SetInt("HighScore", highestScore);
			PlayerPrefs.Save();  // Ensure the data is saved immediately
			
			// Do Delete PlayerPrefs.DeleteKey("HighScore"); 
		}
		}
		else if (collision.gameObject.tag == "PineCone")
		{
			//logic.ScaleDown(gameObject);
			score -= 1;
		}
		
	}
	private void MoveWithLimits()
	{
		float move = Input.GetAxis("Horizontal") *  velocity * Time.deltaTime;

		// Update character's position along the x-axis
		Vector3 newPosition = transform.position;
		newPosition.x += move;

		// Clamp the position between the screen borders (minX, maxX)
		newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);

		// Apply the new position to the character
		transform.position = newPosition;
	}
   
	   void EndGame()
	{
		Debug.Log("Oyun Bitti! Skor: " + score);
		// Burada oyun sonu ekranı veya başka bir aksiyon alabilirsiniz
		
		// Sahneyi yeniden yükleyebilirsiniz (bu durumda oyun yeniden başlar):
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
