using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionnaireScript : MonoBehaviour
{

    public string URL;

    // Start is called before the first frame update
    void Start()
    {
        Application.OpenURL(URL);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
