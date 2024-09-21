using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class LogicScript : MonoBehaviour
{
    public PlayerScript ps;
    
    
    
    
    // Start is called before the first frame update
    public void ScaleUp(GameObject go)
    {
        
        Vector3 scaleToAdd = new Vector3(0.2f,0.2f,0.2f);
        go.transform.localScale += scaleToAdd;
        ps.score++;
        
    }
    public void ScaleDown(GameObject go)
    {
        if (ps.score > 3){
            Vector3 scaleToSubtract = new Vector3(0.2f, 0.2f, 0.2f);
            go.transform.localScale -= scaleToSubtract;
            ps.score--;
        }
        
    }

    
}
