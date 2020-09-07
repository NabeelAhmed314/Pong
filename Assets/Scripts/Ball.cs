using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject prefab;
    Rigidbody rb;
    public float speed = 1f;
    public int sx, sy;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Inside Start");
        StartCoroutine(waiter());
        Debug.Log("After Coroutine");

    }

    IEnumerator waiter()
    {
        Debug.Log("Inside Coroutine");
        yield return new WaitForSeconds(4);
        sx = Random.Range(0, 2) == 0 ? -1 : 1;
        sy = Random.Range(0, 2) == 0 ? -5 : 5;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(sx * speed, sy * speed, 0f);
    }


    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("leftBorder"))
        {
            scoreCalculator.p2scorecount += 1;
            Destroy(this.gameObject);
            Instantiate(prefab, new Vector3(0f, 0f, -8.304f), Quaternion.identity);

        }
        else if (col.gameObject.CompareTag("rightBorder"))
        {
            scoreCalculator.p1scorecount += 1;
            Destroy(this.gameObject);
            Instantiate(prefab, new Vector3(0f, 0f, -8.304f), Quaternion.identity);

        }
    }
}
