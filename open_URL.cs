using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_URL : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if ( Input.GetMouseButtonDown(0) ) {

            Application.OpenURL("www.naver.com/");
        }

    }
}
