using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chooser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool randomValue = (Random.value >= 0.5);

        if(randomValue) {
            SceneManager.LoadScene("StratumseindNew");
        } else {
            SceneManager.LoadScene("StratumseindNormal");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
