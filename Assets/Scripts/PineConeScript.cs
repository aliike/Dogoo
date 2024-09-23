using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PineConeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer sr;    
    
    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -7)
        {
            Destroy(gameObject);
        }
    }

    

}
