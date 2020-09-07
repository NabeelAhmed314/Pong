using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    float vertical;
    public bool IsPlayer1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlayer1)
        {
           
            vertical = Input.GetAxis("Vertical");
        }
        else
        {
            
            vertical = Input.GetAxis("Vertical1");
        }
        
        Vector2 mov = new Vector2(0, vertical) * speed;
        rb.velocity = mov;

    }
}
