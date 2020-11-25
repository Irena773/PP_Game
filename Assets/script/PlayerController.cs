using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    

  
    void Update()
    {
        
        if (Input.GetKey(KeyCode.RightArrow)){

            this.gameObject.transform.Translate(0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.transform.Translate(-0.05f, 0, 0);
        }
    }

    
}
