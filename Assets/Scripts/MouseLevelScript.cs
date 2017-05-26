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

    float count = 0;

    public Image StartButton,SettingsButton,SettingsCloseButton;
    public Sprite StartButtonPressed, StartButtonUP;
    public GameObject SettingsPanel;

    public Toggle MusicToggle;

    private void Start()
    {
        progressBar.SetActive(false);
        OnLevel = false;
        StartButton.GetComponent<Image>().sprite = StartButtonUP;
        SettingsButton.GetComponent<Image>().sprite = StartButtonUP;
       
        SettingsPanel.SetActive(false);

        ////
        if (PlayerPrefs.GetInt("Mute",0) == 1)
        {
            MusicToggle.isOn = false;
         

        }

        else if (PlayerPrefs.GetInt("Mute",0) == 0)
        {
          
            MusicToggle.isOn = true;
        }
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
                    StartButton.GetComponent<Image>().sprite = StartButtonPressed;
                    Level_One_Async();
                }

                if (RayHitInfo.collider.tag == "Settings")
                {
                   
                    SettingsPanel.SetActive(true);
                    SettingsButton.GetComponent<Image>().sprite = StartButtonPressed;
                    SettingsCloseButton.GetComponent<Image>().sprite = StartButtonUP;
                }

                if (RayHitInfo.collider.tag == "ResetSettings")
                {
                    SettingsPanel.SetActive(false);
                    SettingsButton.GetComponent<Image>().sprite = StartButtonUP;
                    SettingsCloseButton.GetComponent<Image>().sprite = StartButtonPressed;
                }

                if (RayHitInfo.collider.tag == "Music")
                {
                    if(MusicToggle.isOn == true)
                    {
                        MusicToggle.isOn = false;
                        PlayerPrefs.SetInt("Mute", 1);
                    }
                    else if (MusicToggle.isOn == false)
                    {
                        MusicToggle.isOn = true;
                        PlayerPrefs.SetInt("Mute", 0);
                    }
                }

                if (RayHitInfo.collider.tag == "Quit")
                {
                    Debug.Log("Quit Sucessfully");
                    Application.Quit();
                }
            }
        }

        Debug.DrawRay(OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTrackedRemote),transform.forward);

        if (Physics.Raycast(DrawPlaceBrush.transform.position, DrawPlaceBrush.transform.forward, out RayHitInfo, 10000f))
        {
            Debug.Log(RayHitInfo.collider.tag + count++);
        }
       // Debug.Log(MusicToggle.isOn);
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
