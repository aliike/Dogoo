using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pineCone;
    public GameObject peanut;


    public float spawnWidth = 7.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnObject());
    }

    // Update is called once per frame
    
    public IEnumerator spawnObject()
    {
        while (true)
        {
            if(gameObject != null)
            {
                int rand = Random.Range(0, 3);
                if (rand == 0 )
                {
                    Instantiate(peanut, new Vector3(Random.Range(-spawnWidth, spawnWidth), Random.Range(6, 10), 0), Quaternion.identity);
                
                }
                else if (rand == 1 || rand ==2)
                {
                    Instantiate(pineCone, new Vector3(Random.Range(-spawnWidth, spawnWidth), Random.Range(6, 10), 0), Quaternion.identity);
                }
                
                yield return new WaitForSeconds(0.1f);
            }
            else
            {
                Debug.LogWarning("Circle prefab is missing!");
            }
        }
    }
}
