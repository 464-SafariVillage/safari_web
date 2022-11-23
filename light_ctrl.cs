using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_ctrl : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right, 5.0f * Time.deltaTime);
    }
}
