using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.VR;

public class OVRMenu : MonoBehaviour
{

    private LineRenderer LR;
    public RaycastHit RayHitInfo;
    public GameObject Blast;
   
  
    public GameObject progressBar;
    public Image progressBar_Image;
    AsyncOperation async;
    bool OnLevel;

    float count = 0;

    public Image StartButton, SettingsButton, SettingsCloseButton;
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
        if (PlayerPrefs.GetInt("Mute", 0) == 1)
        {
            MusicToggle.isOn = false;


        }

        else if (PlayerPrefs.GetInt("Mute", 0) == 0)
        {

            MusicToggle.isOn = true;
        }

        LR = GetComponent<LineRenderer>();
        LR.SetPosition(0, new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.0045f));

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
        Vector3 forward =  transform.TransformDirection(transform.forward);

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {

            
            if (Physics.Raycast(transform.position, forward, out RayHitInfo, Mathf.Infinity))
            {
                ///
               
              

                //
                if (RayHitInfo.collider.tag == "OVRStart")
                {
                    StartButton.GetComponent<Image>().sprite = StartButtonPressed;
                    Level_One_Async();
                }

                if (RayHitInfo.collider.tag == "OVRSettings")
                {

                    SettingsPanel.SetActive(true);
                    SettingsButton.GetComponent<Image>().sprite = StartButtonPressed;
                    SettingsCloseButton.GetComponent<Image>().sprite = StartButtonUP;
                }

                if (RayHitInfo.collider.tag == "OVRResetSettings")
                {
                    SettingsPanel.SetActive(false);
                    SettingsButton.GetComponent<Image>().sprite = StartButtonUP;
                    SettingsCloseButton.GetComponent<Image>().sprite = StartButtonPressed;
                }

                if (RayHitInfo.collider.tag == "OVRMusic")
                {
                    if (MusicToggle.isOn == true)
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

                if (RayHitInfo.collider.tag == "OVRQuit")
                {
                    Debug.Log("Quit Sucessfully");
                   Application.Quit();
                }

                
            }
        }

        LR.SetPosition(0, new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.0045f));

        if (Physics.Raycast(transform.position, forward, out RayHitInfo, Mathf.Infinity))
        {
           //var clone = Instantiate(Blast, RayHitInfo.point, transform.rotation);
            //Destroy(clone, 1f);
            if (RayHitInfo.collider)
            {
               
               
                LR.SetPosition(1, RayHitInfo.point);
            }

        }
        else
        {
            LR.SetPosition(1, forward * 50);
        }

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
