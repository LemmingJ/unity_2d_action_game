using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public static class GameScore
{
    public static int score = 0;
}

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreUI;
    //private bool 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = GameScore.score.ToString();
    }
}
