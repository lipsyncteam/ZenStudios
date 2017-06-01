using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextCharacters : MonoBehaviour
{

    public GameObject[] Characters;
    public GameObject[] StartBlast;
    public static int LevelNameCount;

    public bool OffUpdate = true;
    int randomNumber;
	void OnEnable ()
    {
        randomNumber = Random.Range(0, 5);
        OffUpdate = true;
    }
	
	void LoadingCharacterStart(int LevelNameCount)
    {
        Characters[LevelNameCount].SetActive(false);
        Invoke("PlayAfterSeconds", 2f);
    }

    private void Update()
    {
        if(OffUpdate == true)
        {
            OffUpdate = false;
            LoadingCharacterStart(LevelNameCount);
           
        }
    }

    void PlayAfterSeconds()
    {
        var clone = Instantiate(StartBlast[randomNumber], Characters[0].transform.position, Quaternion.identity);
        Destroy(clone, 2f);
        Characters[LevelNameCount].SetActive(true);
        gameObject.SetActive(false);
       
    }
}
