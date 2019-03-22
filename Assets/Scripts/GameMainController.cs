using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameMainController : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
        scoreText.text = "Score " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
