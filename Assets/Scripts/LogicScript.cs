using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class LogicScript : MonoBehaviour
{
    public PlayerScript ps;
    public BombScript bombScript;
    public Sprite explosionSprite;

    // Start is called before the first frame update
    public void ScaleUp(GameObject go)
    {
        
        Vector3 scaleToAdd = new Vector3(0.05f, 0.05f, 0.05f);
        go.transform.localScale += scaleToAdd;
        
    }
    public void ScaleDown(GameObject go)
    {
        //if (ps.score > 3){
       //     Vector3 scaleToSubtract = new Vector3(0.1f, 0.1f, 0.1f);
       //     go.transform.localScale -= scaleToSubtract;

      //  }
        Vector3 scaleToSubtract = new Vector3(0.05f, 0.05f, 0.05f);
        go.transform.localScale -= scaleToSubtract;
    }
    

    
}
