using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class text : MonoBehaviour
{

    public Text scoretext;
    public static int score = 0;
    public static int highscore;
    public Text highscoretext;

    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        highscore = PlayerPrefs.GetInt("Highscore");
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "score" + score;

        highscoretext.text = "highScore" + highscore;
        if(score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("Highscore", highscore);
        }
    }
}
