using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud_ctrl : MonoBehaviour
{
    private GameObject sun;
    
    // Start is called before the first frame update
    void Start()
    {
        sun = GameObject.Find("Directional Light");
    }

    // Update is called once per frame
    void Update()
    {

        if ( transform.localPosition.x >= 10.0f || sun.transform.rotation.x < 0.0f ) {
            transform.localPosition = new Vector3(-10.0f, transform.localPosition.y, transform.localPosition.z);
        }
        else {
            transform.Translate(Vector3.right * 10.0f * Time.deltaTime);
        }
    }
}
