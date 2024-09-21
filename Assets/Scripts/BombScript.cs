using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEditor.Tilemaps;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer sr;
    public Sprite toChange;
    private void Start()
    {
        int greenOrRed = Random.Range(0, 2);
        if (greenOrRed == 1)
        {
            
            sr.color = Color.green;
            gameObject.tag = "greenBomb";
        }
        else
        {
            sr.color = Color.red;
            gameObject.tag = "redBomb";
        }


    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -7)
        {
            // Destroy the GameObject
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Çarpan objenin tag'i "Player" ise
        if (collision.gameObject.tag == "Player")
        {
            sr.sprite = toChange;
            sr.color = Color.white;
            {
                
            }
        }
    }
 
}
