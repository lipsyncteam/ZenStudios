using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextCharacters : MonoBehaviour
{

    public GameObject[] Characters;
    public GameObject StartBlast;
    public static int LevelNameCount;
	void Awake ()
    {
        LoadingCharacterStart(LevelNameCount);

    }
	
	void LoadingCharacterStart(int LevelNameCount)
    {
        Characters[LevelNameCount].SetActive(false);
        Invoke("PlayAfterSeconds", 2f);
    }
	

    void PlayAfterSeconds()
    {
        var clone = Instantiate(StartBlast, Characters[0].transform.position, Quaternion.identity);
        Destroy(clone, 2f);
        Characters[LevelNameCount].SetActive(true);
        LevelNameCount++;
        gameObject.SetActive(false);
        LevelNameCount++;
    }
}
