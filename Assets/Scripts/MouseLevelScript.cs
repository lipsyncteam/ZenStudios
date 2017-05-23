using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MouseLevelScript : MonoBehaviour {

    public GameObject DrawPlaceBrush;
    public RaycastHit RayHitInfo;
  
    public GameObject progressBar;
    public Image progressBar_Image;
    AsyncOperation async;
    bool OnLevel;

    private void Start()
    {
        progressBar.SetActive(false);
        OnLevel = false;
    }

    public void Level_One_Async()
    {
        if (OnLevel == false)
        {
            StartCoroutine(LoadLevel_One("MainScene"));
            progressBar.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(DrawPlaceBrush.transform.position, DrawPlaceBrush.transform.forward, out RayHitInfo, 10000f))
            {
                if (RayHitInfo.collider.tag == "Start")
                {
                    Level_One_Async();
                }
                Debug.Log(RayHitInfo.collider.tag);
            }
        }

        Debug.DrawRay(DrawPlaceBrush.transform.position, DrawPlaceBrush.transform.forward);



    }


    IEnumerator LoadLevel_One(string levelname)
    {
        async = SceneManager.LoadSceneAsync(levelname);
        progressBar_Image.fillAmount = async.progress;
        async.allowSceneActivation = false;
        print(async.progress);
        while (!async.isDone)
        {
            OnLevel = true;
            print(async.progress);
            progressBar_Image.fillAmount = async.progress;
            async.allowSceneActivation = true;

            yield return null;
        }

        yield return async;
    }
}
