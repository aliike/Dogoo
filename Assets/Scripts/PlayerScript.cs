using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//using Unity.VisualScripting.Dependencies.NCalc;
using UnityEditor.Callbacks;

public class PlayerScript : MonoBehaviour
{
	public SpriteRenderer sr;
	public Sprite movingSprite;
	public Sprite notMovingSprite;
	public LogicScript logic;
	private float velocity = 20;
	private Vector3 lastPosition; 
	public int score;
	private float minX = -8;// Left border
	private float maxX = 8;// Right border
	public int size = 0;
	// Start is called before the first frame update
	void Start()
	{
		lastPosition = transform.position; 
		logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
	}

	// Update is called once per frame
	void Update()
	{
		MoveWithLimits();
		ChangeSpriteWhileMoving();
	}

	private void ChangeSpriteWhileMoving()
	{
		if (transform.position != lastPosition)
		{
			sr.sprite = movingSprite;	
		}
		else{
			sr.sprite = notMovingSprite;
		}
		// Update lastPosition for the next frame
		lastPosition = transform.position;
	}
	
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "greenBomb")
		{
			logic.ScaleUp(gameObject);			
		}
		if (collision.gameObject.tag == "redBomb")
		{
			logic.ScaleDown(gameObject);		
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
   
}
