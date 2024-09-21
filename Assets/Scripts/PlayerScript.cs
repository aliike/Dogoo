using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using Unity.VisualScripting.Dependencies.NCalc;

public class PlayerScript : MonoBehaviour
{
    public LogicScript logic;
    private float velocity = 20;
    public int score;
    private float minX = -8;// Left border
    private float maxX = 8;

    public int size = 0;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "greenBomb")
        {
            logic.ScaleUp(gameObject);
            size += 1;
            
            Debug.Log(score);
        }
        if (collision.gameObject.tag == "redBomb")
        {
            logic.ScaleDown(gameObject);
            size -= 1;
            
            Debug.Log(score);
        }
    }

   
}
