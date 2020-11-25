using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Count;
    //public GameObject ball;
    public Text Score;
    public int score = 0;
    //private Vector2 BallStartPos;
    void Start()
    {
       // BallStartPos = gameObject.transform.position;
        Score = Count.GetComponent<Text>();
        Score.text = "0";

    }

    // Update is called once per frame
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
            // gameObject.transform.position = BallStartPos;
            SceneManager.LoadScene("SampleScene");

        }


    }
}
