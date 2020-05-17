using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Chooser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("LoadingText").GetComponent<Text>().enabled = false;
        GetComponent<VideoPlayer>().loopPointReached += OnVideoEnded;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape)) {
            VideoPlayer vp = GetComponent<VideoPlayer>();
            vp.Pause();
            OnVideoEnded(vp);
        }   
    }

    enum Scenes {
        New, Normal
    }

    void OnVideoEnded(VideoPlayer player) {

        player.enabled = false;
        GameObject.Find("LoadingText").GetComponent<Text>().enabled = true;


        bool randomValue = (Random.value >= 0.5);

        Scenes sceneToLoad;
        if(randomValue) {
            sceneToLoad = Scenes.New;
        } else {
            sceneToLoad = Scenes.Normal;
        }

        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadSceneAsync(sceneToLoad));
    }

    IEnumerator LoadSceneAsync(Scenes scene)
    {
        AsyncOperation asyncLoad;
        switch(scene) {
            case Scenes.New:
            asyncLoad = SceneManager.LoadSceneAsync("StratumseindNew");
            break;
            case Scenes.Normal:
            asyncLoad = SceneManager.LoadSceneAsync("StratumseindNew");
            break;
            default:
            asyncLoad = SceneManager.LoadSceneAsync("StratumseindNew");
            break;
        }

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
