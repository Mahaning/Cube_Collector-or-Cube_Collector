using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{ 
    public Text ScoreText;
    public Text finalScore;
    int myScore=0;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        ScoreText.text=myScore.ToString();
         finalScore.text="Score:"+myScore.ToString();
    }
    public void Addscore(int score)
    {
        myScore=myScore+score;
        // finalScore.text="Score:"+myScore.ToString();
    }
}

