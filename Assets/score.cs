using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    
    //TMP_Text myText;
    int points;
    [SerializeField] TMP_Text myScore;
    public int Points
    {
        get { return points; }
        set { points += value; myScore.text = Points.ToString(); }
    }

    // Start is called before the first frame update
    void Start()
    {
        //myScore = FindObjectsOfType<Score>();

        //myText = FindObjectOfType<TMP_Text>();

    }
    public void UpdateScore(int score)
    {
        
        points += score;
        myScore.text = Points.ToString();

        //Destroy(gameObject);
    }
    
    private void Update()
    {

        /*if(Input.GetButtonDown("Jump"))
        {
            Points += 1;
            myScore.text = points.ToString();
        }*/
           


    } 



}
