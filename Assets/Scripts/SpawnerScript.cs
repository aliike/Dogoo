using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject circle;
    
    public float spawnWidth = 7.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnCircle());
    }

    // Update is called once per frame
    
    public IEnumerator spawnCircle()
    {
        while (true)
        {
            if(gameObject != null)
            {
                Instantiate(circle, new Vector3(Random.Range(-spawnWidth, spawnWidth), Random.Range(6, 10), 0), Quaternion.identity);
                yield return new WaitForSeconds(0.2f);
            }
            else
            {
                Debug.LogWarning("Circle prefab is missing!");
            }
        }
    }
}
