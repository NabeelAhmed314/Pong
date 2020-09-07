using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStart : MonoBehaviour
{
    public GameObject ballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ballPrefab,new Vector3(0f,0f, -8.304f), Quaternion.identity);
    }
     
    // Update is called once per frame
    void Update()
    {

    }
}
