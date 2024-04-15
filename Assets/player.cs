using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class player : MonoBehaviour
{
    Score myScore;
    TMP_Text myText;
    int score;
    //string = myScoreText;

    // Start is called before the first frame update
    void Start()
    {
       myScore = FindObjectOfType<Score>();
        //Destroy(gameObject,1);
        //myText = FindObjectOfType<TMP_Text>();
    }

    public void Click()
    {
        //Points += 1;
        myScore.UpdateScore(1);//.text = Points.ToString();

        Destroy(gameObject);
    }
    /*  private void Update()
      {
          //score = 0;
          if (myScore != null) 
          {
              Destroy(gameObject);
              myText.text = score.ToString();
          }
      }
       private void GetV()
       {
           return(Destroy(gameObject));
       }

       // Update is called once per frame
       void Update(void v)
       {
           if (v )
           {
               myScore.AddPoints(1);
           }

       }

   */
}
