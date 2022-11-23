using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class truck_ctrl : MonoBehaviour
{
    public float speed = 50.0f;
    private Vector3 target;
   // private GameObject prisoner;
   // private GameObject sensor;

   
    void Start()
    {
        target = transform.position;
      //  sensor = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetMouseButtonDown(0) ) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if ( Physics.Raycast(ray, out hit, 100.0f))
            {
                target = hit.point;
                target.y = transform.position.y;

               /* if ( hit.collider.tag == "Animal" ) {
                    
                    prisoner = GameObject.Find(hit.collider.gameObject.name);
                    prisoner.transform.SetParent(sensor.transform);
                    prisoner.transform.localPosition = new Vector3(0.0f, 1.0f, 1.5f);
                  //  prisoner.constraints = RigidbodyConstraints.FreezePositionX;
                }*/
                
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

      
    }
   
}
