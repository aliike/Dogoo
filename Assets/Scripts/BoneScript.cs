using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEditor.Tilemaps;
using UnityEngine;

public class BoneScript : MonoBehaviour
{
    // Start is called before the first frame update
    

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
