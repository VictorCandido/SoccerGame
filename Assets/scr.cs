using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    public int speed;
    public string player;

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player == "1")
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                rb2d.AddForce(Vector3.up * 300000);   
            }
        }
        
        if(player == "2")
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb2d.AddForce(Vector3.up * 300000);
            }
        }
        
    }
}
