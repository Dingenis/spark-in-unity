using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeElapsed : MonoBehaviour
{

    public QuestionnaireScript Questionnaire;

    public float StartTime;

    public float ElapsedTime;

    public float DoneButtonAvailableTime;

    // Start is called before the first frame update
    void Start()
    {  
        this.StartTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        ElapsedTime = Time.time - this.StartTime;

        TimeSpan span = TimeSpan.FromSeconds(ElapsedTime);
        string timeText = string.Format("{0:D2}:{1:D2}", span.Minutes, span.Seconds);
        GetComponent<TextMeshProUGUI>().text = timeText;

        bool shouldDoneButtonBeEnabled = ElapsedTime > DoneButtonAvailableTime;
        if(shouldDoneButtonBeEnabled) {
            GameObject ExitText = GameObject.Find("Canvas/ExitText");
            ExitText.GetComponent<TextMeshProUGUI>().enabled = true;

            if(Input.GetKey(KeyCode.Escape)) {
                this.Questionnaire.OpenURL();
                Application.Quit();
            }
        } else {
            GameObject ExitText = GameObject.Find("Canvas/ExitText");
            ExitText.GetComponent<TextMeshProUGUI>().enabled = false;
        }

    }
}
