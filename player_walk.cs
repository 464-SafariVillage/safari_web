using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_walk : MonoBehaviour
{
    private float speed = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance_per_frame = speed * Time.deltaTime;
        float horizontal_input = Input.GetAxis("Horizontal");
        float vertical_input = Input.GetAxis("Vertical");
      
        transform.Translate(Vector3.left * horizontal_input * distance_per_frame);
        transform.Translate(Vector3.down * vertical_input * distance_per_frame);
    }

}
