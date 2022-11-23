using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sell_URL : MonoBehaviour
{
    void OnTriggerEnter(Collider coll) 
    {
        if ( coll.gameObject.name == "sensor" ) {
            Application.OpenURL("https://safari-village-sale.netlify.app/");

            GetComponent<ParticleSystem>().Play();
        }
                            
    }
}
