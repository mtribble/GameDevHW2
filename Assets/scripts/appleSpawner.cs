using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate;
    public float spawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWithCoroutine());
    }


    void Spawn()
    {
        GameObject newApple = Instantiate(prefab, transform);
        newApple.GetComponent<Transform>().localScale = new Vector3(0.1f,0.1f,1f);
        newApple.GetComponent<Transform>().localPosition = new Vector2(0,-1);
    }

    IEnumerator SpawnWithCoroutine()
    {
        while(true)
        {
            Spawn();
            yield return new WaitForSeconds(spawnRate);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
