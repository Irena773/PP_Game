using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    
    public GameObject Count;
    public Text Score;
    public int score = 0;
    
    void Start()
    {
      
        Score = Count.GetComponent<Text>();
        Score.text = "0";

    }

    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "piku")
        {
            score += 1;
            Score.text = score.ToString();

        }
        else if (collision.gameObject.tag == "underground")
        {
            
            score = 0;
            Score.text = score.ToString();
            SceneManager.LoadScene("SampleScene");

        }


    }
}
