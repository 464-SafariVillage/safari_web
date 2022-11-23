using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_ctrl : MonoBehaviour
{
    private float rand = 0.0f;
    private float speed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(2.0f, 6.0f);
        speed = Random.Range(1.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if ( transform.localPosition.x <= -5.0f ) {
            transform.localPosition = new Vector3(5.0f, transform.localPosition.y, transform.localPosition.z);
        }
    }

}
