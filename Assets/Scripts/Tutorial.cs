using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tutorial : MonoBehaviour
{


    public bool FountainClose = false;

    public float StartTime;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;
        this.StartTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 userPosition = transform.position;

        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 70)) {
            Collider collider = hit.collider;
            GameObject gObject = collider.gameObject;
            if(gObject.name == "River") {
                FountainClose = true;
                GameObject.Find("NearText").GetComponent<TextMeshProUGUI>().enabled = true;
            } else {
                FountainClose = false;
                GameObject.Find("NearText").GetComponent<TextMeshProUGUI>().enabled = false;
            }
        } else {
            FountainClose = false;
            GameObject.Find("NearText").GetComponent<TextMeshProUGUI>().enabled = false;
        }

    }
}
