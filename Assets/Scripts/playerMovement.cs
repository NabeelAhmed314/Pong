using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed=5f;
    //static int score;
    public bool isPlayer1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {


        if (isPlayer1)
        {
            rb.velocity = new Vector2(0f,speed*  Input.GetAxis("Vertical"));
        }
        else
        {
            rb.velocity = new Vector2(0f, speed * Input.GetAxis("Vertical2"));
        }
    }

}
