using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class highscore : MonoBehaviour
{
    public Text highscoretext;
    float Highscore = 0;
    public Score score;

    void Update()
    {
        highscoretext.text = "HighScore = " + Highscore.ToString("0");
        if(Highscore < score.player.position.z)
    {
        
        highscoretext.text = score.player.position.z.ToString("0");
        Highscore = score.player.position.z;
    }
    else 
    {
        highscoretext.text = Highscore.ToString("0");
    }

    }
}
