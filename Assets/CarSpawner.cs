using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject car;
    bool isSpawning = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isSpawning)
        {
            StartCoroutine(Spawn());
        }
    }

    IEnumerator Spawn()
    {
        isSpawning = true;
        Instantiate(car, transform.position, transform.rotation);
        yield return new WaitForSeconds(1.5f);
        isSpawning = false;
    }

}
