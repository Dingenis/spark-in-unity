using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Chooser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VideoPlayer>().loopPointReached += OnVideoEnded;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnVideoEnded(VideoPlayer player) {
        bool randomValue = (Random.value >= 0.5);

        if(randomValue) {
            SceneManager.LoadScene("StratumseindNew");
        } else {
            SceneManager.LoadScene("StratumseindNormal");
        }
    }
}
