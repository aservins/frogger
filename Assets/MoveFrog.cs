using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveFrog : MonoBehaviour
{
    float jump = 0.95f;
    float x = 0;
    float y = -3.95f;
    public GameObject winFrog;
    int win = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector2.up * jump);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector2.down * jump);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector2.left * jump);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector2.right * jump);
        }

        if (win >= 5)
        {
            SceneManager.LoadScene("Win");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            SceneManager.LoadScene("Main");
        }
        if (collision.CompareTag("Win"))
        {
            win = win + 1; // win++;
            Instantiate(winFrog, collision.transform.position, collision.transform.rotation);
            transform.position = new Vector2(x, y);
        }
    }



}
