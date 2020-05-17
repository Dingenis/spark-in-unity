using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class QuestionnaireScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }


    public TimeElapsed TimeElapsed;


    public void OpenURL() {

        string environment;
        string currentSceneName = SceneManager.GetActiveScene().name;
        if(currentSceneName == "StratumseindNew") {
            environment = "Nieuw+Stratumseind";
        } else {
            environment = "Normaal+Stratumseind";
        }

        TimeSpan span = TimeSpan.FromSeconds(TimeElapsed.ElapsedTime);
        string timeText = string.Format("{0:D2}:{1:D2}", span.Minutes, span.Seconds);

        string url = string.Format("https://docs.google.com/forms/d/e/1FAIpQLSd8wxsi64IRGlKxj8Z6eoNVfsqfQbvNGz1_xIE9GiLT6YVDiA/viewform?usp=pp_url&entry.892589896={0}&entry.2130211631={1}", environment, timeText);
        Application.OpenURL(url);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
