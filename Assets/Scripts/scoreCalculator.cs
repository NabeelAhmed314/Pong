using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCalculator : MonoBehaviour
{
    public Text p1score;
    public Text p2score;
    public static int p1scorecount = 0;
    public static int p2scorecount = 0;

    // Start is called before the first frame update
    void Start()
    {
        p1score.text = (p1scorecount).ToString();
        p2score.text = (p2scorecount).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        p1score.text = (p1scorecount).ToString();
        p2score.text = (p2scorecount).ToString();
    }
}
