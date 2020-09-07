using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    float randomNumber;
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer(2));
       rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Debug.Log(rb.velocity);
    }
    // Update is called once per frame
    
    IEnumerator Timer(float time)
    {
        yield return new WaitForSeconds(time);
        GoBall();
    }
    void GoBall()
    {
        randomNumber = Random.Range(0, 2);
        if (randomNumber <= 0.5f)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(80, 10));
        }
        else
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-80, -10));
        }
        Debug.Log(rb.velocity);
    }
    private void Reset()
    {
        StopCoroutine("Timer");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        transform.position = new Vector2(0f, 0f);
        StartCoroutine(Timer(0.5f));
    }
    
}


