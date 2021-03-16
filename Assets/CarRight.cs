using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRight : MonoBehaviour
{
    float moveSpeed = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < -9)
        {
            Destroy(gameObject);
        }
    }
}
