using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airplane_ctrl : MonoBehaviour
{
    private int cnt = 0;
   
    // Update is called once per frame
    void Update()
    {  
        if ( cnt < 2 ) {
            if ( transform.localPosition.x <= -5.0f ) {
                transform.localPosition = new Vector3(5.0f, transform.localPosition.y, transform.localPosition.z);
                cnt++;
            }
            else {
                transform.Translate(Vector3.left * 30.0f * Time.deltaTime);
            }
        }
        else {
            transform.localPosition = new Vector3(7.0f, 40.0f, transform.localPosition.z);
        }    
        
    }
}
