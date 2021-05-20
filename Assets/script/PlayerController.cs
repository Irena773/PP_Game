using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    

  
    void Update()
    {
        
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.R))
        {

            this.gameObject.transform.Translate(0.02f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.L))
        {
            this.gameObject.transform.Translate(-0.02f, 0, 0);
        }
    }

    
}
