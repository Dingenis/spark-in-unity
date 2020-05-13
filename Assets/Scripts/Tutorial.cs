using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{


    public bool FountainClose = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 userPosition = transform.position;

        GameObject fountain = GameObject.Find("Fountain");
        
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 70)) {
            Collider collider = hit.collider;
            GameObject gObject = collider.gameObject;
            if(gObject.name == "Fountain") {
                FountainClose = true;
            } else {
                FountainClose = false;
            }
        } else {
            FountainClose = false;
        }

    }
}
