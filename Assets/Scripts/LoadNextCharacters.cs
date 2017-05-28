using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextCharacters : MonoBehaviour
{

    public GameObject[] Characters;
    public GameObject StartBlast;
	void Start ()
    {
        Characters[0].SetActive(false);
        Invoke("PlayAfterSeconds", 2f);
	}
	
	
	void Update ()
    {
		
	}

    void PlayAfterSeconds()
    {
        Instantiate(StartBlast, Characters[0].transform.position, Quaternion.identity);
        Characters[0].SetActive(true);
    }
}
